namespace Donguler
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.lbCiftSayilar = new System.Windows.Forms.ListBox();
            this.btnCift = new System.Windows.Forms.Button();
            this.txtToplamCift = new System.Windows.Forms.TextBox();
            this.lbTekSayilar = new System.Windows.Forms.ListBox();
            this.btnTek = new System.Windows.Forms.Button();
            this.txtToplamTek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(92, 59);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(98, 95);
            this.lbSayilar.TabIndex = 0;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(92, 27);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(98, 23);
            this.btnSayilar.TabIndex = 1;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam:";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(92, 161);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(98, 20);
            this.txtToplam.TabIndex = 3;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCiftSayilar
            // 
            this.lbCiftSayilar.FormattingEnabled = true;
            this.lbCiftSayilar.Location = new System.Drawing.Point(231, 59);
            this.lbCiftSayilar.Name = "lbCiftSayilar";
            this.lbCiftSayilar.Size = new System.Drawing.Size(98, 95);
            this.lbCiftSayilar.TabIndex = 0;
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(231, 27);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(98, 23);
            this.btnCift.TabIndex = 1;
            this.btnCift.Text = "Çift Sayılar";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // txtToplamCift
            // 
            this.txtToplamCift.Location = new System.Drawing.Point(231, 161);
            this.txtToplamCift.Name = "txtToplamCift";
            this.txtToplamCift.ReadOnly = true;
            this.txtToplamCift.Size = new System.Drawing.Size(98, 20);
            this.txtToplamCift.TabIndex = 3;
            this.txtToplamCift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTekSayilar
            // 
            this.lbTekSayilar.FormattingEnabled = true;
            this.lbTekSayilar.Location = new System.Drawing.Point(367, 59);
            this.lbTekSayilar.Name = "lbTekSayilar";
            this.lbTekSayilar.Size = new System.Drawing.Size(98, 95);
            this.lbTekSayilar.TabIndex = 0;
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(367, 27);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(98, 23);
            this.btnTek.TabIndex = 1;
            this.btnTek.Text = "Tek Sayılar";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // txtToplamTek
            // 
            this.txtToplamTek.Location = new System.Drawing.Point(367, 161);
            this.txtToplamTek.Name = "txtToplamTek";
            this.txtToplamTek.ReadOnly = true;
            this.txtToplamTek.Size = new System.Drawing.Size(98, 20);
            this.txtToplamTek.TabIndex = 3;
            this.txtToplamTek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 211);
            this.Controls.Add(this.txtToplamTek);
            this.Controls.Add(this.txtToplamCift);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lbTekSayilar);
            this.Controls.Add(this.lbCiftSayilar);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Döngüler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.ListBox lbCiftSayilar;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.TextBox txtToplamCift;
        private System.Windows.Forms.ListBox lbTekSayilar;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.TextBox txtToplamTek;
    }
}

