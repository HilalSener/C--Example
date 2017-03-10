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
            this.btnGameOver = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(203, 106);
            this.txtTahmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(61, 22);
            this.txtTahmin.TabIndex = 0;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "1-50 arasında bir sayı tuttum. Bakalım kaç defa da bulabileceksin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahmininiz:";
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(273, 103);
            this.btnDene.Margin = new System.Windows.Forms.Padding(4);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(60, 28);
            this.btnDene.TabIndex = 4;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(20, 172);
            this.btnGameOver.Margin = new System.Windows.Forms.Padding(4);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(100, 47);
            this.btnGameOver.TabIndex = 5;
            this.btnGameOver.Text = "GAME OVER";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(335, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXİT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(20, 48);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(64, 21);
            this.rbKolay.TabIndex = 6;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay";
            this.rbKolay.UseVisualStyleBackColor = true;
            this.rbKolay.CheckedChanged += new System.EventHandler(this.rbKolay_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(190, 48);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(57, 21);
            this.rbOrta.TabIndex = 6;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbOrta_CheckedChanged);
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(371, 48);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(51, 21);
            this.rbZor.TabIndex = 6;
            this.rbZor.Text = "Zor";
            this.rbZor.UseVisualStyleBackColor = true;
            this.rbZor.CheckedChanged += new System.EventHandler(this.rbZor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDene;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(455, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbZor);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKolay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTahmin);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.Label label3;
    }
}

