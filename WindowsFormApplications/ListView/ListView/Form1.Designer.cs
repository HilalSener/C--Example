namespace ListView
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
            this.lbModeller = new System.Windows.Forms.ListBox();
            this.cbPhone = new System.Windows.Forms.ComboBox();
            this.lvDetaylar = new System.Windows.Forms.ListView();
            this.İşlemci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hafıza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ekran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kamera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbModeller
            // 
            this.lbModeller.FormattingEnabled = true;
            this.lbModeller.Location = new System.Drawing.Point(12, 40);
            this.lbModeller.Name = "lbModeller";
            this.lbModeller.Size = new System.Drawing.Size(120, 160);
            this.lbModeller.TabIndex = 3;
            this.lbModeller.SelectedIndexChanged += new System.EventHandler(this.lbModeller_SelectedIndexChanged);
            // 
            // cbPhone
            // 
            this.cbPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhone.FormattingEnabled = true;
            this.cbPhone.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbPhone.Location = new System.Drawing.Point(12, 12);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(121, 21);
            this.cbPhone.TabIndex = 2;
            this.cbPhone.SelectedIndexChanged += new System.EventHandler(this.cbPhone_SelectedIndexChanged);
            // 
            // lvDetaylar
            // 
            this.lvDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İşlemci,
            this.Hafıza,
            this.Ekran,
            this.Kamera,
            this.Fiyat});
            this.lvDetaylar.Location = new System.Drawing.Point(138, 40);
            this.lvDetaylar.Name = "lvDetaylar";
            this.lvDetaylar.Size = new System.Drawing.Size(455, 160);
            this.lvDetaylar.TabIndex = 4;
            this.lvDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvDetaylar.View = System.Windows.Forms.View.Details;
            // 
            // İşlemci
            // 
            this.İşlemci.Text = "İşlemci";
            this.İşlemci.Width = 90;
            // 
            // Hafıza
            // 
            this.Hafıza.Text = "Hafıza";
            this.Hafıza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hafıza.Width = 90;
            // 
            // Ekran
            // 
            this.Ekran.Text = "Ekran";
            this.Ekran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ekran.Width = 90;
            // 
            // Kamera
            // 
            this.Kamera.Text = "Kamera";
            this.Kamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kamera.Width = 90;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fiyat.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 261);
            this.Controls.Add(this.lvDetaylar);
            this.Controls.Add(this.lbModeller);
            this.Controls.Add(this.cbPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbModeller;
        private System.Windows.Forms.ComboBox cbPhone;
        private System.Windows.Forms.ListView lvDetaylar;
        private System.Windows.Forms.ColumnHeader İşlemci;
        private System.Windows.Forms.ColumnHeader Hafıza;
        private System.Windows.Forms.ColumnHeader Ekran;
        private System.Windows.Forms.ColumnHeader Kamera;
        private System.Windows.Forms.ColumnHeader Fiyat;
    }
}

