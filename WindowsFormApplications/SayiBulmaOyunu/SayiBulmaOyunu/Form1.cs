using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int TutulanSayi = 20;
        int Tahmin;
        private void btnDene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Trim() != "")
            {
                Tahmin = Convert.ToInt32(txtTahmin.Text);
                if (Tahmin == TutulanSayi)
                    MessageBox.Show("Tebrikler tahminin doğru :)");
                else
                    MessageBox.Show("Tutmadı tekrar dene ;)");
            }
            else
                MessageBox.Show("Bir tahminde bulunmalısınız!");
        }
    }
}
