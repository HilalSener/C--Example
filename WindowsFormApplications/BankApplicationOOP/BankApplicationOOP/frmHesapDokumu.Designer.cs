namespace BankApplicationOOP
{
    partial class frmHesapDokumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapDokumu));
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamCekilen = new System.Windows.Forms.TextBox();
            this.txtAcilisTarihi = new System.Windows.Forms.TextBox();
            this.txtToplamYatan = new System.Windows.Forms.TextBox();
            this.txtHesapTuru = new System.Windows.Forms.TextBox();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnParaIslemleri = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdocHareketler = new System.Drawing.Printing.PrintDocument();
            this.ppdHareketler = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHareketler.Location = new System.Drawing.Point(48, 320);
            this.lvHareketler.Margin = new System.Windows.Forms.Padding(4);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(465, 173);
            this.lvHareketler.TabIndex = 32;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tutarı";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Türü";
            this.columnHeader5.Width = 90;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(180, 568);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBakiye.MaxLength = 11;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(121, 22);
            this.txtBakiye.TabIndex = 31;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamCekilen
            // 
            this.txtToplamCekilen.Location = new System.Drawing.Point(180, 539);
            this.txtToplamCekilen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamCekilen.Name = "txtToplamCekilen";
            this.txtToplamCekilen.ReadOnly = true;
            this.txtToplamCekilen.Size = new System.Drawing.Size(121, 22);
            this.txtToplamCekilen.TabIndex = 26;
            this.txtToplamCekilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAcilisTarihi
            // 
            this.txtAcilisTarihi.Location = new System.Drawing.Point(208, 276);
            this.txtAcilisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcilisTarihi.MaxLength = 11;
            this.txtAcilisTarihi.Name = "txtAcilisTarihi";
            this.txtAcilisTarihi.ReadOnly = true;
            this.txtAcilisTarihi.Size = new System.Drawing.Size(121, 22);
            this.txtAcilisTarihi.TabIndex = 30;
            // 
            // txtToplamYatan
            // 
            this.txtToplamYatan.Location = new System.Drawing.Point(180, 511);
            this.txtToplamYatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamYatan.MaxLength = 11;
            this.txtToplamYatan.Name = "txtToplamYatan";
            this.txtToplamYatan.ReadOnly = true;
            this.txtToplamYatan.Size = new System.Drawing.Size(121, 22);
            this.txtToplamYatan.TabIndex = 29;
            this.txtToplamYatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(208, 248);
            this.txtHesapTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.ReadOnly = true;
            this.txtHesapTuru.Size = new System.Drawing.Size(121, 22);
            this.txtHesapTuru.TabIndex = 25;
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(208, 219);
            this.txtTCKNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTCKNo.MaxLength = 11;
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.ReadOnly = true;
            this.txtTCKNo.Size = new System.Drawing.Size(121, 22);
            this.txtTCKNo.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bakiye";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(208, 191);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(121, 22);
            this.txtSoyadi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Açılış Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Toplam Çekilen";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(208, 163);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(121, 22);
            this.txtAdi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Toplam Yatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hesap Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "T.C Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Adı";
            // 
            // btnYazici
            // 
            this.btnYazici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYazici.Location = new System.Drawing.Point(369, 553);
            this.btnYazici.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(125, 30);
            this.btnYazici.TabIndex = 15;
            this.btnYazici.Text = "Yazıcıya Gönder";
            this.btnYazici.UseVisualStyleBackColor = false;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnParaIslemleri
            // 
            this.btnParaIslemleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParaIslemleri.Location = new System.Drawing.Point(369, 522);
            this.btnParaIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaIslemleri.Name = "btnParaIslemleri";
            this.btnParaIslemleri.Size = new System.Drawing.Size(125, 30);
            this.btnParaIslemleri.TabIndex = 14;
            this.btnParaIslemleri.Text = "Para İşlemleri";
            this.btnParaIslemleri.UseVisualStyleBackColor = false;
            this.btnParaIslemleri.Click += new System.EventHandler(this.btnParaIslemleri_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBul.Location = new System.Drawing.Point(356, 104);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 30);
            this.btnBul.TabIndex = 13;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(208, 107);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(121, 22);
            this.txtHesapNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hesap No";
            // 
            // pdocHareketler
            // 
            this.pdocHareketler.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocHareketler_PrintPage);
            // 
            // ppdHareketler
            // 
            this.ppdHareketler.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHareketler.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHareketler.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHareketler.Document = this.pdocHareketler;
            this.ppdHareketler.Enabled = true;
            this.ppdHareketler.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHareketler.Icon")));
            this.ppdHareketler.Name = "ppdHareketler";
            this.ppdHareketler.Visible = false;
            // 
            // frmHesapDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 695);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtToplamCekilen);
            this.Controls.Add(this.txtAcilisTarihi);
            this.Controls.Add(this.txtToplamYatan);
            this.Controls.Add(this.txtHesapTuru);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYazici);
            this.Controls.Add(this.btnParaIslemleri);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label1);
            this.Name = "frmHesapDokumu";
            this.Text = "frmHesapDokumu";
            this.Load += new System.EventHandler(this.frmHesapDokumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamCekilen;
        private System.Windows.Forms.TextBox txtAcilisTarihi;
        private System.Windows.Forms.TextBox txtToplamYatan;
        private System.Windows.Forms.TextBox txtHesapTuru;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYazici;
        private System.Windows.Forms.Button btnParaIslemleri;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument pdocHareketler;
        private System.Windows.Forms.PrintPreviewDialog ppdHareketler;
    }
}