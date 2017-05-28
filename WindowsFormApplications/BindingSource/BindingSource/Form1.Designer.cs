namespace BindingSource
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
            this.components = new System.ComponentModel.Container();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoMarketDataSet = new BindingSource.VideoMarketDataSet();
            this.musterilerTableAdapter = new BindingSource.VideoMarketDataSetTableAdapters.MusterilerTableAdapter();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silindiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // bs1
            // 
            this.bs1.DataMember = "Musteriler";
            this.bs1.DataSource = this.videoMarketDataSet;
            // 
            // videoMarketDataSet
            // 
            this.videoMarketDataSet.DataSetName = "VideoMarketDataSet";
            this.videoMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AutoGenerateColumns = false;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriNoDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.silindiDataGridViewCheckBoxColumn});
            this.dgvMusteriler.DataSource = this.bs1;
            this.dgvMusteriler.Location = new System.Drawing.Point(12, 62);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(842, 424);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // silindiDataGridViewCheckBoxColumn
            // 
            this.silindiDataGridViewCheckBoxColumn.DataPropertyName = "Silindi";
            this.silindiDataGridViewCheckBoxColumn.HeaderText = "Silindi";
            this.silindiDataGridViewCheckBoxColumn.Name = "silindiDataGridViewCheckBoxColumn";
            // 
            // txtAdi
            // 
            this.txtAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs1, "MusteriAd", true));
            this.txtAdi.Location = new System.Drawing.Point(414, 498);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(128, 22);
            this.txtAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Adı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs1, "MusteriSoyad", true));
            this.txtSoyadi.Location = new System.Drawing.Point(414, 527);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(128, 22);
            this.txtSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs1, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(414, 555);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(128, 22);
            this.txtTelefon.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs1, "Adres", true));
            this.txtAdres.Location = new System.Drawing.Point(414, 583);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(128, 22);
            this.txtAdres.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(316, 33);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(53, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(375, 33);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(53, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(434, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(493, 33);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(53, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 660);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dgvMusteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs1;
        private VideoMarketDataSet videoMarketDataSet;
        private VideoMarketDataSetTableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn silindiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}

