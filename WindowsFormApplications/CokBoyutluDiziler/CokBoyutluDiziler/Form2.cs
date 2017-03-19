using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokBoyutluDiziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Oya", "Kemal", "Neşe", "Sedat", "Gamze" };
        //int[,] Notlar = new int[5, 2];
        int[,] Notlar = { { 40, 60 }, { 70, 80 }, { 60, 90 }, { 50, 60 }, { 40, 80 } };
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Ogrenciler.Length; i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);
                //lbOrtalama.Items.Add((Notlar[i, 0] + Notlar[i, 1]) / 2);
                int Toplam = 0;
                for (int j = 0; j < Notlar.GetLength(1); j++)
                {
                    Toplam += Notlar[i, j];
                }
                lbOrtalama.Items.Add((Notlar[i, 0] + Notlar[i, 1]) / Notlar.GetLength(1));
            }
        }
    }
}
