namespace VideoMarket
{
    partial class frmFilmSorgulama
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOyuncularaGore = new System.Windows.Forms.TextBox();
            this.txtYonetmeneGore = new System.Windows.Forms.TextBox();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFilmTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Oyunculara Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yönetmene Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "FilmTürüne Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Film Adına Göre";
            // 
            // txtOyuncularaGore
            // 
            this.txtOyuncularaGore.Location = new System.Drawing.Point(401, 107);
            this.txtOyuncularaGore.Name = "txtOyuncularaGore";
            this.txtOyuncularaGore.Size = new System.Drawing.Size(130, 22);
            this.txtOyuncularaGore.TabIndex = 11;
            this.txtOyuncularaGore.TextChanged += new System.EventHandler(this.txtOyuncularaGore_TextChanged);
            // 
            // txtYonetmeneGore
            // 
            this.txtYonetmeneGore.Location = new System.Drawing.Point(279, 107);
            this.txtYonetmeneGore.Name = "txtYonetmeneGore";
            this.txtYonetmeneGore.Size = new System.Drawing.Size(113, 22);
            this.txtYonetmeneGore.TabIndex = 12;
            this.txtYonetmeneGore.TextChanged += new System.EventHandler(this.txtYonetmeneGore_TextChanged);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(49, 107);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(100, 22);
            this.txtAdaGore.TabIndex = 14;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // lvFilmler
            // 
            this.lvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.GridLines = true;
            this.lvFilmler.Location = new System.Drawing.Point(49, 148);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(821, 278);
            this.lvFilmler.TabIndex = 10;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.View = System.Windows.Forms.View.Details;
            this.lvFilmler.DoubleClick += new System.EventHandler(this.lvFilmler_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Film No";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Film Tür No";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Türü";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yönetmen";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oyuncular";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Özet";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            // 
            // cbFilmTuru
            // 
            this.cbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTuru.DropDownWidth = 100;
            this.cbFilmTuru.FormattingEnabled = true;
            this.cbFilmTuru.Location = new System.Drawing.Point(155, 105);
            this.cbFilmTuru.Name = "cbFilmTuru";
            this.cbFilmTuru.Size = new System.Drawing.Size(114, 24);
            this.cbFilmTuru.TabIndex = 37;
            this.cbFilmTuru.SelectedIndexChanged += new System.EventHandler(this.cbFilmTuru_SelectedIndexChanged);
            // 
            // frmFilmSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 484);
            this.Controls.Add(this.cbFilmTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncularaGore);
            this.Controls.Add(this.txtYonetmeneGore);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.lvFilmler);
            this.Name = "frmFilmSorgulama";
            this.Text = "Film Sorgulama";
            this.Load += new System.EventHandler(this.frmFilmSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOyuncularaGore;
        private System.Windows.Forms.TextBox txtYonetmeneGore;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbFilmTuru;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}