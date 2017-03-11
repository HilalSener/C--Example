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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbListe.Items.Add("sinan");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.Trim()))
                {
                    MessageBox.Show("Zaten listede mevcut!");
                }
                    
                else
                {
                    lbListe.Items.Add(txtGirilen.Text.Trim().ToLower());
                }
            }
            else
                MessageBox.Show("Bir isim girmelisiniz!");
            txtGirilen.Clear();
            txtGirilen.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //lbListe.Items.Remove("oya");
            //if(lbListe.Items.Count != 0)
            //    lbListe.Items.RemoveAt(0);
            //MessageBox.Show(lbListe.SelectedItem.ToString());
            //lbListe.Items.Remove(lbListe.SelectedItem.ToString());
            if (lbListe.SelectedItem != null)
                lbListe.Items.Remove(lbListe.SelectedItem.ToString());
            else
                MessageBox.Show("Seçim yapmalısınız!");
            //if(lbListe.SelectedItems.Count != 0)
            //    lbListe.Items.Remove(lbListe.SelectedItem.ToString());
            //else
            //    MessageBox.Show("Seçim yapmalısınız!");
            //if (lbListe.SelectedIndex != -1)
            //    lbListe.Items.RemoveAt(lbListe.SelectedIndex);
            //else
            //    MessageBox.Show("Seçim yapmalısınız!");
        }

        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lbListe.SelectedItem.ToString());
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (lbListe.Items.Contains(txtGirilen.Text.Trim().ToLower()))
            {
                //lbListe.SelectedItem = txtGirilen.Text;
                //Bir de SelectedIndex ile yapmayı dene!

            }
            else
                MessageBox.Show("Listede bu isim bulunmamaktadır!");
        }
    }
}
