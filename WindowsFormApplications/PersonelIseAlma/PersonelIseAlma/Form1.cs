using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelIseAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            //gbAskerlik.Visible = false;
            gbAskerlik.Enabled = false;
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            //gbAskerlik.Visible = true;
            gbAskerlik.Enabled = true;
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            int Yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtTelefon.Text != "(   )    -  -")
            {
                //if (Yas < 20 || Yas > 35)
                //    MessageBox.Show("Yaş sebebi işe başvuru yapamazsınız!");
                //else if (cbEgitim.SelectedItem.ToString() == "Lise" || cbEgitim.SelectedItem.ToString() == "Doktora")
                //    MessageBox.Show("Eğitim durumu sebebiyle başvuru yapamazsınız!");
                //else if (cbxIngilizce.Checked != true)
                //    MessageBox.Show("Yabancı dil sebebiyle başvuru yapamazsınız!");
                //else if (cbxRusca.Checked != true && cbxArapca.Checked != true)
                //    MessageBox.Show("Yabancı dil sebebiyle başvuru yapamazsınız!");
                //else if (cbxYazilim.Checked != true || cbxMsOffice.Checked != true)
                //    MessageBox.Show("Bilgisayar bilgisi sebebiyle başvuru yapamasınız!");
                //else if (cbxVeritabani.Checked != true && cbxWebTasarim.Checked != true)
                //    MessageBox.Show("Bilgisayar bilgisi sebebiyle başvuru yapamazsınız!");
                //else if (rbErkek.Checked == true && rbYapilmadi.Checked == true)
                //    MessageBox.Show("Askerlik sebebiyle başvuru yapamazsınız!");
                //else
                //    MessageBox.Show("Sayın " + txtAd.Text + " " + txtSoyad.Text + " kriterleriniz uygundur, iş başvurunuz dikkate alınmıştır.");

                if ((Yas >= 20 || Yas <= 35) && (cbEgitim.SelectedItem.ToString() != "Lise" || cbEgitim.SelectedItem.ToString() != "Doktora") && cbxIngilizce.Checked == true && (cbxRusca.Checked || cbxArapca.Checked) && (cbxYazilim.Checked && cbxMsOffice.Checked) && (cbxVeritabani.Checked || cbxWebTasarim.Checked) && (rbKadin.Checked || (rbErkek.Checked && rbYapildi.Checked) || (rbErkek.Checked && rbTecilli.Checked)))
                {
                    MessageBox.Show("Sayın " + txtAd.Text + " " + txtSoyad.Text + " kriterleriniz uygundur, iş başvurunuz dikkate alınmıştır.");
                }
                else
                    MessageBox.Show("Kriterleriniz uygun değil, işe alınmadınız!");

            }
            else
                MessageBox.Show("İsim, soyad ve telefon bilgilerinizi giriniz!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEgitim.SelectedIndex = 0;
        }
    }
}
