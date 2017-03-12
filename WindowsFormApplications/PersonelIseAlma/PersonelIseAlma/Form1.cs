using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelIseAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Visible = true;
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            if (cbEgitim.SelectedItem.ToString() != "" && cbEgitim.SelectedItem.ToString() != "Lise")
            {

            }
            else
                MessageBox.Show("Eğitim durumu sebebiyle başvuru yapamazsınız!");

            if (rbYapilmadi.Checked != true)
            {

            }
            else
                MessageBox.Show("Askerlik sebebi ile başvuru yapamazsınız!");
        }
    }
}
