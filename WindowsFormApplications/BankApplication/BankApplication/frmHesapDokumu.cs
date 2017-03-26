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

namespace BankApplication
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }

        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Left = 20;
            this.Top = 60;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text.Trim() != "")
            {
                HesapBilgileriGoster();
                HesapHareketleriGoster();
                ToplamlariGoster();
            }
            else
            {
                MessageBox.Show("Öncelikle hesap no girmelisiniz!");
                txtHesapNo.Focus();
            }
        }

        private void HesapBilgileriGoster()
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    txtAdi.Text = Degerler[3];
                    txtSoyadi.Text = Degerler[4];
                    txtTCKNo.Text = Degerler[5];
                    txtHesapTuru.Text = Degerler[7];
                    txtAcilisTarihi.Text = Degerler[2];
                    break;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        private void HesapHareketleriGoster()
        {
            lvHareketler.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunan = DosyaOku.ReadLine();
            int i = 0;
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    lvHareketler.Items.Add(Degerler[0]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[1]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[2]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[3]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        private void ToplamlariGoster()
        {
            double ToplamYatan = 0;
            double ToplamCekilen = 0;
            for(int i =0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text == "yatan")
                    ToplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                else 
                    ToplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
            }
            txtToplamYatan.Text = ToplamYatan.ToString();
            txtToplamCekilen.Text = ToplamCekilen.ToString();
            txtBakiye.Text = (ToplamYatan - ToplamCekilen).ToString();
        }
    }
}
