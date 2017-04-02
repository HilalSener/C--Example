namespace OOP
{
    partial class Form2
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
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon No";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(119, 99);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 0;
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(118, 127);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(100, 23);
            this.btnAramaYap.TabIndex = 2;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Location = new System.Drawing.Point(118, 156);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(100, 23);
            this.btnMesajGonder.TabIndex = 3;
            this.btnMesajGonder.Text = "Mesaj Gönder";
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(225, 99);
            this.txtMesaj.MaxLength = 10;
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 80);
            this.txtMesaj.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.btnAramaYap);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.TextBox txtMesaj;
    }
}