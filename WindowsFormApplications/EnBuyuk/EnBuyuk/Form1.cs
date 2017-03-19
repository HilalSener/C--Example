using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Notlar = { 30, 50, 80, 60, 70, 20, 90, 40 };
        int max = 0;
        int min;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Notlar.Max().ToString());
            //MessageBox.Show(Notlar.Min().ToString());

            //max = Notlar[0];
            for (int i = 0; i < Notlar.Length; i++)
            {
                if(Notlar[i] >= max)
                {
                    max = Notlar[i];
                }
            }
            txtEnBuyuk.Text = max.ToString();

            min = Notlar[0];
            for (int j = 0; j < Notlar.Length; j++)
            {
                if(Notlar[j] <= min)
                {
                    min = Notlar[j];
                }
            }
            txtEnKucuk.Text = min.ToString();
        }
    }
}
