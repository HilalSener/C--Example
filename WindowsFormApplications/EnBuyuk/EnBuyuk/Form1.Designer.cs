namespace EnBuyuk
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnBuyuk = new System.Windows.Forms.TextBox();
            this.lblEnKucuk = new System.Windows.Forms.Label();
            this.txtEnKucuk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Büyük";
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(48, 62);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(50, 20);
            this.txtEnBuyuk.TabIndex = 1;
            // 
            // lblEnKucuk
            // 
            this.lblEnKucuk.AutoSize = true;
            this.lblEnKucuk.Location = new System.Drawing.Point(180, 46);
            this.lblEnKucuk.Name = "lblEnKucuk";
            this.lblEnKucuk.Size = new System.Drawing.Size(54, 13);
            this.lblEnKucuk.TabIndex = 0;
            this.lblEnKucuk.Text = "En Küçük";
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.Location = new System.Drawing.Point(183, 62);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(50, 20);
            this.txtEnKucuk.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEnKucuk);
            this.Controls.Add(this.lblEnKucuk);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnBuyuk;
        private System.Windows.Forms.Label lblEnKucuk;
        private System.Windows.Forms.TextBox txtEnKucuk;
    }
}

