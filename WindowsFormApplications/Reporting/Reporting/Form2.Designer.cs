namespace Reporting
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMusteriyeGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.vw_DetayliFilmSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VideoMarketDataSet1 = new Reporting.VideoMarketDataSet1();
            this.vw_DetayliFilmSatisTableAdapter = new Reporting.VideoMarketDataSet1TableAdapters.vw_DetayliFilmSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliFilmSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_DetayliFilmSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporting.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(937, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtMusteriyeGore
            // 
            this.txtMusteriyeGore.Location = new System.Drawing.Point(344, 57);
            this.txtMusteriyeGore.Name = "txtMusteriyeGore";
            this.txtMusteriyeGore.Size = new System.Drawing.Size(178, 22);
            this.txtMusteriyeGore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteriye Göre";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(529, 56);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 24);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // vw_DetayliFilmSatisBindingSource
            // 
            this.vw_DetayliFilmSatisBindingSource.DataMember = "vw_DetayliFilmSatis";
            this.vw_DetayliFilmSatisBindingSource.DataSource = this.VideoMarketDataSet1;
            // 
            // VideoMarketDataSet1
            // 
            this.VideoMarketDataSet1.DataSetName = "VideoMarketDataSet1";
            this.VideoMarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DetayliFilmSatisTableAdapter
            // 
            this.vw_DetayliFilmSatisTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 644);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriyeGore);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_DetayliFilmSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_DetayliFilmSatisBindingSource;
        private VideoMarketDataSet1 VideoMarketDataSet1;
        private VideoMarketDataSet1TableAdapters.vw_DetayliFilmSatisTableAdapter vw_DetayliFilmSatisTableAdapter;
        private System.Windows.Forms.TextBox txtMusteriyeGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetir;
    }
}