using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingMusteriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource bs1;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBagla();
            Konum();
        }

        private void Konum()
        {
            lblKonum.Text = (bs1.Position + 1) + " / " + (bs1.Count);
        }

        private void DataBagla()
        {
            bs1 = new BindingSource();
            cMusteri m = new cMusteri();
            ds = m.GetMusteriler();
            bs1.DataSource = ds.Tables["Musteriler"];

            txtAdi.DataBindings.Add("Text", bs1, "MusteriAd");
            txtSoyadi.DataBindings.Add("Text", bs1, "MusteriSoyad");
            txtTelefon.DataBindings.Add("Text", bs1, "Telefon");
            txtAdres.DataBindings.Add("Text", bs1, "Adres");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //bs1.MoveFirst();
            bs1.Position = 0;
            Konum();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //bs1.MovePrevious();
            bs1.Position -= 1;
            Konum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //bs1.MoveNext();
            bs1.Position += 1;
            Konum();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //bs1.MoveLast();
            bs1.Position = bs1.Count - 1;
            Konum();
        }
    }
}
