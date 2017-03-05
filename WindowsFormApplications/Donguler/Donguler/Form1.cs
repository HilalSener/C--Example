using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lbSayilar.Items.Add("Veri Tabanı Y.");
        }

        int Toplam;
        private void btnSayilar_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            for (int i=1; i<=10; i++)
            {
                lbSayilar.Items.Add(i);
                Toplam = Toplam + i;
            }
            txtToplam.Text = Toplam.ToString();
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            Toplam = 0;
            lbCiftSayilar.Items.Clear();
            for (int i=2; i<=10; i+=2)
            {
                lbCiftSayilar.Items.Add(i);
                Toplam = Toplam + i;
            }
            txtToplamCift.Text = Toplam.ToString();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            Toplam = 0;
            lbTekSayilar.Items.Clear();
            for (int i = 1; i <= 10; i += 2)
            {
                lbTekSayilar.Items.Add(i);
                Toplam = Toplam + i;
            }
            txtToplamTek.Text = Toplam.ToString();
        }
    }
}
