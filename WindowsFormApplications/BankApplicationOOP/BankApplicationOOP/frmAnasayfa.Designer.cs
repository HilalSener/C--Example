namespace BankApplicationOOP
{
    partial class frmAnasayfa
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
            this.mnuAnaSayfa.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuAnaSayfa.Size = new System.Drawing.Size(379, 28);
            this.mnuAnaSayfa.TabIndex = 2;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmHesapAcilisi,
            this.mitmHesapDokumu,
            this.mitmProgramdanCikis});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // mitmHesapAcilisi
            // 
            this.mitmHesapAcilisi.Name = "mitmHesapAcilisi";
            this.mitmHesapAcilisi.Size = new System.Drawing.Size(200, 26);
            this.mitmHesapAcilisi.Text = "Hesap Açılışı";
            this.mitmHesapAcilisi.Click += new System.EventHandler(this.mitmHesapAcilisi_Click);
            // 
            // mitmHesapDokumu
            // 
            this.mitmHesapDokumu.Name = "mitmHesapDokumu";
            this.mitmHesapDokumu.Size = new System.Drawing.Size(200, 26);
            this.mitmHesapDokumu.Text = "Hesap Dökümü";
            this.mitmHesapDokumu.Click += new System.EventHandler(this.mitmHesapDokumu_Click);
            // 
            // mitmProgramdanCikis
            // 
            this.mitmProgramdanCikis.Name = "mitmProgramdanCikis";
            this.mitmProgramdanCikis.Size = new System.Drawing.Size(200, 26);
            this.mitmProgramdanCikis.Text = "Programdan Çıkış";
            this.mitmProgramdanCikis.Click += new System.EventHandler(this.mitmProgramdanCikis_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.mnuAnaSayfa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnasayfa";
            this.Text = "Form1";
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

