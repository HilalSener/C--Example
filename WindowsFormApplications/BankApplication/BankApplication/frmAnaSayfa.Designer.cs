namespace BankApplication
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
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapAcilisi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapDokumu = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmProgramdanCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuAnaSayfa.Size = new System.Drawing.Size(386, 24);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesapAcilisi,
            this.mitmHesapDokumu,
            this.mitmProgramdanCikis});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // mitmHesapAcilisi
            // 
            this.mitmHesapAcilisi.Name = "mitmHesapAcilisi";
            this.mitmHesapAcilisi.Size = new System.Drawing.Size(168, 22);
            this.mitmHesapAcilisi.Text = "Hesap Açılışı";
            this.mitmHesapAcilisi.Click += new System.EventHandler(this.mitmHesapAcilisi_Click_1);
            // 
            // mitmHesapDokumu
            // 
            this.mitmHesapDokumu.Name = "mitmHesapDokumu";
            this.mitmHesapDokumu.Size = new System.Drawing.Size(168, 22);
            this.mitmHesapDokumu.Text = "Hesap Dökümü";
            // 
            // mitmProgramdanCikis
            // 
            this.mitmProgramdanCikis.Name = "mitmProgramdanCikis";
            this.mitmProgramdanCikis.Size = new System.Drawing.Size(168, 22);
            this.mitmProgramdanCikis.Text = "Programdan Çıkış";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 333);
            this.Controls.Add(this.mnuAnaSayfa);
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnaSayfa";
            this.Text = "BankApplication Anasayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapAcilisi;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapDokumu;
        private System.Windows.Forms.ToolStripMenuItem mitmProgramdanCikis;
    }
}