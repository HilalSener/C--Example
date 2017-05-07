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
    public partial class frmFilmTurleri : Form
    {
        public frmFilmTurleri()
        {
            InitializeComponent();
        }

        private void frmFilmTurleri_Load(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(lvFilmTurleri);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void Temizle()
        {
            txtAciklama.Clear();
            txtFilmTuru.Clear();
            txtFilmTuru.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                if (ft.FilmTuruKontrol(txtFilmTuru.Text))
                {
                    MessageBox.Show("Bu film türü zaten kayıtlı!", "Önceden kayıt edilmiş!");
                    txtFilmTuru.Focus();
                }
                else
                {
                    bool Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film türü kayıt edildi.", "Kayıt tamamlandı!");
                        Temizle();
                        btnKaydet.Enabled = false;
                        ft.FilmTurleriGoster(lvFilmTurleri);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi", "Dikkat! Başarısız kayıt!");
                        txtFilmTuru.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Film Türü Girmelisiniz!", "Dikkat! Eksik Bilgi!");
            }
        }

        private void lvFilmTurleri_DoubleClick(object sender, EventArgs e)
        {
            txtTurNo.Text = lvFilmTurleri.SelectedItems[0].SubItems[0].Text;
            txtFilmTuru.Text = lvFilmTurleri.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTurleri.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                if (ft.FilmTuruKontrol(txtFilmTuru.Text, Convert.ToInt32(txtTurNo.Text)))
                {
                    MessageBox.Show("Bu film türü zaten kayıtlı!", "Önceden kayıt edilmiş!");
                    txtFilmTuru.Focus();
                }
                else
                {
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    ft.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    bool Sonuc = ft.FilmTuruGuncelle(ft);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film türü bilgileri değiştirildi.", "Güncelleme yapıldı!");
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnSil.Enabled = false;
                        ft.FilmTurleriGoster(lvFilmTurleri);
                    }
                    else
                    {
                        MessageBox.Show("Değişiklik yapılamadı", "Dikkat! Başarısız kayıt!");
                        txtFilmTuru.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Film Türü Girmelisiniz!", "Dikkat! Eksik Bilgi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "Emin misini?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                if (ft.FilmTuruSil(Convert.ToInt32(txtTurNo.Text)))
                {
                    MessageBox.Show("Film türü bilgileri silindi.", "Silme yapıldı!");
                    Temizle();
                    btnKaydet.Enabled = false;
                    btnSil.Enabled = false;
                    ft.FilmTurleriGoster(lvFilmTurleri);
                }
                else
                {
                    MessageBox.Show("Silme gerçekleşmedi", "Dikkat, sorun var!");
                    txtFilmTuru.Focus();
                }
            }
        }
    }
}
