using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Telefon tel1 = new Telefon();
            tel1.Marka = "Samsung";
            tel1.Model = "Galaxy S7";
            tel1.Fiyat = 3000;
            MessageBox.Show(tel1.Marka + ","  + tel1.Model + " Fiyatı :" + tel1.Fiyat);
        }
    }

    class Telefon
    {
        public string Marka;
        public string Model;
        public string Islemci;
        public string Hafiza;
        public string Kamera;
        public string Ekran;
        public double Fiyat;
    }
}
