namespace Sozluk
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
            this.lblTurkce = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.rbTrToIng = new System.Windows.Forms.RadioButton();
            this.rbIngtToTr = new System.Windows.Forms.RadioButton();
            this.lbKelimeler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCeviri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkce.Location = new System.Drawing.Point(117, 104);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(52, 17);
            this.lblTurkce.TabIndex = 0;
            this.lblTurkce.Text = "Türkçe";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(175, 104);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.ReadOnly = true;
            this.txtTurkce.Size = new System.Drawing.Size(126, 20);
            this.txtTurkce.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(175, 137);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.ReadOnly = true;
            this.txtIngilizce.Size = new System.Drawing.Size(126, 20);
            this.txtIngilizce.TabIndex = 2;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Snow;
            this.btnBul.Location = new System.Drawing.Point(308, 104);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 53);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // rbTrToIng
            // 
            this.rbTrToIng.AutoSize = true;
            this.rbTrToIng.Checked = true;
            this.rbTrToIng.Location = new System.Drawing.Point(12, 28);
            this.rbTrToIng.Name = "rbTrToIng";
            this.rbTrToIng.Size = new System.Drawing.Size(106, 17);
            this.rbTrToIng.TabIndex = 4;
            this.rbTrToIng.TabStop = true;
            this.rbTrToIng.Text = "Türkçe - İngilizce";
            this.rbTrToIng.UseVisualStyleBackColor = true;
            this.rbTrToIng.CheckedChanged += new System.EventHandler(this.rbTrToIng_CheckedChanged);
            // 
            // rbIngtToTr
            // 
            this.rbIngtToTr.AutoSize = true;
            this.rbIngtToTr.Location = new System.Drawing.Point(279, 28);
            this.rbIngtToTr.Name = "rbIngtToTr";
            this.rbIngtToTr.Size = new System.Drawing.Size(106, 17);
            this.rbIngtToTr.TabIndex = 4;
            this.rbIngtToTr.Text = "İngilizce - Türkçe";
            this.rbIngtToTr.UseVisualStyleBackColor = true;
            this.rbIngtToTr.CheckedChanged += new System.EventHandler(this.rbIngtToTr_CheckedChanged);
            // 
            // lbKelimeler
            // 
            this.lbKelimeler.FormattingEnabled = true;
            this.lbKelimeler.Location = new System.Drawing.Point(12, 85);
            this.lbKelimeler.Name = "lbKelimeler";
            this.lbKelimeler.Size = new System.Drawing.Size(95, 186);
            this.lbKelimeler.TabIndex = 5;
            this.lbKelimeler.DoubleClick += new System.EventHandler(this.lbKelimeler_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(117, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çevirisi";
            // 
            // txtCeviri
            // 
            this.txtCeviri.Location = new System.Drawing.Point(175, 179);
            this.txtCeviri.Name = "txtCeviri";
            this.txtCeviri.ReadOnly = true;
            this.txtCeviri.Size = new System.Drawing.Size(126, 20);
            this.txtCeviri.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(405, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKelimeler);
            this.Controls.Add(this.rbIngtToTr);
            this.Controls.Add(this.rbTrToIng);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtCeviri);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTurkce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.RadioButton rbTrToIng;
        private System.Windows.Forms.RadioButton rbIngtToTr;
        private System.Windows.Forms.ListBox lbKelimeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCeviri;
    }
}

