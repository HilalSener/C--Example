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
                lvDetaylar.Items.Add("iPhone 6", 0);
                lvDetaylar.Items[0].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");

                lvDetaylar.Items.Add("iPhone6S",1);
                lvDetaylar.Items[1].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[1].SubItems.Add("32GB");
                lvDetaylar.Items[1].SubItems.Add("5,2 inc");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("2700 TL");

                lvDetaylar.Items.Add("iPhone 7",2);
                lvDetaylar.Items[2].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[2].SubItems.Add("32GB");
                lvDetaylar.Items[2].SubItems.Add("6 inc");
                lvDetaylar.Items[2].SubItems.Add("15 MP");
                lvDetaylar.Items[2].SubItems.Add("3000 TL");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lvDetaylar.Items.Add("Galaxy Note5",0);
                lvDetaylar.Items[0].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[0].SubItems.Add("64GB");
                lvDetaylar.Items[0].SubItems.Add("5 inc");
                lvDetaylar.Items[0].SubItems.Add("8 MP");
                lvDetaylar.Items[0].SubItems.Add("2500 TL");

                lvDetaylar.Items.Add("Galaxy S7",1);
                lvDetaylar.Items[1].SubItems.Add("1.4 Ghz");
                lvDetaylar.Items[1].SubItems.Add("32GB");
                lvDetaylar.Items[1].SubItems.Add("5,2 inc");
                lvDetaylar.Items[1].SubItems.Add("12 MP");
                lvDetaylar.Items[1].SubItems.Add("2700 TL");

                lvDetaylar.Items.Add("Galaxy S7 Edge",2);
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

        private void mitmLargerIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.LargeIcon;
        }

        private void mitmSmallIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.SmallIcon;
        }

        private void mitmDetails_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Details;
        }

        private void mitmTile_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Tile;
        }

        private void mitmList_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.List;
        }

        private void lvDetaylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDetaylar.SelectedItems.Count > 0)
            {
                txtModel.Text = lvDetaylar.SelectedItems[0].SubItems[0].Text;
                txtFiyat.Text = lvDetaylar.SelectedItems[0].SubItems[5].Text;
            }
        }
    }
}
