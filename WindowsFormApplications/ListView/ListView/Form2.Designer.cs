namespace ListView
{
    partial class Form2
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
            this.lvDetaylar = new System.Windows.Forms.ListView();
            this.Modeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İşlemci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hafıza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ekran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kamera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvDetaylar
            // 
            this.lvDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Modeller,
            this.İşlemci,
            this.Hafıza,
            this.Ekran,
            this.Kamera,
            this.Fiyat});
            this.lvDetaylar.FullRowSelect = true;
            this.lvDetaylar.Location = new System.Drawing.Point(39, 63);
            this.lvDetaylar.Name = "lvDetaylar";
            this.lvDetaylar.Size = new System.Drawing.Size(545, 160);
            this.lvDetaylar.TabIndex = 7;
            this.lvDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvDetaylar.View = System.Windows.Forms.View.Details;
            // 
            // Modeller
            // 
            this.Modeller.Text = "Modeller";
            this.Modeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Modeller.Width = 90;
            // 
            // İşlemci
            // 
            this.İşlemci.Text = "İşlemci";
            this.İşlemci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbMarkalar.Location = new System.Drawing.Point(39, 36);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cbMarkalar.TabIndex = 5;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.lvDetaylar);
            this.Controls.Add(this.cbMarkalar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDetaylar;
        private System.Windows.Forms.ColumnHeader İşlemci;
        private System.Windows.Forms.ColumnHeader Hafıza;
        private System.Windows.Forms.ColumnHeader Ekran;
        private System.Windows.Forms.ColumnHeader Kamera;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ColumnHeader Modeller;
    }
}