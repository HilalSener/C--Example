using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piSayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const float Pi = 3.14f;
        float r;
        private void btnDaireninAlani_Click(object sender, EventArgs e)
        {
            //Pi = 3.143423442f; constrant(sabit) olarak tanımlananan değerler program içerisinde değiştirilemezler.
            if(txtYariCap.Text.Trim() != "")
            {
                r = Convert.ToSingle(txtYariCap.Text);
                float Alani = Pi * r * r;
                MessageBox.Show("Alanı= " + Alani);
            }
            else
                MessageBox.Show("Yarı çapı girmelisiniz!");
        }

        private void btnDaireninCevresi_Click(object sender, EventArgs e)
        {
            if (txtYariCap.Text.Trim() != "")
            {
                r = Convert.ToSingle(txtYariCap.Text);
                float Cevresi = 2 * Pi * r;
                MessageBox.Show("Çevresi= " + Cevresi);
            }
            else
                MessageBox.Show("Yarı çapı girmelisiniz!");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            r = Convert.ToSingle(txtYariCap.Text);
            if (rbCevre.Checked == true)
            {
                float Cevresi = 2 * Pi * r;
                MessageBox.Show("Çevresi= " + Cevresi);
            }
            else
            {
                float Alani = Pi * r * r;
                MessageBox.Show("Alanı= " + Alani);
            }

        }
    }
}