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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] Ogrenciler = { "Oya", "Neşe", "Hakan", "Veli", "Ayşe", "Hüseyin" };
        private void btnGetir_Click(object sender, EventArgs e)
        {
            lbOgrenciler.Items.Clear();

            //for (int i = 0; i <= Ogrenciler.Length - 1; i++)
            //    lbOgrenciler.Items.Add(Ogrenciler[i]);

            foreach (string ogrenci in Ogrenciler)
                lbOgrenciler.Items.Add(ogrenci);
        }
    }
}
