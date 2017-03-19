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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Oya", "Kemal", "Neşe", "Sedat", "Gamze" };
        //int[,] Notlar = new int[5, 2];
        int[,] Notlar = { { 40, 60 }, { 70, 80 }, { 60, 90 }, { 50, 60 }, { 40, 80 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Notlar[0,0].ToString()); //İlk öğrencinin ilk notu 0.Satır 0.Sütun
            //MessageBox.Show(Notlar.Length.ToString()); //Dizinin eleman sayısını verir. Ancak bu eleman sayısı //iki boyutlu dizelerde satır x sütun şeklindedir.
            //MessageBox.Show(Ogrenciler.Rank.ToString()); //Dizinin boyutunu verir. Yani tek boyutlu dizi -> 1
            //MessageBox.Show(Notlar.Rank.ToString()); //Dizinin boyutunu verir. Yani tek boyutlu dizi -> 2
            //MessageBox.Show(Notlar.GetLength(0).ToString()); //2 boyutlu dizinin satır sayısını verir.
            //MessageBox.Show(Notlar.GetLength(1).ToString()); //2 boyutlu dizinin sütun sayısını verir.
            
            for (int i = 0; i <= Ogrenciler.Length - 1; i++)
            {
                lbOgrenciler.Items.Add(Ogrenciler[i]);
                lbNot1.Items.Add(Notlar[i, 0]);
                lbNot2.Items.Add(Notlar[i, 1]);

            }
        }

        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNot1.SelectedIndex = lbOgrenciler.SelectedIndex;
            lbNot2.SelectedIndex = lbOgrenciler.SelectedIndex;
        }

        private void lbNot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNot1.SelectedIndex;
            lbNot2.SelectedIndex = lbNot1.SelectedIndex;
        }

        private void lbNot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOgrenciler.SelectedIndex = lbNot2.SelectedIndex;
            lbNot1.SelectedIndex = lbNot2.SelectedIndex;
        }
    }
}
