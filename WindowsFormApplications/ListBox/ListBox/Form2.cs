using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSagaTek_Click(object sender, EventArgs e)
        {
            if (lbKullanicilar.SelectedItems.Count != 0)
            {
                lbSecilenler.Items.Add(lbKullanicilar.SelectedItem.ToString());
                lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItem.ToString());
            }
            else
                MessageBox.Show("Listeden bir seçim yapmalısınız!");
        }

        private void btnSagaCok_Click(object sender, EventArgs e)
        {
            if(lbKullanicilar.SelectedItems.Count != 0)
            {
                for(int i = lbKullanicilar.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lbSecilenler.Items.Add(lbKullanicilar.SelectedItems[i]);
                    lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItems[i]);
                }
            }
            else
                MessageBox.Show("Listeden bir seçim yapmalısınız!");
        }

        private void btnSolaTek_Click(object sender, EventArgs e)
        {
            if(lbSecilenler.SelectedItems.Count != 0)
            {
                lbKullanicilar.Items.Add(lbSecilenler.SelectedItem.ToString());
                lbSecilenler.Items.Remove(lbSecilenler.SelectedItem.ToString());
            }
            else
                MessageBox.Show("Listeden bir seçim yapmalısınız!");
        }

        private void btnSolaCok_Click(object sender, EventArgs e)
        {
            if(lbSecilenler.SelectedItems.Count != 0)
            {
                for(int i = lbSecilenler.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lbKullanicilar.Items.Add(lbSecilenler.SelectedItems[i].ToString());
                    lbSecilenler.Items.Remove(lbSecilenler.SelectedItems[i].ToString());
                }
            }
            else
                MessageBox.Show("Listeden bir seçim yapmalısınız!");
        }
    }
}
