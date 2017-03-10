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
            if (rbKolay.Checked == true)
            {
                Hak = 10;
                label3.Text = "";
            }
        }

        //Radio butonlar ile seviyelendirme yapılacak!
        //Tahmin istenilen sayı aralığından büyükse uyarı çıkar!
        //Seviyeler ile tahmin sayısını azalt veya artır!
        //Ekranda ne kadar hakkı kaldı göster!
        //Kolay=10, Orta=7, Zor=3 tahmin sayısı
        
        int TutulanSayi;
        int Tahmin;
        int Sayac;
        int Hak;
        Random rnd = new Random();
        private void btnDene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Trim() != "")
            {
                Sayac++;
                Hak--;
                Tahmin = Convert.ToInt32(txtTahmin.Text);
                if (Tahmin == TutulanSayi)
                {
                    MessageBox.Show("Tebrikler, " + Sayac + " defa da bildiniz :)");
                    Sayac = 0;
                    TutulanSayi = rnd.Next(1, 51); //Her yeni oyuna geçildiğinde rastgele bir sayı tutulacak.
                    if (rbKolay.Checked == true)
                    {
                        Hak = 10;
                        label3.Text = "";
                    }
                    else if (rbOrta.Checked == true)
                    {
                        Hak = 7;
                        label3.Text = "";
                    }
                    else if (rbZor.Checked == true)
                    {
                        Hak = 3;
                        label3.Text = "";
                    }
                }
                else if (Tahmin < TutulanSayi)
                {
                    MessageBox.Show("Tahmininiz küçük :(");
                    label3.Text = Hak + " tane hakkınız kaldı!";
                }
                else if (Tahmin > TutulanSayi)
                {
                    if (Tahmin <= 50)
                    {
                        MessageBox.Show("Tahmininiz büyük :(");
                        label3.Text = Hak + " tane hakkınız kaldı!";
                    }
                    else
                    {
                        MessageBox.Show("1 - 50 arasında bir tahminde bulununuz!");
                        Hak += 1;
                    }
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
            label3.Text = "";
            TutulanSayi = rnd.Next(1, 51);
            txtTahmin.Focus();
        }

        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrta.Checked == true)
            {
                Hak = 7;
                label3.Text = "";
            }
        }

        private void rbZor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZor.Checked == true)
            {
                Hak = 3;
                label3.Text = "";
            }
        }

        private void rbKolay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKolay.Checked == true)
            {
                Hak = 10;
                label3.Text = "";
            }
        }
    }
}