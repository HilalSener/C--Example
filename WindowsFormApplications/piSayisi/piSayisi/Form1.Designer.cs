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
            this.btnDaireninCevresi.Location = new System.Drawing.Point(62, 111);
            this.btnDaireninCevresi.Name = "btnDaireninCevresi";
            this.btnDaireninCevresi.Size = new System.Drawing.Size(75, 35);
            this.btnDaireninCevresi.TabIndex = 2;
            this.btnDaireninCevresi.Text = "Dairenin Çevresi";
            this.btnDaireninCevresi.UseVisualStyleBackColor = true;
            this.btnDaireninCevresi.Click += new System.EventHandler(this.btnDaireninCevresi_Click);
            // 
            // btnDaireninAlani
            // 
            this.btnDaireninAlani.Location = new System.Drawing.Point(156, 111);
            this.btnDaireninAlani.Name = "btnDaireninAlani";
            this.btnDaireninAlani.Size = new System.Drawing.Size(75, 35);
            this.btnDaireninAlani.TabIndex = 2;
            this.btnDaireninAlani.Text = "Dairenin Alanı";
            this.btnDaireninAlani.UseVisualStyleBackColor = true;
            this.btnDaireninAlani.Click += new System.EventHandler(this.btnDaireninAlani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
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
    }
}

