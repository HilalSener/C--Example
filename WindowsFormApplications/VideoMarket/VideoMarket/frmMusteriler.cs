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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterileriGoster(lvMusteriler);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            //Listview' ı girilen müşteri adına göre yenile
            if(txtArama.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                m.MusteriBilgileriniGoster(lvMusteriler, txtArama.Text);
            }
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            cMusteri musteri = new cMusteri();
            musteri = musteri.GetSelectedMusteriDetail(lvMusteriler);
            txtMusteriNo.Text = musteri.MusteriNo.ToString();
            txtAdi.Text = musteri.MusteriAd;
            txtSoyadi.Text = musteri.MusteriSoyad;
            txtTelefon.Text = musteri.Telefon;
            txtAdres.Text = musteri.Adres;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "")
            {
                cMusteri mk = new cMusteri();
                if (mk.MusteriKontrol(txtAdi.Text, txtSoyadi.Text))
                {
                    MessageBox.Show("Bu müşteri zaten kayıtlı!", "Önceden kayıt edilmiş!");
                    txtAdi.Focus();
                }
                else
                {
                    mk.MusteriAd = txtAdi.Text;
                    mk.MusteriSoyad = txtSoyadi.Text;
                    mk.Telefon = txtTelefon.Text;
                    mk.Adres = txtAdres.Text;
                    bool Sonuc = mk.MusteriEkle(mk);
                    if (Sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri kayıt edildi.", "Kayıt yapıldı.");
                        Temizle();
                        btnKaydet.Enabled = false;
                        mk.MusterileriGoster(lvMusteriler);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi", "Dikkat! Başarısız kayıt!");
                        txtAdi.Focus();
                    }
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void Temizle()
        {
            //txtMusteriNo.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            //txtArama.Clear();
            txtAdi.Focus();
        }
    }
}
