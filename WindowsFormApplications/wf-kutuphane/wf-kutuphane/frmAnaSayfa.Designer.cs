namespace wf_kutuphane
{
    partial class frmAnaSayfa
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
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.kİTAPLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKitapTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKitapTuruTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKitapSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYazarTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYazarSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.yAYINEVLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYayineviTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYayineviSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.BackColor = System.Drawing.Color.BurlyWood;
            this.mnuAnaSayfa.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPLARToolStripMenuItem,
            this.yAZARLARToolStripMenuItem,
            this.yAYINEVLERİToolStripMenuItem,
            this.rAPORLAMAToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(96, 509);
            this.mnuAnaSayfa.TabIndex = 0;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // kİTAPLARToolStripMenuItem
            // 
            this.kİTAPLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmKitapTanimlama,
            this.mitmKitapTuruTanimlama,
            this.mitmKitapSorgulama});
            this.kİTAPLARToolStripMenuItem.Name = "kİTAPLARToolStripMenuItem";
            this.kİTAPLARToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.kİTAPLARToolStripMenuItem.Text = "KİTAPLAR";
            // 
            // mitmKitapTanimlama
            // 
            this.mitmKitapTanimlama.Name = "mitmKitapTanimlama";
            this.mitmKitapTanimlama.Size = new System.Drawing.Size(191, 22);
            this.mitmKitapTanimlama.Text = "Kitap Tanımlama";
            this.mitmKitapTanimlama.Click += new System.EventHandler(this.mitmKitapTanimlama_Click);
            // 
            // mitmKitapTuruTanimlama
            // 
            this.mitmKitapTuruTanimlama.Name = "mitmKitapTuruTanimlama";
            this.mitmKitapTuruTanimlama.Size = new System.Drawing.Size(191, 22);
            this.mitmKitapTuruTanimlama.Text = "Kitap Türü Tanımlama";
            // 
            // mitmKitapSorgulama
            // 
            this.mitmKitapSorgulama.Name = "mitmKitapSorgulama";
            this.mitmKitapSorgulama.Size = new System.Drawing.Size(191, 22);
            this.mitmKitapSorgulama.Text = "Kitap Sorgulama";
            // 
            // yAZARLARToolStripMenuItem
            // 
            this.yAZARLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmYazarTanimlama,
            this.mitmYazarSorgulama});
            this.yAZARLARToolStripMenuItem.Name = "yAZARLARToolStripMenuItem";
            this.yAZARLARToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.yAZARLARToolStripMenuItem.Text = "YAZARLAR";
            // 
            // mitmYazarTanimlama
            // 
            this.mitmYazarTanimlama.Name = "mitmYazarTanimlama";
            this.mitmYazarTanimlama.Size = new System.Drawing.Size(163, 22);
            this.mitmYazarTanimlama.Text = "Yazar Tanımlama";
            // 
            // mitmYazarSorgulama
            // 
            this.mitmYazarSorgulama.Name = "mitmYazarSorgulama";
            this.mitmYazarSorgulama.Size = new System.Drawing.Size(163, 22);
            this.mitmYazarSorgulama.Text = "Yazar Sorgulama";
            // 
            // yAYINEVLERİToolStripMenuItem
            // 
            this.yAYINEVLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmYayineviTanimlama,
            this.mitmYayineviSorgulama});
            this.yAYINEVLERİToolStripMenuItem.Name = "yAYINEVLERİToolStripMenuItem";
            this.yAYINEVLERİToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.yAYINEVLERİToolStripMenuItem.Text = "YAYINEVLERİ";
            // 
            // mitmYayineviTanimlama
            // 
            this.mitmYayineviTanimlama.Name = "mitmYayineviTanimlama";
            this.mitmYayineviTanimlama.Size = new System.Drawing.Size(179, 22);
            this.mitmYayineviTanimlama.Text = "YayınEvi Tanımlama";
            // 
            // mitmYayineviSorgulama
            // 
            this.mitmYayineviSorgulama.Name = "mitmYayineviSorgulama";
            this.mitmYayineviSorgulama.Size = new System.Drawing.Size(179, 22);
            this.mitmYayineviSorgulama.Text = "YayınEvi Sorgulama";
            // 
            // rAPORLAMAToolStripMenuItem
            // 
            this.rAPORLAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmRaporlama});
            this.rAPORLAMAToolStripMenuItem.Name = "rAPORLAMAToolStripMenuItem";
            this.rAPORLAMAToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.rAPORLAMAToolStripMenuItem.Text = "RAPORLAMA";
            // 
            // mitmRaporlama
            // 
            this.mitmRaporlama.Name = "mitmRaporlama";
            this.mitmRaporlama.Size = new System.Drawing.Size(200, 22);
            this.mitmRaporlama.Text = "Detaylı Kitap Sorgulama";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(83, 19);
            this.mitmCikis.Text = "ÇIKIŞ";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaSayfa";
            this.Text = "HSSNet 13 Kütüphane İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem kİTAPLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmKitapTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmKitapTuruTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmKitapSorgulama;
        private System.Windows.Forms.ToolStripMenuItem yAZARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAYINEVLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
        private System.Windows.Forms.ToolStripMenuItem mitmYazarTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmYazarSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmYayineviTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmYayineviSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmRaporlama;
    }
}