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
                h.YeniHesapAc(Convert.ToInt32(lblHesapId.Text), lblHesapNo.Text, lblAcilisTarihi.Text, txtAdi.Text, txtSoyadi.Text, txtTCKNo.Text, Convert.ToDouble(txtBakiye.Text), cbHesapTurleri.SelectedItem.ToString());

                //StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
                //HareketYaz.WriteLine(lblHesapId.Text + ";" + lblHesapNo.Text + ";" + lblAcilisTarihi.Text + ";" + txtBakiye.Text + ";" + "yatan");
                //HareketYaz.Close();

                MessageBox.Show("Yeni hesap bilgileri kayıt edildi.");
                Temizle();
                cHesap hesap = new cHesap();
                hesap.SonIDBul();
                hesap.HesapNoOlustur();
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
