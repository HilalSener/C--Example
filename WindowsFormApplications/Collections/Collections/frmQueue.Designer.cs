namespace Collections
{
    partial class frmQueue
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
            this.lbList1 = new System.Windows.Forms.ListBox();
            this.lbList2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbList1
            // 
            this.lbList1.FormattingEnabled = true;
            this.lbList1.ItemHeight = 16;
            this.lbList1.Location = new System.Drawing.Point(113, 153);
            this.lbList1.Name = "lbList1";
            this.lbList1.Size = new System.Drawing.Size(129, 260);
            this.lbList1.TabIndex = 0;
            // 
            // lbList2
            // 
            this.lbList2.FormattingEnabled = true;
            this.lbList2.ItemHeight = 16;
            this.lbList2.Location = new System.Drawing.Point(272, 153);
            this.lbList2.Name = "lbList2";
            this.lbList2.Size = new System.Drawing.Size(129, 260);
            this.lbList2.TabIndex = 0;
            // 
            // frmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 616);
            this.Controls.Add(this.lbList2);
            this.Controls.Add(this.lbList1);
            this.Name = "frmQueue";
            this.Text = "frmQueue";
            this.Load += new System.EventHandler(this.frmQueue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbList1;
        private System.Windows.Forms.ListBox lbList2;
    }
}