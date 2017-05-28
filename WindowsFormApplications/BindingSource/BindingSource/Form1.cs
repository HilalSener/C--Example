using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoMarketDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.videoMarketDataSet.Musteriler);
            //Konum();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //bs1.MoveFirst();
            bs1.Position = 0;
            //Konum();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //bs1.MovePrevious();
            bs1.Position -= 1;
            //Konum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //bs1.MoveNext();
            bs1.Position += 1;
            //Konum();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //bs1.MoveLast();
            bs1.Position = bs1.Count - 1;
            //Konum();
        }

        private void Konum()
        {
            lblKonum.Text = (bs1.Position + 1) + " / " + (bs1.Count);
        }

        private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            Konum();
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs1.AddNew();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cbxSilindi.Checked = true;
            cbxSilindi.Checked = false;
            bs1.EndEdit();
            this.musterilerTableAdapter.Update(videoMarketDataSet.Musteriler);
            btnSave.Enabled = false;
            MessageBox.Show("Müşteri kayıt edildi");
            Konum();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bs1.EndEdit();
            this.musterilerTableAdapter.Update(videoMarketDataSet.Musteriler);
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            MessageBox.Show("Müşteri bilgileri değiştirildi");
            Konum();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bs1.RemoveAt(bs1.Position);
                bs1.EndEdit();
            }
        }
    }
}
