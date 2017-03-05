namespace piSayisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYariCap = new System.Windows.Forms.TextBox();
            this.btnDaireninCevresi = new System.Windows.Forms.Button();
            this.btnDaireninAlani = new System.Windows.Forms.Button();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap";
            // 
            // txtYariCap
            // 
            this.txtYariCap.Location = new System.Drawing.Point(100, 61);
            this.txtYariCap.Name = "txtYariCap";
            this.txtYariCap.Size = new System.Drawing.Size(100, 20);
            this.txtYariCap.TabIndex = 1;
            // 
            // btnDaireninCevresi
            // 
            this.btnDaireninCevresi.Location = new System.Drawing.Point(63, 140);
            this.btnDaireninCevresi.Name = "btnDaireninCevresi";
            this.btnDaireninCevresi.Size = new System.Drawing.Size(75, 35);
            this.btnDaireninCevresi.TabIndex = 2;
            this.btnDaireninCevresi.Text = "Dairenin Çevresi";
            this.btnDaireninCevresi.UseVisualStyleBackColor = true;
            this.btnDaireninCevresi.Visible = false;
            this.btnDaireninCevresi.Click += new System.EventHandler(this.btnDaireninCevresi_Click);
            // 
            // btnDaireninAlani
            // 
            this.btnDaireninAlani.Location = new System.Drawing.Point(157, 140);
            this.btnDaireninAlani.Name = "btnDaireninAlani";
            this.btnDaireninAlani.Size = new System.Drawing.Size(75, 35);
            this.btnDaireninAlani.TabIndex = 2;
            this.btnDaireninAlani.Text = "Dairenin Alanı";
            this.btnDaireninAlani.UseVisualStyleBackColor = true;
            this.btnDaireninAlani.Visible = false;
            this.btnDaireninAlani.Click += new System.EventHandler(this.btnDaireninAlani_Click);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Checked = true;
            this.rbCevre.Location = new System.Drawing.Point(13, 13);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(102, 17);
            this.rbCevre.TabIndex = 3;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Dairenin Çevresi";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(196, 13);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(90, 17);
            this.rbAlan.TabIndex = 3;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "Dairenin Alanı";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(100, 87);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.btnDaireninAlani);
            this.Controls.Add(this.btnDaireninCevresi);
            this.Controls.Add(this.txtYariCap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dairenin Çevresi ve Alan Hesabı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYariCap;
        private System.Windows.Forms.Button btnDaireninCevresi;
        private System.Windows.Forms.Button btnDaireninAlani;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.RadioButton rbAlan;
        private System.Windows.Forms.Button btnHesapla;
    }
}

