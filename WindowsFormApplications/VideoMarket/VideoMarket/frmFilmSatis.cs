using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarket
{
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }
       
        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToString();
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriNo.Text = cGenel.musteriNo.ToString();
            txtMusteri.Text = cGenel.musteri.ToString();
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtFilmNo.Text = cGenel.filmNo.ToString();
            txtFilm.Text = cGenel.film;
            txtBirimFiyat.Text = cGenel.fiyat.ToString();
            txtStok.Text = cGenel.miktar.ToString();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";

            }
            if (string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                txtBirimFiyat.Text = "0";

            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, 1);
            }
            if (string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                txtBirimFiyat.Text = "0";
                txtBirimFiyat.Select(0, 1);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }
        
        private void txtBirimFiyat_MouseDown(object sender, MouseEventArgs e)
        {
            txtBirimFiyat.Select(0, txtBirimFiyat.Text.Length);
        }

        private void txtAdet_MouseDown(object sender, MouseEventArgs e)
        {
            txtAdet.Select(0, txtAdet.Text.Length);
        }

        private void txtAdet_Enter(object sender, EventArgs e)
        {
            txtAdet.Select(0, txtAdet.Text.Length);
        }

        private void txtBirimFiyat_Enter(object sender, EventArgs e)
        {
            txtBirimFiyat.Select(0, txtBirimFiyat.Text.Length);
        }
    }
}
