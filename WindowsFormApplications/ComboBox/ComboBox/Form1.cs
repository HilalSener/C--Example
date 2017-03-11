using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPhone.SelectedItem.ToString() == "Apple")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("iPhone 6");
                lbModeller.Items.Add("iPhone 6S");
                lbModeller.Items.Add("iPhone 7");
            }
            else if(cbPhone.SelectedItem.ToString() == "Samsung")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("Galaxy Note 5");
                lbModeller.Items.Add("Galaxy S7");
                lbModeller.Items.Add("Galaxy S7 Edge");
            }
            else if(cbPhone.SelectedItem.ToString() == "Nokia")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("Luima 520");
                lbModeller.Items.Add("Luima 1120");
                lbModeller.Items.Add("Lumia 1320");
            }
        }
    }
}
