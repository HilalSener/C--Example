namespace Siralama
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
            this.lbIlkHali = new System.Windows.Forms.ListBox();
            this.lbSirali = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbIlkHali
            // 
            this.lbIlkHali.FormattingEnabled = true;
            this.lbIlkHali.ItemHeight = 16;
            this.lbIlkHali.Location = new System.Drawing.Point(12, 50);
            this.lbIlkHali.Name = "lbIlkHali";
            this.lbIlkHali.Size = new System.Drawing.Size(120, 212);
            this.lbIlkHali.TabIndex = 0;
            // 
            // lbSirali
            // 
            this.lbSirali.FormattingEnabled = true;
            this.lbSirali.ItemHeight = 16;
            this.lbSirali.Location = new System.Drawing.Point(150, 50);
            this.lbSirali.Name = "lbSirali";
            this.lbSirali.Size = new System.Drawing.Size(120, 212);
            this.lbSirali.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 282);
            this.Controls.Add(this.lbSirali);
            this.Controls.Add(this.lbIlkHali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIlkHali;
        private System.Windows.Forms.ListBox lbSirali;
    }
}

