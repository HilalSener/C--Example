﻿namespace BankApplication
{
    partial class frmHesapAcilisi
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblHesapId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcilisTarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.cbHesapTurleri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap ID";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(103, 117);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(92, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // lblHesapId
            // 
            this.lblHesapId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapId.Location = new System.Drawing.Point(103, 49);
            this.lblHesapId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHesapId.Name = "lblHesapId";
            this.lblHesapId.Size = new System.Drawing.Size(91, 14);
            this.lblHesapId.TabIndex = 0;
            this.lblHesapId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesap No";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapNo.Location = new System.Drawing.Point(103, 70);
            this.lblHesapNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(91, 14);
            this.lblHesapNo.TabIndex = 0;
            this.lblHesapNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açılış Tarihi";
            // 
            // lblAcilisTarihi
            // 
            this.lblAcilisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcilisTarihi.Location = new System.Drawing.Point(103, 93);
            this.lblAcilisTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcilisTarihi.Name = "lblAcilisTarihi";
            this.lblAcilisTarihi.Size = new System.Drawing.Size(91, 14);
            this.lblAcilisTarihi.TabIndex = 0;
            this.lblAcilisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyadı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(103, 140);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(92, 20);
            this.txtSoyadi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "T.C Kimlik No";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(103, 163);
            this.txtTCKNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTCKNo.MaxLength = 11;
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(92, 20);
            this.txtTCKNo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bakiye";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(103, 188);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(92, 20);
            this.txtBakiye.TabIndex = 3;
            // 
            // cbHesapTurleri
            // 
            this.cbHesapTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHesapTurleri.FormattingEnabled = true;
            this.cbHesapTurleri.Items.AddRange(new object[] {
            "Vadesiz Hesap",
            "Vadeli Hesap"});
            this.cbHesapTurleri.Location = new System.Drawing.Point(103, 214);
            this.cbHesapTurleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHesapTurleri.Name = "cbHesapTurleri";
            this.cbHesapTurleri.Size = new System.Drawing.Size(92, 21);
            this.cbHesapTurleri.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hesap Türü";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapAc.Location = new System.Drawing.Point(103, 252);
            this.btnHesapAc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(91, 26);
            this.btnHesapAc.TabIndex = 5;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // frmHesapAcilisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 518);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.cbHesapTurleri);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAcilisTarihi);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblHesapId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHesapAcilisi";
            this.Text = "Yeni Hesap Açılış İşlemleri";
            this.Load += new System.EventHandler(this.frmHesapAcilisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblHesapId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcilisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.ComboBox cbHesapTurleri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHesapAc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}