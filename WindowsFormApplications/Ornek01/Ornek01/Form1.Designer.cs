namespace Ornek01
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
            this.TamamBtn = new System.Windows.Forms.Button();
            this.AdiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TamamBtn
            // 
            this.TamamBtn.BackColor = System.Drawing.Color.Orange;
            this.TamamBtn.Location = new System.Drawing.Point(140, 75);
            this.TamamBtn.Name = "TamamBtn";
            this.TamamBtn.Size = new System.Drawing.Size(185, 33);
            this.TamamBtn.TabIndex = 0;
            this.TamamBtn.Text = "Tamam";
            this.TamamBtn.UseVisualStyleBackColor = false;
            this.TamamBtn.Click += new System.EventHandler(this.TamamBtn_Click);
            // 
            // AdiTxt
            // 
            this.AdiTxt.Location = new System.Drawing.Point(187, 49);
            this.AdiTxt.Name = "AdiTxt";
            this.AdiTxt.Size = new System.Drawing.Size(138, 20);
            this.AdiTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsminiz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(555, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdiTxt);
            this.Controls.Add(this.TamamBtn);
            this.Name = "Form1";
            this.Text = "Windows Form Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TamamBtn;
        private System.Windows.Forms.TextBox AdiTxt;
        private System.Windows.Forms.Label label1;
    }
}

