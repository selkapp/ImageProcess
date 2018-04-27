using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace imageproject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Bitmap resim = Form1.gonderilecekveri;
        public void Form3_Load(object sender, EventArgs e)
        {

            Bitmap resim = Form1.gonderilecekveri;
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            Bitmap resim;
            resim = Form1.gonderilecekveri;
            int[] h = new int[256];
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renk = resim.GetPixel(i, j);
                    int ort = (renk.R + renk.G + renk.B) / 3;
                    h[ort] = h[ort] + 1;
                }
            }
            Series series = this.chart1.Series.Add("Gri");
            for (int i = 0; i < 255; i++)
            {
                series.Points.AddXY(i, h[i]);

            }


        }

        private void chart3_Click(object sender, EventArgs e)
        {
            int[] hist3 = new int[256];
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renk = resim.GetPixel(i, j);
                    int deger = renk.R;
                    hist3[deger] = hist3[deger] + 1;
                }
            }

            Series series2 = this.chart3.Series.Add("Kırmızı");
            for (int i = 0; i < 255; i++)
            {
                series2.Points.AddXY(i, hist3[i]);

            }
        }

        private void chart4_Click(object sender, EventArgs e)
        {
            int[] hist4 = new int[256];
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renk = resim.GetPixel(i, j);
                    int deger = renk.B;
                    hist4[deger] = hist4[deger] + 1;
                }
            }

            Series series = this.chart4.Series.Add("Mavi");
            for (int i = 0; i < 255; i++)
            {
                series.Points.AddXY(i, hist4[i]);

            }
        }

        //private void chart5_Click(object sender, EventArgs e)
        //{

        //}

        private void chart2_Click(object sender, EventArgs e)
        {
            int[] hist2 = new int[256];
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renk = resim.GetPixel(i, j);
                    int deger = renk.G;
                    hist2[deger] = hist2[deger] + 1;
                }
            }

            Series series1 = this.chart2.Series.Add("Yesil");
            for (int i = 0; i < 255; i++)
            {
                series1.Points.AddXY(i, hist2[i]);

            }
        }
    }
}
