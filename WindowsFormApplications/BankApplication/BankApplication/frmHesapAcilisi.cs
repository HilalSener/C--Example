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
            SonIDBul();
        }

        private void SonIDBul()
        {
            StreamWriter DosyaOluştur = new StreamWriter("HesapKartlari.txt", true);

            DosyaOluştur.Close();

            string[] Degerler = new string[8];
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            if (okunan == null)
                lblHesapId.Text = "1";
            else
                while (okunan != null)
                {
                    //string[] Degerler = okunan.Split(';');
                    //lblHesapId.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString();
                    Degerler = okunan.Split(';');
                    okunan = DosyaOku.ReadLine();
                }
            lblHesapId.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString();
            DosyaOku.Close();
        }
    }
}
