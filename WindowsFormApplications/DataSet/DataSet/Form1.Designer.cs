namespace dataSet
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.txtSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(362, 27);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(146, 29);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Filmleri Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(33, 76);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.RowTemplate.Height = 24;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(827, 506);
            this.dgvFilmler.TabIndex = 1;
            // 
            // txtSayisi
            // 
            this.txtSayisi.Location = new System.Drawing.Point(336, 608);
            this.txtSayisi.Name = "txtSayisi";
            this.txtSayisi.ReadOnly = true;
            this.txtSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtSayisi.TabIndex = 2;
            this.txtSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "adet listelenmiştir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayisi);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Bağlantısız Erişim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.TextBox txtSayisi;
        private System.Windows.Forms.Label label1;
    }
}

