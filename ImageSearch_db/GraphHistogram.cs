using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageSearch_db
{
    public partial class GraphHistogram : Form
    {
        public GraphHistogram(int[] histogram, int[] dimensions,string title)
        {
            char point = '█';
            InitializeComponent();
            this.Text = title;
            for (int i=0; i<histogram.Length;i++)
            {
                double percent = 0;
                percent = (double)histogram[i]*100 / (dimensions[0] * dimensions[1]);
                percent = Math.Round(percent,2);
               // if (percent == 0 && histogram[i]!=0) percent = 1; // da nacrta barem 1 tocku
                for (int j=0;j<percent;j++)
                {
                    if (i == 0) lbl_h01.Text += point;
                    else if (i == 1) lbl_h02.Text += point;
                    else if (i == 2) lbl_h03.Text += point;
                    else if (i == 3) lbl_h04.Text += point;
                    else if (i == 4) lbl_h05.Text += point;
                    else if (i == 5) lbl_h06.Text += point;
                    else if (i == 6) lbl_h07.Text += point;
                    else if (i == 7) lbl_h08.Text += point;
                    else if (i == 8) lbl_h09.Text += point;
                    else if (i == 9) lbl_h10.Text += point;
                    else if (i == 10) lbl_h11.Text += point;
                    else if (i == 11) lbl_h12.Text += point;
                    else if (i == 12) lbl_h13.Text += point;
                    else if (i == 13) lbl_h14.Text += point;
                    else if (i == 14) lbl_h15.Text += point;
                    else if (i == 15) lbl_h16.Text += point;
                    else if (i == 16) lbl_h17.Text += point;
                    else if (i == 17) lbl_h18.Text += point;
                    else if (i == 18) lbl_h19.Text += point;
                    else if (i == 19) lbl_h20.Text += point;
                    else if (i == 20) lbl_h21.Text += point;
                    else if (i == 21) lbl_h22.Text += point;
                    else if (i == 22) lbl_h23.Text += point;
                    else if (i == 23) lbl_h24.Text += point;
                    else lbl_h25.Text += point;
                }

                if (i == 0) lbl_h01.Text += " "+percent+"%";
                else if (i == 1) lbl_h02.Text += " " + percent + "%";
                else if (i == 2) lbl_h03.Text += " " + percent + "%";
                else if (i == 3) lbl_h04.Text += " " + percent + "%";
                else if (i == 4) lbl_h05.Text += " " + percent + "%";
                else if (i == 5) lbl_h06.Text += " " + percent + "%";
                else if (i == 6) lbl_h07.Text += " " + percent + "%";
                else if (i == 7) lbl_h08.Text += " " + percent + "%";
                else if (i == 8) lbl_h09.Text += " " + percent + "%";
                else if (i == 9) lbl_h10.Text += " " + percent + "%";
                else if (i == 10) lbl_h11.Text += " " + percent + "%";
                else if (i == 11) lbl_h12.Text += " " + percent + "%";
                else if (i == 12) lbl_h13.Text += " " + percent + "%";
                else if (i == 13) lbl_h14.Text += " " + percent + "%";
                else if (i == 14) lbl_h15.Text += " " + percent + "%";
                else if (i == 15) lbl_h16.Text += " " + percent + "%";
                else if (i == 16) lbl_h17.Text += " " + percent + "%";
                else if (i == 17) lbl_h18.Text += " " + percent + "%";
                else if (i == 18) lbl_h19.Text += " " + percent + "%";
                else if (i == 19) lbl_h20.Text += " " + percent + "%";
                else if (i == 20) lbl_h21.Text += " " + percent + "%";
                else if (i == 21) lbl_h22.Text += " " + percent + "%";
                else if (i == 22) lbl_h23.Text += " " + percent + "%";
                else if (i == 23) lbl_h24.Text += " " + percent + "%";
                else lbl_h25.Text += " " + percent + "%";
            }
        }

        
    }
}
