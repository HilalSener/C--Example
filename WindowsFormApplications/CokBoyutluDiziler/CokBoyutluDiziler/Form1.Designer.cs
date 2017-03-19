namespace CokBoyutluDiziler
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
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.lbNot1 = new System.Windows.Forms.ListBox();
            this.lbNot2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.Location = new System.Drawing.Point(12, 46);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(81, 160);
            this.lbOgrenciler.TabIndex = 0;
            this.lbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lbOgrenciler_SelectedIndexChanged);
            // 
            // lbNot1
            // 
            this.lbNot1.FormattingEnabled = true;
            this.lbNot1.Location = new System.Drawing.Point(178, 46);
            this.lbNot1.Name = "lbNot1";
            this.lbNot1.Size = new System.Drawing.Size(44, 160);
            this.lbNot1.TabIndex = 0;
            this.lbNot1.SelectedIndexChanged += new System.EventHandler(this.lbNot1_SelectedIndexChanged);
            // 
            // lbNot2
            // 
            this.lbNot2.FormattingEnabled = true;
            this.lbNot2.Location = new System.Drawing.Point(228, 46);
            this.lbNot2.Name = "lbNot2";
            this.lbNot2.Size = new System.Drawing.Size(44, 160);
            this.lbNot2.TabIndex = 0;
            this.lbNot2.SelectedIndexChanged += new System.EventHandler(this.lbNot2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenciler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.Not";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.Not";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNot2);
            this.Controls.Add(this.lbNot1);
            this.Controls.Add(this.lbOgrenciler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOgrenciler;
        private System.Windows.Forms.ListBox lbNot1;
        private System.Windows.Forms.ListBox lbNot2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

