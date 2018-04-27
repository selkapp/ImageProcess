
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;

namespace imageproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image _Img;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

      
          private Bitmap grıYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);



                }
            }

            return bmp;


        }
      private Bitmap kırmızı(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).R, 0, 0));
                }
            }
            return bmp;




        }
       
        private Bitmap maviyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(0, 0, bmp.GetPixel(i, j).B));
                }
            }


            return bmp;

        }
       
        private Bitmap yesilyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color renk = Color.FromArgb(0, bmp.GetPixel(i, j).G, 0);
                    bmp.SetPixel(i, j, renk);
                }
            }
            return bmp;




        }
       
        private Bitmap dondursaga(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - j - 1, i, bmp.GetPixel(i, j));
                }
            }
            return b;


        }
        private Bitmap dondursola(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }
        private Bitmap ekle(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }
        private void dereceSağaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resim.Visible = false;
            pictureBox2.Visible = true;

            Bitmap image = new Bitmap(resim.Image);

            Bitmap saga = dondursaga(image);
            pictureBox2.Image = saga;
        }

        private void dereceSolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            resim.Visible = false;
            pictureBox2.Visible = true;


            Bitmap image = new Bitmap(resim.Image);
            Bitmap sola = dondursola(image);
            pictureBox2.Image = sola;
        }
      private Bitmap duseyayna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(i, b.Height - j - 1, bmp.GetPixel(i, j));
                }
            }
            return b;


        }
        public Bitmap yatayayna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - i - 1, j, bmp.GetPixel(i, j));
                }
            }
            return b;


        } /*
        private void düşeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap dayna = duseyayna(image);
            pictureBox2.Image = dayna;
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap yayna = yatayayna(image);
            pictureBox2.Image = yayna;
        } */
        private Bitmap Negatif(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(255 - bmp.GetPixel(i, j).R, 255 - bmp.GetPixel(i, j).G, 255 - bmp.GetPixel(i, j).B));
                }
            }
            return bmp;
        }
       

       

        public Bitmap boyutlandırma(ref Bitmap myImage, int Yenien, int Yeniboy)
        {
            int en = Yenien;
            int boy = Yeniboy;
            Bitmap pictureBox2 = new Bitmap(en, boy);
            Bitmap bmp = new Bitmap(en, boy);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(myImage, 0, 0, en, boy);
            graphic.DrawImage(pictureBox2, 0, 0, en, boy);
            graphic.Dispose();

            return bmp;


            //int genislik = Yenien;
            //int yukseklik = Yeniboy;
            //float Oran = 0;
            //float genislikOranı = 0;
            //float yukseklikOranı = 0;
            //genislikOranı = ((float)Yenien / (float)genislik);
            //yukseklikOranı = ((float)Yeniboy / (float)yukseklik);
            //if (yukseklikOranı < genislikOranı)
            //    Oran = yukseklikOranı;
            //else
            //    Oran = genislikOranı;
            //int yenigenislik = (int)(genislik * Oran);
            //int yeniyukseklik = (int)(yukseklik * Oran);
            //Bitmap sonimg = new Bitmap(yenigenislik, yeniyukseklik);
            //Graphics g = Graphics.FromImage((System.Drawing.Image)sonimg);

            //g.DrawImage(myImage, 0, 0, yenigenislik, yeniyukseklik);


            //return sonimg;

        }








       

        private void öLÇEKLENDİRMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

         /*   int en = Convert.ToInt32(toolStripTextBox1.Text);
            int boy = Convert.ToInt32(toolStripTextBox2.Text);
            Bitmap image = new Bitmap(pictureBox2.Image);

            Bitmap boyut = boyutlandırma(ref image, en, boy);
            pictureBox2.Image = boyut;

            */

        }

        private void tONLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void gERİALToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resim.Visible = true;
            pictureBox2.Visible = false;

            Bitmap image = new Bitmap(pictureBox2.Image);



        }

        private void kAYDETToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf |All files (*.*)|*.*";

            sfd.Title = "Kayıt";
            sfd.FileName = "resim";
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox2.Image.Save(sfd.FileName);
            }


        }

        private void gÖRÜNTÜEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";

            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            resim.ImageLocation = DosyaYolu;

        }

        private void gRİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resim.Visible = false;
            pictureBox2.Visible = true;


            Bitmap image = new Bitmap(resim.Image);

            Bitmap gri = grıYap(image);
            pictureBox2.Image = gri;

        }

        private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resim.Visible = false;
            pictureBox2.Visible = true;

            Bitmap image = new Bitmap(resim.Image);

            Bitmap mavi = maviyap(image);
            pictureBox2.Image = mavi;
        }

        private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resim.Visible = false;
            pictureBox2.Visible = true;

            Bitmap image = new Bitmap(resim.Image);

            Bitmap kırmızıyap = kırmızı(image);
            pictureBox2.Image = kırmızıyap;
        }

        private void yEŞİLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resim.Visible = false;
            pictureBox2.Visible = true;


            Bitmap image = new Bitmap(resim.Image);

            Bitmap yesil = yesilyap(image);
            pictureBox2.Image = yesil;

        }

        private void negatifToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            resim.Visible = false;
            pictureBox2.Visible = true;


            Bitmap image = new Bitmap(resim.Image);
            Bitmap yayna = Negatif(image);
            pictureBox2.Image = yayna;

        }

        private void dONDURMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resim.Visible = false;
            pictureBox2.Visible = true;


            int en = Convert.ToInt32(toolStripTextBox1.Text);
            int boy = Convert.ToInt32(toolStripTextBox2.Text);
            Bitmap image = new Bitmap(resim.Image);
            Bitmap boyut1 = boyutlandırma(ref image, en, boy);
            Bitmap boyut = boyutlandırma(ref image, en, boy);
            this.pictureBox2.Size = new System.Drawing.Size(en, boy);

            
            pictureBox2.Image = boyut;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dereceSağToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap saga = dondursaga(image);
            pictureBox2.Image = saga;


        }

        private void dereceSolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap sola = dondursola(image);
            pictureBox2.Image = sola;

        }

        private void solaAynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap yayna = yatayayna(image);
            pictureBox2.Image = yayna;

        }

        private void sağaAynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(resim.Image);
            Bitmap dayna = duseyayna(image);
            pictureBox2.Image = dayna;

        }



        public static Bitmap gonderilecekveri;

        private void hİSTOGRAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gonderilecekveri = new Bitmap(resim.Image);

            Form3 histogramformu = new Form3();

            histogramformu.Show();
        }
    }

}

/*
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;

namespace yazlab_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image _Img;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf |All files (*.*)|*.*";

            sfd.Title = "Kayıt";
            sfd.FileName = "resim";
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox2.Image.Save(sfd.FileName);
            }

            //SaveFileDialog dialog = new SaveFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    int width = Convert.ToInt32(drawImage.Width);
            //    int height = Convert.ToInt32(drawImage.Height);
            //    Bitmap bmp = new Bitmap(width, height);
            //    drawImage.DrawToBitmap(bmp, new Rectangle(0, 0, width, height);
            //    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            //}
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        public static Bitmap gonderilecekveri;
        public void button3_Click(object sender, EventArgs e)
        {
            gonderilecekveri = new Bitmap(resim.Image);

            Form4 histogramformu = new Form4();

            histogramformu.Show();
        }


        private System.Drawing.Bitmap Equalize(System.Drawing.Bitmap bmp) // SAFE BUT SLOW
        {
            long[] GrHst = new long[256]; long HstValue = 0;
            long[] GrSum = new long[256]; long SumValue = 0;
            for (int row = 0; row < bmp.Height; row++)
                for (int col = 0; col < bmp.Width; col++)
                {
                    HstValue = (long)(255 * bmp.GetPixel(col, row).GetBrightness());
                    GrHst[HstValue]++;
                }
            for (int level = 0; level < 255; level++)
            {
                SumValue += GrHst[level];
                GrSum[level] = SumValue;
            }
            for (int row = 0; row < bmp.Height; row++)
                for (int col = 0; col < bmp.Width; col++)
                {
                    System.Drawing.Color clr = bmp.GetPixel(col, row);
                    HstValue = (long)(255 * clr.GetBrightness());
                    HstValue = (long)(255f / (bmp.Width * bmp.Height) * GrSum[HstValue] - HstValue);
                    int R = (int)Math.Min(255, clr.R + HstValue / 3); //.299
                    int G = (int)Math.Min(255, clr.G + HstValue / 3); //.587
                    int B = (int)Math.Min(255, clr.B + HstValue / 3); //.112
                    bmp.SetPixel(col, row, System.Drawing.Color.FromArgb(Math.Max(R, 0), Math.Max(G, 0), Math.Max(B, 0)));
                }
            return bmp;
        }




        public void histogramciz(ref int[] hist)
        {





        }












        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap gri = grıYap(image);
            pictureBox2.Image = gri;
        }
        private Bitmap grıYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);



                }
            }

            return bmp;


        }


        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";

            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            resim.ImageLocation = DosyaYolu;
        }
        private Bitmap kırmızı(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).R, 0, 0));
                }
            }
            return bmp;




        }
        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap kırmızıyap = kırmızı(image);
            pictureBox2.Image = kırmızıyap;
        }
        private Bitmap maviyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(0, 0, bmp.GetPixel(i, j).B));
                }
            }


            return bmp;

        }
        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap mavi = maviyap(image);
            pictureBox2.Image = mavi;
        }
        private Bitmap yesilyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color renk = Color.FromArgb(0, bmp.GetPixel(i, j).G, 0);
                    bmp.SetPixel(i, j, renk);
                }
            }
            return bmp;




        }
        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap yesil = yesilyap(image);
            pictureBox2.Image = yesil;
        }
        private Bitmap dondursaga(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - j - 1, i, bmp.GetPixel(i, j));
                }
            }
            return b;


        }
        private Bitmap dondursola(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }
        private Bitmap ekle(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }
        private void dereceSağaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);

            Bitmap saga = dondursaga(image);
            pictureBox2.Image = saga;
        }

        private void dereceSolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap sola = dondursola(image);
            pictureBox2.Image = sola;
        }
        private Bitmap duseyayna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(i, b.Height - j - 1, bmp.GetPixel(i, j));
                }
            }
            return b;


        }
        public Bitmap yatayayna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - i - 1, j, bmp.GetPixel(i, j));
                }
            }
            return b;


        }
        private void düşeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap dayna = duseyayna(image);
            pictureBox2.Image = dayna;
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap yayna = yatayayna(image);
            pictureBox2.Image = yayna;
        }
        private Bitmap Negatif(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(255 - bmp.GetPixel(i, j).R, 255 - bmp.GetPixel(i, j).G, 255 - bmp.GetPixel(i, j).B));
                }
            }
            return bmp;
        }
        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(resim.Image);
            Bitmap yayna = Negatif(image);
            pictureBox2.Image = yayna;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox2.Image);

        }

        public Bitmap boyutlandırma(ref Bitmap myImage, int Yenien, int Yeniboy)
        {
            int en = Yenien;
            int boy = Yeniboy;
            Bitmap pictureBox2 = new Bitmap(en, boy);
            Bitmap bmp = new Bitmap(en, boy);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(myImage, 0, 0, en, boy);
            graphic.DrawImage(pictureBox2, 0, 0, en, boy);
            graphic.Dispose();
            return bmp;


            //int genislik = Yenien;
            //int yukseklik = Yeniboy;
            //float Oran = 0;
            //float genislikOranı = 0;
            //float yukseklikOranı = 0;
            //genislikOranı = ((float)Yenien / (float)genislik);
            //yukseklikOranı = ((float)Yeniboy / (float)yukseklik);
            //if (yukseklikOranı < genislikOranı)
            //    Oran = yukseklikOranı;
            //else
            //    Oran = genislikOranı;
            //int yenigenislik = (int)(genislik * Oran);
            //int yeniyukseklik = (int)(yukseklik * Oran);
            //Bitmap sonimg = new Bitmap(yenigenislik, yeniyukseklik);
            //Graphics g = Graphics.FromImage((System.Drawing.Image)sonimg);

            //g.DrawImage(myImage, 0, 0, yenigenislik, yeniyukseklik);


            //return sonimg;

        }
        public Bitmap boyutlandırma1(ref Bitmap pictureBox2, int Yenien, int Yeniboy)
        {
            int en = Yenien;
            int boy = Yeniboy;


            Graphics graphic = Graphics.FromImage((Image)pictureBox2);

            graphic.DrawImage(pictureBox2, 0, 0, en, boy);

            graphic.Dispose();
            return pictureBox2;


            //int genislik = Yenien;
            //int yukseklik = Yeniboy;
            //float Oran = 0;
            //float genislikOranı = 0;
            //float yukseklikOranı = 0;
            //genislikOranı = ((float)Yenien / (float)genislik);
            //yukseklikOranı = ((float)Yeniboy / (float)yukseklik);
            //if (yukseklikOranı < genislikOranı)
            //    Oran = yukseklikOranı;
            //else
            //    Oran = genislikOranı;
            //int yenigenislik = (int)(genislik * Oran);
            //int yeniyukseklik = (int)(yukseklik * Oran);
            //Bitmap sonimg = new Bitmap(yenigenislik, yeniyukseklik);
            //Graphics g = Graphics.FromImage((System.Drawing.Image)sonimg);

            //g.DrawImage(myImage, 0, 0, yenigenislik, yeniyukseklik);


            //return sonimg;

        }






        private void button5_Click(object sender, EventArgs e)
        {

            int en = Convert.ToInt32(textBox1.Text);
            int boy = Convert.ToInt32(textBox2.Text);
            Bitmap image = new Bitmap(resim.Image);
            Bitmap boyut1 = boyutlandırma(ref image, en, boy);
            Bitmap boyut = boyutlandırma(ref image, en, boy);
            this.pictureBox2.Size = new System.Drawing.Size(en, boy);






            pictureBox2.Image = boyut;
        }

        private void tONLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}

    */
