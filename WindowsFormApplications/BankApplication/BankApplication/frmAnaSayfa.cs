using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            //this.Close(); //Aktif formu kapatır.
            Application.Exit(); //Tüm uygulamayı sonlandırır.
        }

        private void mitmHesapAcilisi_Click_1(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new frmHesapAcilisi();
            frm.ShowDialog(); // Açık fork kapatılmadan diğerinin açılması izin vermez.
        }
    }
}
