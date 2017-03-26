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
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            //lblHesapId.Text = frmHesapDokumu.HesapId; //static değişkenler doğrudan class.degisken şekline //çağırılabilirler.
            //lblHesapNo.Text = frmHesapDokumu.HesapNo;
            
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
            if (txtTutar.Text.Trim() != "" && txtTutar.Text.Trim() != "0")
            {
                StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
                HareketYaz.WriteLine(lblHesapId.Text + ";" + lblHesapNo.Text + ";" + lblIslemTarihi.Text + ";" + txtTutar.Text + ";" + cbIslemTurleri.SelectedItem.ToString());
                HareketYaz.Close();
                this.Close();
            }
            else
                MessageBox.Show("İşlem tutar bilgisini girmelisiniz!");
        }
    }
}
