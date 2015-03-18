namespace ImageSearch_db
{
    partial class ImageSearchDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.pbx_image1 = new System.Windows.Forms.PictureBox();
            this.rtbx_histogram1 = new System.Windows.Forms.RichTextBox();
            this.pbx_image2 = new System.Windows.Forms.PictureBox();
            this.btn_compare = new System.Windows.Forms.Button();
            this.lbl_match = new System.Windows.Forms.Label();
            this.rb_method_standard = new System.Windows.Forms.RadioButton();
            this.rb_method_lockBits = new System.Windows.Forms.RadioButton();
            this.rb_method_parallel = new System.Windows.Forms.RadioButton();
            this.lbl_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showHistogramSearch = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_showHistogram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_desaturation = new System.Windows.Forms.RadioButton();
            this.rb_SingleChannel = new System.Windows.Forms.RadioButton();
            this.rb_luma = new System.Windows.Forms.RadioButton();
            this.rb_RGBavg = new System.Windows.Forms.RadioButton();
            this.imageProcessingMethod = new System.Windows.Forms.GroupBox();
            this.lbl_numberOfImages = new System.Windows.Forms.Label();
            this.lbl_totalDbTime = new System.Windows.Forms.Label();
            this.lbl_averageTime = new System.Windows.Forms.Label();
            this.lbl_scale = new System.Windows.Forms.Label();
            this.lbl_estimated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.imageProcessingMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.Location = new System.Drawing.Point(195, 152);
            this.btn_loadImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(86, 29);
            this.btn_loadImage.TabIndex = 0;
            this.btn_loadImage.Text = "Load Image";
            this.btn_loadImage.UseVisualStyleBackColor = true;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // pbx_image1
            // 
            this.pbx_image1.BackColor = System.Drawing.Color.DarkGray;
            this.pbx_image1.Location = new System.Drawing.Point(15, 26);
            this.pbx_image1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbx_image1.Name = "pbx_image1";
            this.pbx_image1.Size = new System.Drawing.Size(172, 155);
            this.pbx_image1.TabIndex = 1;
            this.pbx_image1.TabStop = false;
            // 
            // rtbx_histogram1
            // 
            this.rtbx_histogram1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbx_histogram1.Location = new System.Drawing.Point(196, 45);
            this.rtbx_histogram1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbx_histogram1.Name = "rtbx_histogram1";
            this.rtbx_histogram1.ReadOnly = true;
            this.rtbx_histogram1.Size = new System.Drawing.Size(209, 101);
            this.rtbx_histogram1.TabIndex = 3;
            this.rtbx_histogram1.Text = "";
            // 
            // pbx_image2
            // 
            this.pbx_image2.BackColor = System.Drawing.Color.DarkGray;
            this.pbx_image2.Location = new System.Drawing.Point(14, 26);
            this.pbx_image2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbx_image2.Name = "pbx_image2";
            this.pbx_image2.Size = new System.Drawing.Size(162, 155);
            this.pbx_image2.TabIndex = 4;
            this.pbx_image2.TabStop = false;
            // 
            // btn_compare
            // 
            this.btn_compare.Location = new System.Drawing.Point(183, 140);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(114, 41);
            this.btn_compare.TabIndex = 6;
            this.btn_compare.Text = "Search the database";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // lbl_match
            // 
            this.lbl_match.AutoSize = true;
            this.lbl_match.Location = new System.Drawing.Point(180, 26);
            this.lbl_match.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_match.Name = "lbl_match";
            this.lbl_match.Size = new System.Drawing.Size(52, 16);
            this.lbl_match.TabIndex = 7;
            this.lbl_match.Text = "Match: ";
            // 
            // rb_method_standard
            // 
            this.rb_method_standard.AutoSize = true;
            this.rb_method_standard.Checked = true;
            this.rb_method_standard.Location = new System.Drawing.Point(6, 28);
            this.rb_method_standard.Name = "rb_method_standard";
            this.rb_method_standard.Size = new System.Drawing.Size(145, 19);
            this.rb_method_standard.TabIndex = 8;
            this.rb_method_standard.TabStop = true;
            this.rb_method_standard.Text = "Standard (2 for-loops)";
            this.rb_method_standard.UseVisualStyleBackColor = true;
            // 
            // rb_method_lockBits
            // 
            this.rb_method_lockBits.AutoSize = true;
            this.rb_method_lockBits.Location = new System.Drawing.Point(6, 54);
            this.rb_method_lockBits.Name = "rb_method_lockBits";
            this.rb_method_lockBits.Size = new System.Drawing.Size(72, 19);
            this.rb_method_lockBits.TabIndex = 9;
            this.rb_method_lockBits.Text = "LockBits";
            this.rb_method_lockBits.UseVisualStyleBackColor = true;
            // 
            // rb_method_parallel
            // 
            this.rb_method_parallel.AutoSize = true;
            this.rb_method_parallel.Location = new System.Drawing.Point(6, 80);
            this.rb_method_parallel.Name = "rb_method_parallel";
            this.rb_method_parallel.Size = new System.Drawing.Size(159, 19);
            this.rb_method_parallel.TabIndex = 10;
            this.rb_method_parallel.Text = "LockBits and ParallelFor";
            this.rb_method_parallel.UseVisualStyleBackColor = true;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(12, 312);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(106, 16);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "Processing time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_showHistogramSearch);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.lbl_author);
            this.groupBox1.Controls.Add(this.pbx_image2);
            this.groupBox1.Controls.Add(this.btn_compare);
            this.groupBox1.Controls.Add(this.lbl_match);
            this.groupBox1.Location = new System.Drawing.Point(467, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 204);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best Match";
            // 
            // btn_showHistogramSearch
            // 
            this.btn_showHistogramSearch.Location = new System.Drawing.Point(302, 140);
            this.btn_showHistogramSearch.Name = "btn_showHistogramSearch";
            this.btn_showHistogramSearch.Size = new System.Drawing.Size(97, 41);
            this.btn_showHistogramSearch.TabIndex = 10;
            this.btn_showHistogramSearch.Text = "Show histogram";
            this.btn_showHistogramSearch.UseVisualStyleBackColor = true;
            this.btn_showHistogramSearch.Click += new System.EventHandler(this.btn_showHistogramSearch_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(180, 106);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(36, 16);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Title:";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(180, 65);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(50, 16);
            this.lbl_author.TabIndex = 8;
            this.lbl_author.Text = "Author:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_showHistogram);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.imageProcessingMethod);
            this.groupBox2.Controls.Add(this.lbl_time);
            this.groupBox2.Controls.Add(this.pbx_image1);
            this.groupBox2.Controls.Add(this.rtbx_histogram1);
            this.groupBox2.Controls.Add(this.btn_loadImage);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 344);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Image";
            // 
            // btn_showHistogram
            // 
            this.btn_showHistogram.Location = new System.Drawing.Point(286, 152);
            this.btn_showHistogram.Name = "btn_showHistogram";
            this.btn_showHistogram.Size = new System.Drawing.Size(119, 29);
            this.btn_showHistogram.TabIndex = 19;
            this.btn_showHistogram.Text = "Show histogram";
            this.btn_showHistogram.UseVisualStyleBackColor = true;
            this.btn_showHistogram.Click += new System.EventHandler(this.btn_showHistogram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dimensions and histogram values:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_desaturation);
            this.groupBox4.Controls.Add(this.rb_SingleChannel);
            this.groupBox4.Controls.Add(this.rb_luma);
            this.groupBox4.Controls.Add(this.rb_RGBavg);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(209, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 134);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RGB conversion algorithm";
            // 
            // rb_desaturation
            // 
            this.rb_desaturation.AutoSize = true;
            this.rb_desaturation.Location = new System.Drawing.Point(6, 106);
            this.rb_desaturation.Name = "rb_desaturation";
            this.rb_desaturation.Size = new System.Drawing.Size(96, 19);
            this.rb_desaturation.TabIndex = 3;
            this.rb_desaturation.Text = "Desaturation";
            this.rb_desaturation.UseVisualStyleBackColor = true;
            // 
            // rb_SingleChannel
            // 
            this.rb_SingleChannel.AutoSize = true;
            this.rb_SingleChannel.Location = new System.Drawing.Point(6, 80);
            this.rb_SingleChannel.Name = "rb_SingleChannel";
            this.rb_SingleChannel.Size = new System.Drawing.Size(163, 19);
            this.rb_SingleChannel.TabIndex = 2;
            this.rb_SingleChannel.Text = "Single Color Channel (G)";
            this.rb_SingleChannel.UseVisualStyleBackColor = true;
            // 
            // rb_luma
            // 
            this.rb_luma.AutoSize = true;
            this.rb_luma.Location = new System.Drawing.Point(6, 54);
            this.rb_luma.Name = "rb_luma";
            this.rb_luma.Size = new System.Drawing.Size(57, 19);
            this.rb_luma.TabIndex = 1;
            this.rb_luma.Text = "Luma";
            this.rb_luma.UseVisualStyleBackColor = true;
            // 
            // rb_RGBavg
            // 
            this.rb_RGBavg.AutoSize = true;
            this.rb_RGBavg.Checked = true;
            this.rb_RGBavg.Location = new System.Drawing.Point(6, 28);
            this.rb_RGBavg.Name = "rb_RGBavg";
            this.rb_RGBavg.Size = new System.Drawing.Size(98, 19);
            this.rb_RGBavg.TabIndex = 0;
            this.rb_RGBavg.TabStop = true;
            this.rb_RGBavg.Text = "RGB average";
            this.rb_RGBavg.UseVisualStyleBackColor = true;
            // 
            // imageProcessingMethod
            // 
            this.imageProcessingMethod.Controls.Add(this.rb_method_lockBits);
            this.imageProcessingMethod.Controls.Add(this.rb_method_parallel);
            this.imageProcessingMethod.Controls.Add(this.rb_method_standard);
            this.imageProcessingMethod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imageProcessingMethod.Location = new System.Drawing.Point(15, 194);
            this.imageProcessingMethod.Name = "imageProcessingMethod";
            this.imageProcessingMethod.Size = new System.Drawing.Size(184, 106);
            this.imageProcessingMethod.TabIndex = 11;
            this.imageProcessingMethod.TabStop = false;
            this.imageProcessingMethod.Text = "Processing algorithm";
            // 
            // lbl_numberOfImages
            // 
            this.lbl_numberOfImages.AutoSize = true;
            this.lbl_numberOfImages.Location = new System.Drawing.Point(482, 257);
            this.lbl_numberOfImages.Name = "lbl_numberOfImages";
            this.lbl_numberOfImages.Size = new System.Drawing.Size(174, 16);
            this.lbl_numberOfImages.TabIndex = 15;
            this.lbl_numberOfImages.Text = "Number of searched images:";
            // 
            // lbl_totalDbTime
            // 
            this.lbl_totalDbTime.AutoSize = true;
            this.lbl_totalDbTime.Location = new System.Drawing.Point(472, 284);
            this.lbl_totalDbTime.Name = "lbl_totalDbTime";
            this.lbl_totalDbTime.Size = new System.Drawing.Size(185, 16);
            this.lbl_totalDbTime.TabIndex = 17;
            this.lbl_totalDbTime.Text = "Total time (search + compare):";
            // 
            // lbl_averageTime
            // 
            this.lbl_averageTime.AutoSize = true;
            this.lbl_averageTime.Location = new System.Drawing.Point(600, 310);
            this.lbl_averageTime.Name = "lbl_averageTime";
            this.lbl_averageTime.Size = new System.Drawing.Size(58, 16);
            this.lbl_averageTime.TabIndex = 18;
            this.lbl_averageTime.Text = "Average:";
            // 
            // lbl_scale
            // 
            this.lbl_scale.AutoSize = true;
            this.lbl_scale.Location = new System.Drawing.Point(611, 233);
            this.lbl_scale.Name = "lbl_scale";
            this.lbl_scale.Size = new System.Drawing.Size(49, 16);
            this.lbl_scale.TabIndex = 20;
            this.lbl_scale.Text = "Scale: ";
            // 
            // lbl_estimated
            // 
            this.lbl_estimated.AutoSize = true;
            this.lbl_estimated.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_estimated.Location = new System.Drawing.Point(441, 337);
            this.lbl_estimated.Name = "lbl_estimated";
            this.lbl_estimated.Size = new System.Drawing.Size(215, 16);
            this.lbl_estimated.TabIndex = 19;
            this.lbl_estimated.Text = "Estimated time for 10,000 pictures: ";
            // 
            // ImageSearchDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.lbl_scale);
            this.Controls.Add(this.lbl_estimated);
            this.Controls.Add(this.lbl_averageTime);
            this.Controls.Add(this.lbl_totalDbTime);
            this.Controls.Add(this.lbl_numberOfImages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ImageSearchDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image search - 25+2 numbers (Adrian Bece)";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.imageProcessingMethod.ResumeLayout(false);
            this.imageProcessingMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.PictureBox pbx_image1;
        private System.Windows.Forms.RichTextBox rtbx_histogram1;
        private System.Windows.Forms.PictureBox pbx_image2;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Label lbl_match;
        private System.Windows.Forms.RadioButton rb_method_standard;
        private System.Windows.Forms.RadioButton rb_method_lockBits;
        private System.Windows.Forms.RadioButton rb_method_parallel;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_numberOfImages;
        private System.Windows.Forms.Label lbl_totalDbTime;
        private System.Windows.Forms.GroupBox imageProcessingMethod;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_RGBavg;
        private System.Windows.Forms.RadioButton rb_desaturation;
        private System.Windows.Forms.RadioButton rb_SingleChannel;
        private System.Windows.Forms.RadioButton rb_luma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_averageTime;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_showHistogram;
        private System.Windows.Forms.Button btn_showHistogramSearch;
        private System.Windows.Forms.Label lbl_scale;
        private System.Windows.Forms.Label lbl_estimated;
    }
}

