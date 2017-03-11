namespace ListBox
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
            this.lbKullanicilar = new System.Windows.Forms.ListBox();
            this.lbSecilenler = new System.Windows.Forms.ListBox();
            this.btnSagaTek = new System.Windows.Forms.Button();
            this.btnSagaCok = new System.Windows.Forms.Button();
            this.btnSolaTek = new System.Windows.Forms.Button();
            this.btnSolaCok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKullanicilar
            // 
            this.lbKullanicilar.FormattingEnabled = true;
            this.lbKullanicilar.Items.AddRange(new object[] {
            "Hasan",
            "Oya",
            "Deniz",
            "Sinan",
            "Ayşe",
            "Hüseyin",
            "Necati",
            "Neşe"});
            this.lbKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.lbKullanicilar.Name = "lbKullanicilar";
            this.lbKullanicilar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKullanicilar.Size = new System.Drawing.Size(91, 108);
            this.lbKullanicilar.TabIndex = 0;
            // 
            // lbSecilenler
            // 
            this.lbSecilenler.FormattingEnabled = true;
            this.lbSecilenler.Location = new System.Drawing.Point(185, 12);
            this.lbSecilenler.Name = "lbSecilenler";
            this.lbSecilenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSecilenler.Size = new System.Drawing.Size(87, 108);
            this.lbSecilenler.TabIndex = 0;
            // 
            // btnSagaTek
            // 
            this.btnSagaTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagaTek.Location = new System.Drawing.Point(124, 12);
            this.btnSagaTek.Name = "btnSagaTek";
            this.btnSagaTek.Size = new System.Drawing.Size(42, 23);
            this.btnSagaTek.TabIndex = 1;
            this.btnSagaTek.Text = ">";
            this.btnSagaTek.UseVisualStyleBackColor = true;
            this.btnSagaTek.Click += new System.EventHandler(this.btnSagaTek_Click);
            // 
            // btnSagaCok
            // 
            this.btnSagaCok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagaCok.Location = new System.Drawing.Point(124, 41);
            this.btnSagaCok.Name = "btnSagaCok";
            this.btnSagaCok.Size = new System.Drawing.Size(42, 23);
            this.btnSagaCok.TabIndex = 1;
            this.btnSagaCok.Text = ">>";
            this.btnSagaCok.UseVisualStyleBackColor = true;
            this.btnSagaCok.Click += new System.EventHandler(this.btnSagaCok_Click);
            // 
            // btnSolaTek
            // 
            this.btnSolaTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolaTek.Location = new System.Drawing.Point(124, 70);
            this.btnSolaTek.Name = "btnSolaTek";
            this.btnSolaTek.Size = new System.Drawing.Size(42, 23);
            this.btnSolaTek.TabIndex = 1;
            this.btnSolaTek.Text = "<";
            this.btnSolaTek.UseVisualStyleBackColor = true;
            this.btnSolaTek.Click += new System.EventHandler(this.btnSolaTek_Click);
            // 
            // btnSolaCok
            // 
            this.btnSolaCok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolaCok.Location = new System.Drawing.Point(124, 99);
            this.btnSolaCok.Name = "btnSolaCok";
            this.btnSolaCok.Size = new System.Drawing.Size(42, 23);
            this.btnSolaCok.TabIndex = 1;
            this.btnSolaCok.Text = "<<";
            this.btnSolaCok.UseVisualStyleBackColor = true;
            this.btnSolaCok.Click += new System.EventHandler(this.btnSolaCok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSolaCok);
            this.Controls.Add(this.btnSolaTek);
            this.Controls.Add(this.btnSagaCok);
            this.Controls.Add(this.btnSagaTek);
            this.Controls.Add(this.lbSecilenler);
            this.Controls.Add(this.lbKullanicilar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKullanicilar;
        private System.Windows.Forms.ListBox lbSecilenler;
        private System.Windows.Forms.Button btnSagaTek;
        private System.Windows.Forms.Button btnSagaCok;
        private System.Windows.Forms.Button btnSolaTek;
        private System.Windows.Forms.Button btnSolaCok;
    }
}