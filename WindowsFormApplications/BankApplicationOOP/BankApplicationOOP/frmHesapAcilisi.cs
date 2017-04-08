using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationOOP
{
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }

        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = 20;
            lblAcilisTarihi.Text = DateTime.Now.ToShortDateString(); //Kısa tarih
            cbHesapTurleri.SelectedIndex = 0;
            cHesap hesap = new cHesap();
            lblHesapId.Text = hesap.SonIDBul().ToString();
            lblHesapNo.Text = hesap.HesapNoOlustur();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKNo.Text.Trim() != "")
            {
                cHesap h = new cHesap();
                h.Id = Convert.ToInt32(lblHesapId.Text);
                h.HesapNo = lblHesapNo.Text;
                h.AcilisTarihi = lblAcilisTarihi.Text;
                h.Ad = txtAdi.Text;
                h.Soyad = txtSoyadi.Text;
                h.Tckno = txtTCKNo.Text;
                h.Bakiye = Convert.ToDouble(txtBakiye.Text);
                h.HesapTuru = cbHesapTurleri.SelectedItem.ToString();
                bool Sonuc = h.YeniHesapAc(h); 
                //bool Sonuc = h.YeniHesapAc(Convert.ToInt32(lblHesapId.Text), lblHesapNo.Text, lblAcilisTarihi.Text, txtAdi.Text, txtSoyadi.Text, txtTCKNo.Text, Convert.ToDouble(txtBakiye.Text), cbHesapTurleri.SelectedItem.ToString());

                if(Sonuc)
                {
                    cHesapHareketi hh = new cHesapHareketi();
                    hh.Id = Convert.ToInt32(lblHesapId.Text);
                    hh.HesapNo = lblHesapNo.Text;
                    hh.Tarih = lblAcilisTarihi.Text;
                    hh.Tutar = Convert.ToDouble(txtBakiye.Text);
                    hh.IslemTuru = "yatan";
                    Sonuc = hh.HesapHareketEkle(hh);
                    //Sonuc = hh.HesapHareketEkle(Convert.ToInt32(lblHesapId.Text), lblHesapNo.Text, lblAcilisTarihi.Text, Convert.ToDouble(txtBakiye.Text), "yatan");
                }

                MessageBox.Show("Yeni hesap bilgileri kayıt edildi.");
                Temizle();
                lblHesapId.Text = h.SonIDBul().ToString();
                lblHesapNo.Text = h.HesapNoOlustur();
            }
            else
            {
                MessageBox.Show("Müşteri Ad, Soyad ve TC Kimlik bilgileri eksiksiz girilmelidir!", "Dikkat! Eksik bilgi!");
                txtAdi.Focus();
            }
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtBakiye.Clear();
            txtAdi.Focus();
        }
    }
}
