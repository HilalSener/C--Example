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
            this.txtOgrenciEnKucuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciEnBuyuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Büyük";
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(64, 76);
            this.txtEnBuyuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(65, 22);
            this.txtEnBuyuk.TabIndex = 1;
            // 
            // lblEnKucuk
            // 
            this.lblEnKucuk.AutoSize = true;
            this.lblEnKucuk.Location = new System.Drawing.Point(61, 141);
            this.lblEnKucuk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnKucuk.Name = "lblEnKucuk";
            this.lblEnKucuk.Size = new System.Drawing.Size(68, 17);
            this.lblEnKucuk.TabIndex = 0;
            this.lblEnKucuk.Text = "En Küçük";
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.Location = new System.Drawing.Point(63, 162);
            this.txtEnKucuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(65, 22);
            this.txtEnKucuk.TabIndex = 1;
            // 
            // txtOgrenciEnKucuk
            // 
            this.txtOgrenciEnKucuk.Location = new System.Drawing.Point(235, 162);
            this.txtOgrenciEnKucuk.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrenciEnKucuk.Name = "txtOgrenciEnKucuk";
            this.txtOgrenciEnKucuk.Size = new System.Drawing.Size(65, 22);
            this.txtOgrenciEnKucuk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alan Öğrenci";
            // 
            // txtOgrenciEnBuyuk
            // 
            this.txtOgrenciEnBuyuk.Location = new System.Drawing.Point(236, 76);
            this.txtOgrenciEnBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrenciEnBuyuk.Name = "txtOgrenciEnBuyuk";
            this.txtOgrenciEnBuyuk.Size = new System.Drawing.Size(65, 22);
            this.txtOgrenciEnBuyuk.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alan Öğrenci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.txtOgrenciEnKucuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciEnBuyuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnKucuk);
            this.Controls.Add(this.lblEnKucuk);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtOgrenciEnKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciEnBuyuk;
        private System.Windows.Forms.Label label3;
    }
}

