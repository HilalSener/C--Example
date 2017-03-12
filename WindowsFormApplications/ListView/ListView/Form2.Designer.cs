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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lvDetaylar = new System.Windows.Forms.ListView();
            this.Modeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İşlemci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hafıza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ekran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kamera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.cmGorunum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitmLargerIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmList = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmGorunum.SuspendLayout();
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
            this.lvDetaylar.ContextMenuStrip = this.cmGorunum;
            this.lvDetaylar.FullRowSelect = true;
            this.lvDetaylar.LargeImageList = this.ilLarge;
            this.lvDetaylar.Location = new System.Drawing.Point(38, 82);
            this.lvDetaylar.Name = "lvDetaylar";
            this.lvDetaylar.Size = new System.Drawing.Size(545, 160);
            this.lvDetaylar.SmallImageList = this.ilSmall;
            this.lvDetaylar.TabIndex = 7;
            this.lvDetaylar.UseCompatibleStateImageBehavior = false;
            this.lvDetaylar.View = System.Windows.Forms.View.Details;
            this.lvDetaylar.SelectedIndexChanged += new System.EventHandler(this.lvDetaylar_SelectedIndexChanged);
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
            this.cbMarkalar.Location = new System.Drawing.Point(38, 55);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cbMarkalar.TabIndex = 5;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // cmGorunum
            // 
            this.cmGorunum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmLargerIcon,
            this.mitmSmallIcon,
            this.mitmDetails,
            this.mitmTile,
            this.mitmList});
            this.cmGorunum.Name = "cmGorunum";
            this.cmGorunum.Size = new System.Drawing.Size(134, 114);
            // 
            // mitmLargerIcon
            // 
            this.mitmLargerIcon.Name = "mitmLargerIcon";
            this.mitmLargerIcon.Size = new System.Drawing.Size(133, 22);
            this.mitmLargerIcon.Text = "Larger icon";
            this.mitmLargerIcon.Click += new System.EventHandler(this.mitmLargerIcon_Click);
            // 
            // mitmSmallIcon
            // 
            this.mitmSmallIcon.Name = "mitmSmallIcon";
            this.mitmSmallIcon.Size = new System.Drawing.Size(133, 22);
            this.mitmSmallIcon.Text = "Small icon";
            this.mitmSmallIcon.Click += new System.EventHandler(this.mitmSmallIcon_Click);
            // 
            // mitmDetails
            // 
            this.mitmDetails.Name = "mitmDetails";
            this.mitmDetails.Size = new System.Drawing.Size(133, 22);
            this.mitmDetails.Text = "Details";
            this.mitmDetails.Click += new System.EventHandler(this.mitmDetails_Click);
            // 
            // mitmTile
            // 
            this.mitmTile.Name = "mitmTile";
            this.mitmTile.Size = new System.Drawing.Size(133, 22);
            this.mitmTile.Text = "Tile";
            this.mitmTile.Click += new System.EventHandler(this.mitmTile_Click);
            // 
            // mitmList
            // 
            this.mitmList.Name = "mitmList";
            this.mitmList.Size = new System.Drawing.Size(133, 22);
            this.mitmList.Text = "List";
            this.mitmList.Click += new System.EventHandler(this.mitmList_Click);
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "iphone6.png");
            this.ilSmall.Images.SetKeyName(1, "iphone6s.png");
            this.ilSmall.Images.SetKeyName(2, "iphone7.png");
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilLarge.ImageSize = new System.Drawing.Size(64, 64);
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seçilen";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(102, 260);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 10;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(208, 260);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 10;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 343);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDetaylar);
            this.Controls.Add(this.cbMarkalar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.cmGorunum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip cmGorunum;
        private System.Windows.Forms.ToolStripMenuItem mitmLargerIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmDetails;
        private System.Windows.Forms.ToolStripMenuItem mitmTile;
        private System.Windows.Forms.ToolStripMenuItem mitmList;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}