using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace BankApplicationOOP
{
    public partial class frmHesapDokumu : Form
    {
        public static double hesapBakiyesi = 0;
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
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
                cHesap hes = new cHesap();
                //hes.HesapBilgileriGoster(txtHesapNo.Text, txtAdi, txtSoyadi, txtTCKNo, txtHesapTuru, txtAcilisTarihi);
                hes = hes.HesapBilgileriGoster(txtHesapNo.Text);
                txtAdi.Text = hes.Ad;
                txtSoyadi.Text = hes.Soyad;
                txtTCKNo.Text = hes.Tckno;
                txtHesapTuru.Text = hes.HesapTuru;
                txtAcilisTarihi.Text = hes.AcilisTarihi;
                cHesapHareketi hh = new cHesapHareketi();
                hh.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);
                ToplamlariGoster();
            }
            else
            {
                MessageBox.Show("Öncelikle hesap no girmelisiniz!");
                txtHesapNo.Focus();
            }
        }

        private void ToplamlariGoster()
        {
            double ToplamYatan = 0;
            double ToplamCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
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

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            frmParaIslemleri frm = new frmParaIslemleri();
            frm.HesapBilgileriAl(lvHareketler.Items[0].SubItems[0].Text, txtHesapNo.Text);
            hesapBakiyesi = Convert.ToDouble(txtBakiye.Text);
            frm.ShowDialog();
            cHesapHareketi hh = new cHesapHareketi();
            hh.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);
            ToplamlariGoster();
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            ppdHareketler.ShowDialog();
        }

        int k = 0;
        private void pdocHareketler_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            e.Graphics.DrawString("Sn. " + txtAdi.Text + " " + txtSoyadi.Text, fntBaslik, sb, 100, 100);
            e.Graphics.DrawString("Hesap Hareketleri", fntBaslik, sb, 320, 150);
            e.Graphics.DrawString("    ID     HesapNo     İşlemTarihi     İşlemTutarı     İşlemTürü   ", fntBaslik, sb, 100, 200);
            e.Graphics.DrawString("____________________________________________________", fntBaslik, sb, 100, 210);
            for (int i = k; i < lvHareketler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[0].Text, fntDetay, sb, 105, 250 + i * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[1].Text, fntDetay, sb, 180, 250 + i * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[2].Text, fntDetay, sb, 310, 250 + i * 30, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[3].Text, fntDetay, sb, 505, 250 + i * 30, fmt);
                fmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[4].Text, fntDetay, sb, 605, 250 + i * 30, fmt);
                if (k == 25 && k % 25 <= 25)
                {
                    e.HasMorePages = true;
                    continue;
                }
                else
                {
                    e.HasMorePages = false;
                    k++;
                }
            }
            e.Graphics.DrawString("____________________________________________________", fntBaslik, sb, 100, 230 + lvHareketler.Items.Count * 30);
            e.Graphics.DrawString("Toplam Yatan", fntDetay, sb, 310, 270 + lvHareketler.Items.Count * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamYatan.Text, fntDetay, sb, 490, 270 + lvHareketler.Items.Count * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Toplam Çekilen", fntDetay, sb, 310, 300 + lvHareketler.Items.Count * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamCekilen.Text, fntDetay, sb, 490, 300 + lvHareketler.Items.Count * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Bakiye", fntDetay, sb, 310, 330 + lvHareketler.Items.Count * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtBakiye.Text, fntDetay, sb, 490, 330 + lvHareketler.Items.Count * 30, fmt);
        }
    }
}
