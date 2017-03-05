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

        int TutulanSayi;
        int Tahmin;
        int sayac;
        Random rnd = new Random();
        private void btnDene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Trim() != "")
            {
                sayac++;
                Tahmin = Convert.ToInt32(txtTahmin.Text);
                if (Tahmin == TutulanSayi)
                {
                    MessageBox.Show("Tebrikler, " + sayac + " defa da bildiniz :)");
                    sayac = 0;
                    TutulanSayi = rnd.Next(1, 51); //Her yeni oyuna geçildiğinde rastgele bir sayı tutulacak.
                }
                else if (Tahmin < TutulanSayi)
                {
                    MessageBox.Show("Tahmininiz küçük :(");
                }
                else if (Tahmin > TutulanSayi)
                {
                    MessageBox.Show("Tahmininiz büyük :(");
                }
                txtTahmin.Clear();
            }
            else
                MessageBox.Show("Bir tahminde bulunmalısınız!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(1,51);
        }
    }
}
