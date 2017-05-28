namespace Collections
{
    partial class frmHashTable
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
            this.lbList3 = new System.Windows.Forms.ListBox();
            this.lbList2 = new System.Windows.Forms.ListBox();
            this.lbList1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbList3
            // 
            this.lbList3.FormattingEnabled = true;
            this.lbList3.ItemHeight = 16;
            this.lbList3.Location = new System.Drawing.Point(429, 60);
            this.lbList3.Name = "lbList3";
            this.lbList3.Size = new System.Drawing.Size(173, 292);
            this.lbList3.TabIndex = 5;
            // 
            // lbList2
            // 
            this.lbList2.FormattingEnabled = true;
            this.lbList2.ItemHeight = 16;
            this.lbList2.Location = new System.Drawing.Point(241, 60);
            this.lbList2.Name = "lbList2";
            this.lbList2.Size = new System.Drawing.Size(173, 292);
            this.lbList2.TabIndex = 6;
            // 
            // lbList1
            // 
            this.lbList1.FormattingEnabled = true;
            this.lbList1.ItemHeight = 16;
            this.lbList1.Location = new System.Drawing.Point(53, 60);
            this.lbList1.Name = "lbList1";
            this.lbList1.Size = new System.Drawing.Size(173, 292);
            this.lbList1.TabIndex = 7;
            // 
            // frmHashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.lbList3);
            this.Controls.Add(this.lbList2);
            this.Controls.Add(this.lbList1);
            this.Name = "frmHashTable";
            this.Text = "frmHashTable";
            this.Load += new System.EventHandler(this.frmHashTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbList3;
        private System.Windows.Forms.ListBox lbList2;
        private System.Windows.Forms.ListBox lbList1;
    }
}