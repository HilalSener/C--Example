using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] Sayilar = {22, 12, 5, 33, 6, 18, 20, 45, 11};
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var sayi in Sayilar)
            {
                lbIlkHali.Items.Add(sayi);
            }

            //Array.Sort(Sayilar); //Diziyi küçükten büyüğe sıralar.
            //Array.Reverse(Sayilar); //Dizi elemanlarını tersten sıralar

            int Temp = 0;
            for (int i = 0; i < Sayilar.Length; i++)
            {
                for (int j = i + 1; j < Sayilar.Length; j++)
                {
                    if (Sayilar[j] < Sayilar[i])
                    {
                        Temp = Sayilar[i];
                        Sayilar[i] = Sayilar[j];
                        Sayilar[j] = Temp;
                    }
                }
            }

            foreach (var sayi in Sayilar)
            {
                lbSirali.Items.Add(sayi);
            }
        }
    }
}
