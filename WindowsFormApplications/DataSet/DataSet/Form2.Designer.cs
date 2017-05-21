namespace dataSet
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(326, 25);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(209, 33);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(34, 76);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.RowTemplate.Height = 24;
            this.dgvSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislar.Size = new System.Drawing.Size(831, 519);
            this.dgvSatislar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam";
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(384, 614);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(100, 22);
            this.txtToplamAdet.TabIndex = 3;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(490, 614);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 22);
            this.txtToplamTutar.TabIndex = 3;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 663);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.TextBox txtToplamTutar;
    }
}