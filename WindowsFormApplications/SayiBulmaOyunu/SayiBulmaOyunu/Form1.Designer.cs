namespace SayiBulmaOyunu
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
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(152, 59);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(47, 20);
            this.txtTahmin.TabIndex = 0;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1-50 arasında bir sayı tuttum. Bakalım kaç defa da bulabileceksin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahmininiz:";
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(205, 57);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(45, 23);
            this.btnDene.TabIndex = 4;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDene;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTahmin);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDene;
    }
}

