namespace Reporting
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VideoMarketDataSet = new Reporting.VideoMarketDataSet();
            this.MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MusterilerTableAdapter = new Reporting.VideoMarketDataSetTableAdapters.MusterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // VideoMarketDataSet
            // 
            this.VideoMarketDataSet.DataSetName = "VideoMarketDataSet";
            this.VideoMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusterilerBindingSource
            // 
            this.MusterilerBindingSource.DataMember = "Musteriler";
            this.MusterilerBindingSource.DataSource = this.VideoMarketDataSet;
            // 
            // MusterilerTableAdapter
            // 
            this.MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 569);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MusterilerBindingSource;
        private VideoMarketDataSet VideoMarketDataSet;
        private VideoMarketDataSetTableAdapters.MusterilerTableAdapter MusterilerTableAdapter;
    }
}

