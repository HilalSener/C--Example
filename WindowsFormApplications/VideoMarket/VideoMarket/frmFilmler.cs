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
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void frmFilmler_Load(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(cbFilmTuru);
        }

        private void cbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cFilmTuru ft = cbFilmTuru.SelectedItem as cFilmTuru;  //Dönüştüremezse hata vermez. Bunun gibi bir nesne oluşturur ya da oluşturamazsa yeni bir nesne oluşturur.
            cFilmTuru ft = (cFilmTuru)cbFilmTuru.SelectedItem;
            txtFilmTuru.Text = ft.TurAd;
            txtTurNo.Text = ft.FilmTurNo.ToString();
            //txtFilmTuru.Text = cbFilmTuru.SelectedItem.ToString();
            //cFilmTuru ft = new cFilmTuru();
            //txtTurNo.Text = Convert.ToString(ft.FilmTurNoGetirByTurAdi(txtFilmTuru.Text));
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
            txtFilmAdi.Clear();
            txtOyuncular.Clear();
            txtFiyat.Text = "0";
            txtMiktar.Text = "1";
            txtOzet.Clear();
            txtYonetmen.Clear();
            txtFilmTuru.Clear();
            txtFilmAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtFilmTuru.Text.Trim() != "" && txtOyuncular.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if (f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text))
                {
                    MessageBox.Show("Bu müşteri zaten kayıtlı!", "Önceden kayıt edilmiş!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;

                    try
                    {
                        f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    }
                    catch (FormatException ex)
                    {
                        f.Miktar = 1;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lütfen miktar değerini kontrol edin", "Dikkat! Sorun var!");
                    }

                    try
                    {
                        f.Fiyat = Convert.ToDouble(txtFiyat.Text);
                    }
                    catch (Exception ex)
                    {
                        f.Fiyat = 0;
                    }

                    bool Sonuc = f.FilmEkle(f);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film bilgileri kayıt edildi.", "Kayıt yapıldı.");
                        Temizle();
                        btnKaydet.Enabled = false;
                        f.FilmleriGoster(lvFilmler);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi", "Dikkat! Başarısız kayıt!");
                        txtFilmAdi.Focus();
                    }
                }
            }
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            txtFilmNo.Text = lvFilmler.SelectedItems[0].SubItems[0].Text;
            txtFilmAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
            txtTurNo.Text = lvFilmler.SelectedItems[0].SubItems[2].Text;
            txtFilmTuru.Text = lvFilmler.SelectedItems[0].SubItems[3].Text;
            txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
            txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
            txtOzet.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
            txtFiyat.Text = lvFilmler.SelectedItems[0].SubItems[8].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtFilmTuru.Text.Trim() != "" && txtOyuncular.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if (f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text, Convert.ToInt32(txtFilmNo.Text)))
                {
                    MessageBox.Show("Bu müşteri zaten kayıtlı!", "Önceden kayıt edilmiş!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    try
                    {
                        f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    }
                    catch (FormatException ex)
                    {
                        f.Miktar = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lütfen miktar değerini kontrol edin", "Dikkat! Sorun var!");
                    }

                    try
                    {
                        f.Fiyat = Convert.ToDouble(txtFiyat.Text);
                    }
                    catch (Exception ex)
                    {
                        f.Fiyat = 0;
                    }

                    bool Sonuc = f.FilmGuncelle(f);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film bilgileri değiştirildi.", "Güncelleme yapıldı.");
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        f.FilmleriGoster(lvFilmler);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi", "Dikkat! Başarısız kayıt!");
                        txtFilmAdi.Focus();
                    }
                }
                
        }
            else
                MessageBox.Show("Film Adı, YÖnetmen, Oyuncular ve Film Türünü girmelisiniz!", "Dikkat! Eksik Bilgi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "Emin misini?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilm f = new cFilm();
                if (f.FilmSil(Convert.ToInt32(txtFilmNo.Text)))
                {
                    MessageBox.Show("Film bilgileri silindi.", "Silme yapıldı!");
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    f.FilmleriGoster(lvFilmler);
                }
                else
                {
                    MessageBox.Show("Silme gerçekleşmedi", "Dikkat, sorun var!");
                    txtFilmAdi.Focus();
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
             cFilm f = new cFilm();
             f.FilmleriGosterByAdaGore(lvFilmler, txtArama.Text);
        }
    }
}
