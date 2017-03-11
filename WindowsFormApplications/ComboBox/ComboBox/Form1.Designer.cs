namespace ComboBox
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
            this.cbPhone = new System.Windows.Forms.ComboBox();
            this.lbModeller = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbPhone
            // 
            this.cbPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhone.FormattingEnabled = true;
            this.cbPhone.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbPhone.Location = new System.Drawing.Point(80, 47);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(121, 21);
            this.cbPhone.TabIndex = 0;
            this.cbPhone.SelectedIndexChanged += new System.EventHandler(this.cbPhone_SelectedIndexChanged);
            // 
            // lbModeller
            // 
            this.lbModeller.FormattingEnabled = true;
            this.lbModeller.Location = new System.Drawing.Point(80, 75);
            this.lbModeller.Name = "lbModeller";
            this.lbModeller.Size = new System.Drawing.Size(120, 95);
            this.lbModeller.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbModeller);
            this.Controls.Add(this.cbPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhone;
        private System.Windows.Forms.ListBox lbModeller;
    }
}

