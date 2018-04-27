using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 giris = new Form2();
            giris.Close();

            Form1 anaform = new Form1();
            anaform.Show();
            this.Hide();
          
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Form2 giris = new Form2();
            giris.Close();


            Form1 anaform = new Form1();
            anaform.Show();
            this.Hide();




        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
    }
}
