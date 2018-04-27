namespace imageproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resim = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tONLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIRMIZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yEŞİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONDURMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYNALAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaAynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaAynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öLÇEKLENDİRMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.hesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÖRÜNTÜEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hİSTOGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYDETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dereceSağToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dereceSolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resim
            // 
            this.resim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resim.Location = new System.Drawing.Point(402, 107);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(590, 424);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 0;
            this.resim.TabStop = false;
            this.resim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(402, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 424);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tONLAMAToolStripMenuItem,
            this.dONDURMAToolStripMenuItem,
            this.aYNALAMAToolStripMenuItem,
            this.öLÇEKLENDİRMEToolStripMenuItem,
            this.gÖRÜNTÜEKLEToolStripMenuItem,
            this.hİSTOGRAMToolStripMenuItem,
            this.gERİALToolStripMenuItem,
            this.kAYDETToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tONLAMAToolStripMenuItem
            // 
            this.tONLAMAToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.tONLAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRİToolStripMenuItem,
            this.mAVİToolStripMenuItem,
            this.kIRMIZIToolStripMenuItem,
            this.yEŞİLToolStripMenuItem,
            this.negatifToolStripMenuItem});
            this.tONLAMAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tONLAMAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tONLAMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tONLAMAToolStripMenuItem.Image")));
            this.tONLAMAToolStripMenuItem.Name = "tONLAMAToolStripMenuItem";
            this.tONLAMAToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.tONLAMAToolStripMenuItem.Text = "TONLAMA";
            this.tONLAMAToolStripMenuItem.Click += new System.EventHandler(this.tONLAMAToolStripMenuItem_Click);
            // 
            // gRİToolStripMenuItem
            // 
            this.gRİToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gRİToolStripMenuItem.Name = "gRİToolStripMenuItem";
            this.gRİToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.gRİToolStripMenuItem.Text = "Gri";
            this.gRİToolStripMenuItem.Click += new System.EventHandler(this.gRİToolStripMenuItem_Click);
            // 
            // mAVİToolStripMenuItem
            // 
            this.mAVİToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mAVİToolStripMenuItem.Name = "mAVİToolStripMenuItem";
            this.mAVİToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.mAVİToolStripMenuItem.Text = "Mavi";
            this.mAVİToolStripMenuItem.Click += new System.EventHandler(this.mAVİToolStripMenuItem_Click);
            // 
            // kIRMIZIToolStripMenuItem
            // 
            this.kIRMIZIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kIRMIZIToolStripMenuItem.Name = "kIRMIZIToolStripMenuItem";
            this.kIRMIZIToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.kIRMIZIToolStripMenuItem.Text = "Kırmızı";
            this.kIRMIZIToolStripMenuItem.Click += new System.EventHandler(this.kIRMIZIToolStripMenuItem_Click);
            // 
            // yEŞİLToolStripMenuItem
            // 
            this.yEŞİLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yEŞİLToolStripMenuItem.Name = "yEŞİLToolStripMenuItem";
            this.yEŞİLToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.yEŞİLToolStripMenuItem.Text = "Yeşil";
            this.yEŞİLToolStripMenuItem.Click += new System.EventHandler(this.yEŞİLToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click_1);
            // 
            // dONDURMAToolStripMenuItem
            // 
            this.dONDURMAToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dONDURMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dereceSağToolStripMenuItem,
            this.dereceSolToolStripMenuItem});
            this.dONDURMAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dONDURMAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dONDURMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dONDURMAToolStripMenuItem.Image")));
            this.dONDURMAToolStripMenuItem.Name = "dONDURMAToolStripMenuItem";
            this.dONDURMAToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.dONDURMAToolStripMenuItem.Text = "DONDURME";
            this.dONDURMAToolStripMenuItem.Click += new System.EventHandler(this.dONDURMAToolStripMenuItem_Click);
            // 
            // aYNALAMAToolStripMenuItem
            // 
            this.aYNALAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağaAynalamaToolStripMenuItem,
            this.solaAynalamaToolStripMenuItem});
            this.aYNALAMAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aYNALAMAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aYNALAMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aYNALAMAToolStripMenuItem.Image")));
            this.aYNALAMAToolStripMenuItem.Name = "aYNALAMAToolStripMenuItem";
            this.aYNALAMAToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.aYNALAMAToolStripMenuItem.Text = "AYNALAMA";
            // 
            // sağaAynalamaToolStripMenuItem
            // 
            this.sağaAynalamaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sağaAynalamaToolStripMenuItem.Name = "sağaAynalamaToolStripMenuItem";
            this.sağaAynalamaToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.sağaAynalamaToolStripMenuItem.Text = "Düşey";
            this.sağaAynalamaToolStripMenuItem.Click += new System.EventHandler(this.sağaAynalamaToolStripMenuItem_Click);
            // 
            // solaAynalamaToolStripMenuItem
            // 
            this.solaAynalamaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.solaAynalamaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.solaAynalamaToolStripMenuItem.Name = "solaAynalamaToolStripMenuItem";
            this.solaAynalamaToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.solaAynalamaToolStripMenuItem.Text = "Yatay";
            this.solaAynalamaToolStripMenuItem.Click += new System.EventHandler(this.solaAynalamaToolStripMenuItem_Click);
            // 
            // öLÇEKLENDİRMEToolStripMenuItem
            // 
            this.öLÇEKLENDİRMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.hesaplaToolStripMenuItem});
            this.öLÇEKLENDİRMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öLÇEKLENDİRMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.öLÇEKLENDİRMEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öLÇEKLENDİRMEToolStripMenuItem.Image")));
            this.öLÇEKLENDİRMEToolStripMenuItem.Name = "öLÇEKLENDİRMEToolStripMenuItem";
            this.öLÇEKLENDİRMEToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.öLÇEKLENDİRMEToolStripMenuItem.Text = "ÖLÇEKLENDİRME";
            this.öLÇEKLENDİRMEToolStripMenuItem.Click += new System.EventHandler(this.öLÇEKLENDİRMEToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // hesaplaToolStripMenuItem
            // 
            this.hesaplaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hesaplaToolStripMenuItem.Name = "hesaplaToolStripMenuItem";
            this.hesaplaToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.hesaplaToolStripMenuItem.Text = "Ölçeklendir";
            this.hesaplaToolStripMenuItem.Click += new System.EventHandler(this.hesaplaToolStripMenuItem_Click);
            // 
            // gÖRÜNTÜEKLEToolStripMenuItem
            // 
            this.gÖRÜNTÜEKLEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gÖRÜNTÜEKLEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gÖRÜNTÜEKLEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gÖRÜNTÜEKLEToolStripMenuItem.Image")));
            this.gÖRÜNTÜEKLEToolStripMenuItem.Name = "gÖRÜNTÜEKLEToolStripMenuItem";
            this.gÖRÜNTÜEKLEToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.gÖRÜNTÜEKLEToolStripMenuItem.Text = "GÖRÜNTÜ EKLE";
            this.gÖRÜNTÜEKLEToolStripMenuItem.Click += new System.EventHandler(this.gÖRÜNTÜEKLEToolStripMenuItem_Click);
            // 
            // hİSTOGRAMToolStripMenuItem
            // 
            this.hİSTOGRAMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hİSTOGRAMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hİSTOGRAMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hİSTOGRAMToolStripMenuItem.Image")));
            this.hİSTOGRAMToolStripMenuItem.Name = "hİSTOGRAMToolStripMenuItem";
            this.hİSTOGRAMToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.hİSTOGRAMToolStripMenuItem.Text = "HİSTOGRAM";
            this.hİSTOGRAMToolStripMenuItem.Click += new System.EventHandler(this.hİSTOGRAMToolStripMenuItem_Click);
            // 
            // gERİALToolStripMenuItem
            // 
            this.gERİALToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gERİALToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gERİALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gERİALToolStripMenuItem.Image")));
            this.gERİALToolStripMenuItem.Name = "gERİALToolStripMenuItem";
            this.gERİALToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.gERİALToolStripMenuItem.Text = "REOPEN";
            this.gERİALToolStripMenuItem.Click += new System.EventHandler(this.gERİALToolStripMenuItem_Click);
            // 
            // kAYDETToolStripMenuItem
            // 
            this.kAYDETToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAYDETToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kAYDETToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kAYDETToolStripMenuItem.Image")));
            this.kAYDETToolStripMenuItem.Name = "kAYDETToolStripMenuItem";
            this.kAYDETToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.kAYDETToolStripMenuItem.Text = "KAYDET";
            this.kAYDETToolStripMenuItem.Click += new System.EventHandler(this.kAYDETToolStripMenuItem_Click_1);
            // 
            // dereceSağToolStripMenuItem
            // 
            this.dereceSağToolStripMenuItem.Name = "dereceSağToolStripMenuItem";
            this.dereceSağToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.dereceSağToolStripMenuItem.Text = "90 Derece  Sağ";
            this.dereceSağToolStripMenuItem.Click += new System.EventHandler(this.dereceSağToolStripMenuItem_Click);
            // 
            // dereceSolToolStripMenuItem
            // 
            this.dereceSolToolStripMenuItem.Name = "dereceSolToolStripMenuItem";
            this.dereceSolToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.dereceSolToolStripMenuItem.Text = "90 Derece Sol";
            this.dereceSolToolStripMenuItem.Click += new System.EventHandler(this.dereceSolToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1378, 543);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SS IMAGE PROCESSING";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tONLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAVİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIRMIZIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yEŞİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONDURMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYNALAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öLÇEKLENDİRMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem hesaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÖRÜNTÜEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hİSTOGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERİALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAYDETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaAynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaAynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dereceSağToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dereceSolToolStripMenuItem;
    }
}

