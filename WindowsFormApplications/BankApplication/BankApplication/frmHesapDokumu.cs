using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class frmHesapDokumu : Form
    {
        public static string HesapNo;
        public static string HesapId;
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
            //txtToplamYatan.Text = ToplamYatan.ToString();
            //txtToplamCekilen.Text = ToplamCekilen.ToString();
            //txtBakiye.Text = (ToplamYatan - ToplamCekilen).ToString();
            txtToplamYatan.Text = string.Format("{0:C}", ToplamYatan);
            txtToplamCekilen.Text = string.Format("{0:C}", ToplamCekilen);
            txtBakiye.Text = string.Format("{0:C}", (ToplamYatan - ToplamCekilen));
        }

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            frmParaIslemleri frm = new frmParaIslemleri();
            //frm.lblHesapId.Text = lvHareketler.Items[0].SubItems[0].Text;
            //frm.lblHesapNo.Text = lvHareketler.Items[0].SubItems[1].Text;
            //HesapId = lvHareketler.Items[0].SubItems[0].Text;
            //HesapNo = lvHareketler.Items[0].SubItems[1].Text;

            frm.HesapBilgileriAl(lvHareketler.Items[0].SubItems[0].Text, txtHesapNo.Text);
            frm.ShowDialog();
            HesapHareketleriGoster();
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
            int y = 0;
            for (int i = k; i < lvHareketler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[0].Text, fntDetay, sb, 105, 250 + y * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[1].Text, fntDetay, sb, 180, 250 + y * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[2].Text, fntDetay, sb, 310, 250 + y * 30, fmt);
                fmt.Alignment = StringAlignment.Far;                                                   
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[3].Text, fntDetay, sb, 505, 250 + y * 30, fmt);
                fmt.Alignment = StringAlignment.Near;                                                  
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[4].Text, fntDetay, sb, 605, 250 + y * 30, fmt);
                k++;
                y++;
                if (i > 0 && i % 25 <= 0)
                {
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            e.Graphics.DrawString("____________________________________________________", fntBaslik, sb, 100, 230 + y * 30);
            e.Graphics.DrawString("Toplam Yatan", fntDetay, sb, 310, 270 + y * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamYatan.Text, fntDetay, sb, 490, 270 + y * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Toplam Çekilen", fntDetay, sb, 310, 300 + y * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamCekilen.Text, fntDetay, sb, 490, 300 + y* 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Bakiye", fntDetay, sb, 310, 330 + y * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtBakiye.Text, fntDetay, sb, 490, 330 + y * 30, fmt);
            k = 0;
        }
    }
}
