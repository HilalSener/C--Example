using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Takimlar = new string[5];
            Takimlar[0] = "Fenerbahçe";
            Takimlar[1] = "Galatasaray";
            Takimlar[2] = "Beşiktaş";
            Takimlar[3] = "Tranzonspor";
            Takimlar[4] = "Bursaspor";

            //for (int i = 0; i <= Takimlar.Length - 1; i++)
            //    MessageBox.Show(Takimlar[i]);

            //foreach (string takim in Takimlar)
            //    MessageBox.Show(takim);


        }
    }
}
