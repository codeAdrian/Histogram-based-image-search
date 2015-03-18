using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Diagnostics;

namespace ImageSearch_db
{
    public partial class ImageSearchDB : Form
    {
        public ImageSearchDB()
        {
            InitializeComponent();
        }

        StringBuilder descriptor_image_input = new StringBuilder();
        StringBuilder descriptor_image_db = new StringBuilder();
        int[] histogram_image_input_25 = new int[25];
        int[] histogram_image_db_25 = new int[25];
        int[] histogram_best_match_25 = new int[25];
        float[] histogram_compare_25 = new float[25];
        int[] dimensions_image_input = new int[2];
        int[] dimensions_image_db = new int[2];
        int[] dimensions_best_match = new int[2];
        string path = string.Empty;
        Image img;Bitmap bmp;
        int bmpHeight, bmpWidth;

        string imageName, imageAuthor;

        void createImageHistogram_25(int colorAverage, int[] histogram_temp)
        {
            if (colorAverage > 240) { Interlocked.Increment(ref histogram_temp[24]);}
            else if (colorAverage > 230) { Interlocked.Increment(ref histogram_temp[23]); }
            else if (colorAverage > 220) { Interlocked.Increment(ref histogram_temp[22]); }
            else if (colorAverage > 210) { Interlocked.Increment(ref histogram_temp[21]); }
            else if (colorAverage > 200) { Interlocked.Increment(ref histogram_temp[20]); }
            else if (colorAverage > 190) { Interlocked.Increment(ref histogram_temp[19]); }
            else if (colorAverage > 180) { Interlocked.Increment(ref histogram_temp[18]); }
            else if (colorAverage > 170) { Interlocked.Increment(ref histogram_temp[17]); }
            else if (colorAverage > 160) { Interlocked.Increment(ref histogram_temp[16]); }
            else if (colorAverage > 150) { Interlocked.Increment(ref histogram_temp[15]); }
            else if (colorAverage > 140) { Interlocked.Increment(ref histogram_temp[14]); }
            else if (colorAverage > 130) { Interlocked.Increment(ref histogram_temp[13]); }
            else if (colorAverage > 120) { Interlocked.Increment(ref histogram_temp[12]); }
            else if (colorAverage > 110) { Interlocked.Increment(ref histogram_temp[11]); }
            else if (colorAverage > 100) { Interlocked.Increment(ref histogram_temp[10]); }
            else if (colorAverage > 90) { Interlocked.Increment(ref histogram_temp[9]); }
            else if (colorAverage > 80) { Interlocked.Increment(ref histogram_temp[8]); }
            else if (colorAverage > 70) { Interlocked.Increment(ref histogram_temp[7]); }
            else if (colorAverage > 60) { Interlocked.Increment(ref histogram_temp[6]); }
            else if (colorAverage > 50) { Interlocked.Increment(ref histogram_temp[5]); }
            else if (colorAverage > 40) { Interlocked.Increment(ref histogram_temp[4]); }
            else if (colorAverage > 30) { Interlocked.Increment(ref histogram_temp[3]); }
            else if (colorAverage > 20) { Interlocked.Increment(ref histogram_temp[2]); }
            else if (colorAverage > 10) { Interlocked.Increment(ref histogram_temp[1]); }
            else Interlocked.Increment(ref histogram_temp[0]);
        }

        private void convertImage_lockBits(Bitmap image, int[] histogram)
        {
            Bitmap bm = new Bitmap(image.Width, image.Height);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmd = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);
            int[] pixelData = new int[(rect.Height * rect.Width)];
            System.Runtime.InteropServices.Marshal.Copy(bmd.Scan0, pixelData, 0, pixelData.Length);

            for (int i = 0; i < pixelData.Length; i++)
            {
                Color currentPixel = Color.FromArgb(pixelData[i]);
                createImageHistogram_25(rgbToGrayscale(currentPixel), histogram);
            }
            image.UnlockBits(bmd);
        }

        private void convertImage_parallelForLockBits(Bitmap image, int[] histogram)
        {
            Bitmap bm = new Bitmap(image.Width, image.Height);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmd = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);
            int[] pixelData = new int[(rect.Height * rect.Width)];
            System.Runtime.InteropServices.Marshal.Copy(bmd.Scan0, pixelData, 0, pixelData.Length);
            Parallel.For(0, pixelData.Length, i => {
                Color currentPixel = Color.FromArgb(pixelData[i]);
                createImageHistogram_25(rgbToGrayscale(currentPixel), histogram);
                });
            image.UnlockBits(bmd);
        }

        private void convertImage_standard(Bitmap bmp, int[] histogram)
        {
            bmpHeight = bmp.Height;
            bmpWidth = bmp.Width;
            for (int y = 0; y < bmpHeight; y++)
            {
                for (int x = 0; x < bmpWidth; x++)
                {
                    Color currentPixel = bmp.GetPixel(x, y);

                    createImageHistogram_25(rgbToGrayscale(currentPixel), histogram);
                }
            }
        }

        Stopwatch test = new Stopwatch();
        private int rgbToGrayscale(Color currentPixel)
        {
            if (rb_RGBavg.Checked == true) return(currentPixel.R + currentPixel.G + currentPixel.B) / 3;
            else if (rb_luma.Checked == true) return(int)(0.3 * currentPixel.R + 0.59 * currentPixel.G + 0.11 * currentPixel.B);
            else if (rb_SingleChannel.Checked == true) return currentPixel.G;
            else return Math.Max(currentPixel.R, Math.Max(currentPixel.G, currentPixel.B)) + Math.Min(currentPixel.R, Math.Min(currentPixel.G, currentPixel.B)) / 2;
        }
        float scale = 1;
        private float compareHistograms(int[] descriptors_image1, int[] descriptors_image2, float[] descriptors_compare)
        {
            float matching = 0;
            Array.Clear(descriptors_compare, 0, descriptors_compare.Length);
            scale = 1;
            if (dimensions_image_input[0] == dimensions_image_db[0] && dimensions_image_input[1] == dimensions_image_db[1]) scale = 1;
            else if (dimensions_image_input[1] == dimensions_image_db[0] && dimensions_image_input[0] == dimensions_image_db[1]) scale = 1;
            else
            {
                if (dimensions_image_input[0] > dimensions_image_db[0]) scale *= (float)dimensions_image_input[0] / dimensions_image_db[0];
                else scale *= (float)dimensions_image_db[0] / dimensions_image_input[0];
                if (dimensions_image_input[1] > dimensions_image_db[1]) scale *= (float)dimensions_image_input[1] / dimensions_image_db[1];
                else scale *= (float)dimensions_image_db[1] / dimensions_image_input[1];
            }

            for (int i = 0; i < 25; i++)
            {
                if (descriptors_image1[i] == 0 || descriptors_image2[i] == 0)
                {
                    if (descriptors_image1[i] == 0 && descriptors_image2[i] == 0) descriptors_compare[i] = 1;
                    else if (descriptors_image1[i] != 0 && descriptors_image2[i] == 0) descriptors_compare[i] = ((float)(1 / (descriptors_image1[i] * scale)));
                    else if (descriptors_image1[i] == 0 && descriptors_image2[i] != 0) descriptors_compare[i] = ((float)(1 / (descriptors_image2[i] * scale)));
                }

                else
                {
                    if (descriptors_image1[i] > descriptors_image2[i])
                    {
                        if (descriptors_image2[i] * scale > descriptors_image1[i]) descriptors_compare[i] = (descriptors_image1[i] / (descriptors_image2[i] * scale));
                        else descriptors_compare[i] = (descriptors_image2[i] * scale) / (descriptors_image1[i]);
                    }

                    else
                    {
                        if (descriptors_image1[i] * scale > descriptors_image2[i]) descriptors_compare[i] = descriptors_image2[i] / (descriptors_image1[i] * scale);
                        else descriptors_compare[i] = (descriptors_image1[i] * scale) / (descriptors_image2[i]);
                    }
                }
                if (descriptors_compare[i] >= 0.75 && descriptors_compare[i] <= 1) matching += 4;
            }

            return matching;
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif, *jpeg)|*.bmp;*.jpg;*.png;*.gif;*.jpeg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Thread.CurrentThread.IsBackground = true;
                rb_desaturation.Enabled = false;
                rb_luma.Enabled = false;
                rb_method_lockBits.Enabled = false;
                rb_method_parallel.Enabled = false;
                rb_method_standard.Enabled = false;
                rb_RGBavg.Enabled = false;
                rb_SingleChannel.Enabled = false;
                btn_compare.Enabled = false;
                btn_loadImage.Enabled = false;
                btn_showHistogramSearch.Enabled = false;
                btn_showHistogram.Enabled = false;
                Array.Clear(histogram_image_input_25, 0, histogram_image_input_25.Length);
                descriptor_image_input.Clear();
                path = string.Empty;
                path = file.FileName;
                img = Image.FromFile(path.Trim('\\'));
                bmp = new Bitmap(img, img.Width, img.Height);
                pbx_image1.Image = img;
                pbx_image1.SizeMode = PictureBoxSizeMode.Zoom;
                Stopwatch processingTime = new Stopwatch();
                processingTime.Start();

                if (rb_method_standard.Checked == true)
                {
                    processingTime.Start();
                    convertImage_standard(bmp, histogram_image_input_25);
                    processingTime.Stop();
                }
                else if (rb_method_lockBits.Checked == true){
                    processingTime.Start();
                    convertImage_lockBits(bmp, histogram_image_input_25);
                    processingTime.Stop();
                }

                else{
                    processingTime.Start();
                    convertImage_parallelForLockBits(bmp, histogram_image_input_25);
                    processingTime.Stop();
                }
                lbl_time.Text = "Processing time: " + processingTime.ElapsedMilliseconds.ToString() + " ms";
                dimensions_image_input[0] = img.Width;
                dimensions_image_input[1] = img.Height;
                descriptor_image_input.Append(img.Width + " " + img.Height + " ");
                for (int i = 0; i < 25; i++)
                {
                    if (i == 24) descriptor_image_input.Append(histogram_image_input_25[i].ToString());
                    else descriptor_image_input.Append(histogram_image_input_25[i].ToString() + " ");
                }
                rtbx_histogram1.Text = descriptor_image_input.ToString();
                rb_desaturation.Enabled = true;
                rb_luma.Enabled = true;
                rb_method_lockBits.Enabled = true;
                rb_method_parallel.Enabled = true;
                rb_method_standard.Enabled = true;
                rb_RGBavg.Enabled = true;
                rb_SingleChannel.Enabled = true;
                btn_compare.Enabled = true;
                btn_loadImage.Enabled = true;
                btn_showHistogramSearch.Enabled = true;
                btn_showHistogram.Enabled = true;
            }
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            lbl_scale.Text = "Scale: ";
            lbl_author.Text = "Author: ";
            lbl_title.Text = "Title: ";
            new Thread(() =>
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() && pbx_image1.Image!=null)
                {
                    string mySqlConnection="";
                    Stopwatch compareTime = new Stopwatch();
                    float matchMax=0;
                    int searchedImages = 0;
                    MySqlCommand command = new MySqlCommand();
                    mySqlConnection = "SERVER=localhost;DATABASE=image_database;UID=root;PASSWORD=;";
                    try
                    {
                        using (MySqlConnection connect = new MySqlConnection(mySqlConnection))
                        {
                            connect.Open();
                            command = connect.CreateCommand();

                            if (rb_RGBavg.Checked == true) command.CommandText = "SELECT* FROM image_database_25_average";
                            else if (rb_luma.Checked == true) command.CommandText = "SELECT* FROM image_database_25_luma";
                            else if (rb_SingleChannel.Checked == true) command.CommandText = "SELECT* FROM image_database_25_single";
                            else command.CommandText = "SELECT* FROM image_database_25_desaturation";
                            
                            command.ExecuteNonQuery();
                            MySqlDataReader dr = command.ExecuteReader();
                            Stopwatch totalDbTimeSw = new Stopwatch();
                            totalDbTimeSw.Start();
                            while (dr.Read())
                            {
                                searchedImages++;
                                string imageDescriptorString = dr["DESCRIPTOR"].ToString();
                                string[] temp= imageDescriptorString.Split(' ');
                                int.TryParse(temp[0], out dimensions_image_db[0]);
                                int.TryParse(temp[1], out dimensions_image_db[1]);
                                for (int i = 0; i < 25; i++)
                                {
                                    int.TryParse(temp[i+2], out histogram_image_db_25[i]);
                                }
                                float temp_match=compareHistograms(histogram_image_input_25, histogram_image_db_25, histogram_compare_25);

                                if(temp_match>75 && temp_match>matchMax)  
                                {
                                    lbl_scale.Text = "Scale: " + scale.ToString();
                                    matchMax = temp_match;
                                    for (int i = 0; i < histogram_best_match_25.Length;i++ ) histogram_best_match_25[i] = histogram_image_db_25[i];
                                    dimensions_best_match[0] = dimensions_image_db[0];
                                    dimensions_best_match[1] = dimensions_image_db[1];
                                    pbx_image2.Image = Image.FromFile(@dr["PATH"].ToString());
                                    pbx_image2.SizeMode = PictureBoxSizeMode.Zoom;
                                    imageName = dr["TITLE"].ToString();
                                    imageAuthor = dr["AUTHOR"].ToString();
                                }
                            }
                            totalDbTimeSw.Stop();
                            lbl_totalDbTime.Text = "Total time (search + compare): " + totalDbTimeSw.ElapsedMilliseconds.ToString()+" ms";
                            lbl_numberOfImages.Text = "Number of searched images: " + searchedImages.ToString();
                            double average = (double)totalDbTimeSw.ElapsedMilliseconds / searchedImages;
                            lbl_averageTime.Text = "Average: " + Math.Round(average,8).ToString()+" ms/picture";
                            lbl_estimated.Text = "Estimated time for 10,000 pictures: " + (Math.Round(average*10,4)).ToString() + " s";
                            lbl_match.Text = "Match: " + matchMax + "%";
                            if (matchMax < 75)
                            {
                                //pbx_image2.Image.Dispose();
                                pbx_image2.Image = null;
                                MessageBox.Show("No matches found in the database.", "Message");
                                lbl_author.Text = "Author: ";
                                lbl_title.Text = "Title: ";
                                lbl_match.Text = "Match: ";
                            }

                            else
                            {
                                lbl_author.Text = "Author: "+imageAuthor;
                                lbl_title.Text = "Title: " + imageName;
                            }
                           
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error log: \n" + ex, "Error");
                    }
                }
            }).Start();
        }


        private void btn_showHistogram_Click(object sender, EventArgs e)
        {
            if (pbx_image1.Image != null)
            { 
                GraphHistogram histogram = new GraphHistogram(histogram_image_input_25,dimensions_image_input,"Histogram - Input Image");
                histogram.Show();
            }
        }

        private void btn_showHistogramSearch_Click(object sender, EventArgs e)
        {
            if (pbx_image2.Image != null)
            {
                GraphHistogram histogram = new GraphHistogram(histogram_best_match_25, dimensions_best_match, "Histogram - Best Match");
                histogram.Show();
            }
        }

    }
}