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

        //Radio butonlar ile seviyelendirme yapılacak!
        //Tahmin istenilen sayı aralığından büyükse uyarı çıkar!
        //Seviyeler ile tahmin sayısını azalt veya artır!
        //Ekranda ne kadar hakkı kaldı göster!

        int TutulanSayi;
        int Tahmin;
        int Sayac;
        int Hak = 10;
        Random rnd = new Random();
        private void btnDene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Trim() != "")
            {
                Sayac++;
                Tahmin = Convert.ToInt32(txtTahmin.Text);
                if (Tahmin == TutulanSayi)
                {
                    MessageBox.Show("Tebrikler, " + Sayac + " defa da bildiniz :)");
                    Sayac = 0;
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
                txtTahmin.Focus();
            }
            else
                MessageBox.Show("Bir tahminde bulunmalısınız!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(1,51);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            Sayac = 0;
            TutulanSayi = rnd.Next(1, 51);
            txtTahmin.Focus();
        }
    }
}