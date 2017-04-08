namespace BankApplicationOOP
{
    partial class frmParaIslemleri
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblIslemTarihi = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblHesapId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTamam.Location = new System.Drawing.Point(212, 242);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(121, 28);
            this.btnTamam.TabIndex = 20;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "yatan",
            "cekilen"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(212, 178);
            this.cbIslemTurleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(121, 24);
            this.cbIslemTurleri.TabIndex = 19;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(214, 145);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 22);
            this.txtTutar.TabIndex = 18;
            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIslemTarihi.Location = new System.Drawing.Point(214, 117);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(121, 17);
            this.lblIslemTarihi.TabIndex = 10;
            this.lblIslemTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapNo.Location = new System.Drawing.Point(214, 88);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(121, 17);
            this.lblHesapNo.TabIndex = 11;
            this.lblHesapNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHesapId
            // 
            this.lblHesapId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapId.Location = new System.Drawing.Point(214, 63);
            this.lblHesapId.Name = "lblHesapId";
            this.lblHesapId.Size = new System.Drawing.Size(121, 17);
            this.lblHesapId.TabIndex = 12;
            this.lblHesapId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "İşlem Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "İşlem Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hesap No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hesap ID";
            // 
            // frmParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 360);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblIslemTarihi);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblHesapId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmParaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Yatırma ve Çekme İşlemleri";
            this.Load += new System.EventHandler(this.frmParaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblIslemTarihi;
        public System.Windows.Forms.Label lblHesapNo;
        public System.Windows.Forms.Label lblHesapId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}