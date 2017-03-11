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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetaylar.Items.Clear();
            if(cbMarkalar.SelectedItem.ToString() == "Apple")
            {
                lvDetaylar.Items.Add("iPhone 6");
                lvDetaylar.Items[0].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");

                lvDetaylar.Items.Add("iPhone6S");
                lvDetaylar.Items[1].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[1].SubItems.Add("32GB");
                lvDetaylar.Items[1].SubItems.Add("5,2 inc");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("2700 TL");

                lvDetaylar.Items.Add("iPhone 7");
                lvDetaylar.Items[2].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[2].SubItems.Add("32GB");
                lvDetaylar.Items[2].SubItems.Add("6 inc");
                lvDetaylar.Items[2].SubItems.Add("15 MP");
                lvDetaylar.Items[2].SubItems.Add("3000 TL");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lvDetaylar.Items.Add("Galaxy Note5");
                lvDetaylar.Items[0].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");

                lvDetaylar.Items.Add("Galaxy S7");
                lvDetaylar.Items[1].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[1].SubItems.Add("32GB");
                lvDetaylar.Items[1].SubItems.Add("5,2 inc");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("2700 TL");

                lvDetaylar.Items.Add("Galaxy S7 Edge");
                lvDetaylar.Items[2].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[2].SubItems.Add("32GB");
                lvDetaylar.Items[2].SubItems.Add("6 inc");
                lvDetaylar.Items[2].SubItems.Add("15 MP");
                lvDetaylar.Items[2].SubItems.Add("3000 TL");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Nokia")
            {
                lvDetaylar.Items.Add("Lumia 520");
                lvDetaylar.Items[0].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");

                lvDetaylar.Items.Add("Lumia 620");
                lvDetaylar.Items[1].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[1].SubItems.Add("32GB");
                lvDetaylar.Items[1].SubItems.Add("5,2 inc");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("2700 TL");

                lvDetaylar.Items.Add("Lumia 1020");
                lvDetaylar.Items[2].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[2].SubItems.Add("32GB");
                lvDetaylar.Items[2].SubItems.Add("6 inc");
                lvDetaylar.Items[2].SubItems.Add("15 MP");
                lvDetaylar.Items[2].SubItems.Add("3000 TL");
            }
        }
    }
}
