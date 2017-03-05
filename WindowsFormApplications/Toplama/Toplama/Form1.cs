using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            //int Sayi1 = Convert.ToInt32(txtSayi1.Text);
            //int Sayi2 = Convert.ToInt32(txtSayi2.Text);

            //int Toplama = Sayi1 + Sayi2;
            //txtSonuc.Text = Convert.ToString(Toplama);

            //MessageBox.Show("Toplama işleminin sonucu= " + Toplama);
            //MessageBox.Show("Toplama= " + Convert.ToString((txtSayi1.Text + txtSayi2.Text)));

            if (txtSayi1.Text.Trim() != "" && txtSayi2.Text.Trim() != "")
                txtSonuc.Text = (Convert.ToInt32(txtSayi1.Text) + Convert.ToUInt32(txtSayi2.Text)).ToString();
            else
                MessageBox.Show("Sayıları girmelisiniz!");
            
        }
    }
}
