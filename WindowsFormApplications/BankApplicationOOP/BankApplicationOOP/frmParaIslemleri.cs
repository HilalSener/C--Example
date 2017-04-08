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
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            lblIslemTarihi.Text = DateTime.Now.ToShortDateString();
            cbIslemTurleri.SelectedIndex = 1;
        }

        public void HesapBilgileriAl(string Id, string No)
        {
            lblHesapId.Text = Id;
            lblHesapNo.Text = No;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (cbIslemTurleri.SelectedItem.ToString() == "yatan" || Convert.ToDouble(txtTutar.Text) <= frmHesapDokumu.hesapBakiyesi)
            {
                if (txtTutar.Text.Trim() != "" && txtTutar.Text.Trim() != "0")
                {
                    cHesapHareketi hh = new cHesapHareketi();
                    hh.Id = Convert.ToInt32(lblHesapId.Text);
                    hh.HesapNo = lblHesapNo.Text;
                    hh.Tarih = lblIslemTarihi.Text;
                    hh.Tutar = Convert.ToDouble(txtTutar.Text);
                    hh.IslemTuru = cbIslemTurleri.SelectedItem.ToString();
                    bool Sonuc = hh.HesapHareketEkle(hh);
                    if (Sonuc)
                    {
                        MessageBox.Show("Hesap hareketi işlendi.");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("İşlem tutar bilgisini girmelisiniz!");
            }
            else
                MessageBox.Show("Hesap bakiyeniz yeterli değil!" + "\n Max: "+ frmHesapDokumu.hesapBakiyesi + " Yetersiz Bakiye");
            
        }
    }
}
