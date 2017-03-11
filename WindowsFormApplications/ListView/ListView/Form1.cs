using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetaylar.Items.Clear();
            lbModeller.Items.Clear();
            if (cbPhone.SelectedItem.ToString() == "Apple")
            {
                lbModeller.Items.Add("iPhone 6");
                lbModeller.Items.Add("iPhone 6S");
                lbModeller.Items.Add("iPhone 7");
            }
            else if (cbPhone.SelectedItem.ToString() == "Samsung")
            {
                lbModeller.Items.Add("Galaxy Note 5");
                lbModeller.Items.Add("Galaxy S7");
                lbModeller.Items.Add("Galaxy S7 Edge");
            }
            else if (cbPhone.SelectedItem.ToString() == "Nokia")
            {
                lbModeller.Items.Add("Luima 520");
                lbModeller.Items.Add("Luima 1120");
                lbModeller.Items.Add("Lumia 1320");
            }
        }

        private void lbModeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetaylar.Items.Clear();
            if(lbModeller.SelectedItem.ToString() == "iPhone 6")
            {
                lvDetaylar.Items.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "iPhone 6S")
            {
                lvDetaylar.Items.Add("1.6 Ghz");
                lvDetaylar.Items[0].SubItems.Add("32GB");
                lvDetaylar.Items[0].SubItems.Add("5,5 inc");
                lvDetaylar.Items[0].SubItems.Add("12 MP");
                lvDetaylar.Items[0].SubItems.Add("3000 TL");
            }
            else if(lbModeller.SelectedItem.ToString() == "Galaxy S7")
            {
                lvDetaylar.Items.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");
            }
        }
    }
}
