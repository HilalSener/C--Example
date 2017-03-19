namespace Streams
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
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnHepsiniOku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtxtMetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satır";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(123, 69);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(344, 22);
            this.txtSatir.TabIndex = 1;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(123, 107);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 2;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(204, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(285, 107);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 23);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnHepsiniOku
            // 
            this.btnHepsiniOku.Location = new System.Drawing.Point(366, 107);
            this.btnHepsiniOku.Name = "btnHepsiniOku";
            this.btnHepsiniOku.Size = new System.Drawing.Size(101, 23);
            this.btnHepsiniOku.TabIndex = 2;
            this.btnHepsiniOku.Text = "Hepsini Oku";
            this.btnHepsiniOku.UseVisualStyleBackColor = true;
            this.btnHepsiniOku.Click += new System.EventHandler(this.btnHepsiniOku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Metin";
            // 
            // rbtxtMetin
            // 
            this.rbtxtMetin.Location = new System.Drawing.Point(123, 169);
            this.rbtxtMetin.Name = "rbtxtMetin";
            this.rbtxtMetin.Size = new System.Drawing.Size(344, 170);
            this.rbtxtMetin.TabIndex = 3;
            this.rbtxtMetin.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 385);
            this.Controls.Add(this.rbtxtMetin);
            this.Controls.Add(this.btnHepsiniOku);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnHepsiniOku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rbtxtMetin;
    }
}