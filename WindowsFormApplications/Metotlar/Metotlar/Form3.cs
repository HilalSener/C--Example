using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int[] Sayilar = { 3, 7, 5, 4, 9 };
        int[] Notlar = { 50, 80, 40, 90, 70, 68 };
        string[] Ogrenciler = { "Ali", "Oya", "Kemal", "Sedat", "Neşe", "Derya"};
        private void Form3_Load(object sender, EventArgs e)
        {
            //foreach (int sayi in Sayilar)
            //{
            //    lbListe1.Items.Add(sayi);
            //}
            DiziGoster(Sayilar);
            DiziGoster(Notlar, lbListe2);
            DiziGoster(Ogrenciler, lbListe1);
        }

        private void DiziGoster(int[] Dizi)
        {
            lbListe1.Items.Clear();
            foreach (int sayi in Dizi)
            {
                lbListe1.Items.Add(sayi);
            }
        }

        private void DiziGoster(int[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            foreach (int sayi in Dizi)
            {
                lbListe1.Items.Add(sayi);
            }
        }

        private void DiziGoster(string[] Dizi, ListBox liste)
        {
            liste.Items.Clear();
            foreach(string ogrenci in Dizi)
            {
                liste.Items.Add(ogrenci);
            }
        }
    }
}
