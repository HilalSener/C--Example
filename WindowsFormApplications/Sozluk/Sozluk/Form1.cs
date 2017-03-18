using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Turkceler = { "kapı", "pencere", "öğretmen", "öğrenci", "yazılım", "donanım", "nesne", "sınıf", "duvar", "saat", "masa", "kalem" };

        string[] Ingilizceler = { "door", "window", "teacher", "student", "softwear", "hardware", "object", "class", "wall", "clock", "table", "pencil" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= Turkceler.Length - 1; i++)
            {
                lbKelimeler.Items.Add(Turkceler[i]);
            }
        }

        //Listbox a türkçe kelimeleri yazdır.
        //Türkçe textbox aktif ingilizce inaktif
        //Listboxta bir kelimeye çift tıklanınca ilgili kelimeyi textbox a yazacak ve bul deyince o sözcüğü bulacak.
        //Kullanıcı kelimeri kendi yazmayacak, listeden seçecek.
        //İngilizce içinde bunun tam tersi

        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtTurkce.Text != "" && lbKelimeler.Items.Contains(txtTurkce.Text))
            {
                for (int i = 0; i <= Turkceler.Length - 1; i++)
                {
                    if (Turkceler[i] == txtTurkce.Text)
                        txtCeviri.Text = Ingilizceler[i];
                }
            }
            else if (txtIngilizce.Text != "" && lbKelimeler.Items.Contains(txtIngilizce.Text))
                for (int i = 0; i <= Ingilizceler.Length - 1; i++)
                {
                    if (Ingilizceler[i] == txtIngilizce.Text)
                        txtCeviri.Text = Turkceler[i];
                }
            else 
                MessageBox.Show("Aradığınız kelime sözlükte yok!");
        }

        private void lbKelimeler_DoubleClick(object sender, EventArgs e)
        {
            if(rbTrToIng.Checked)
            {
                txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
                txtIngilizce.Clear();
            }
            else if(rbIngtToTr.Checked)
            {
                txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
                txtTurkce.Clear();
            }
            //if (Turkceler.Contains(lbKelimeler.SelectedItem.ToString()))
            //    txtTurkce.Text = lbKelimeler.SelectedItem.ToString();
            //else if (Ingilizceler.Contains(lbKelimeler.SelectedItem.ToString()))
            //    txtIngilizce.Text = lbKelimeler.SelectedItem.ToString();
        }

        private void rbTrToIng_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            txtIngilizce.Clear();
            txtCeviri.Clear();
            txtTurkce.ReadOnly = false;
            txtIngilizce.ReadOnly = true;
            txtTurkce.Focus();
            for (int i =0; i <= Turkceler.Length - 1; i++)
            {
                lbKelimeler.Items.Add(Turkceler[i]);
            }
            //lbKelimeler.Items.AddRange(Turkceler);
        }

        private void rbIngtToTr_CheckedChanged(object sender, EventArgs e)
        {
            lbKelimeler.Items.Clear();
            txtTurkce.Clear();
            txtCeviri.Clear();
            txtIngilizce.ReadOnly = false;
            txtTurkce.ReadOnly = true;
            txtIngilizce.Focus();
            for (int i = 0; i <= Ingilizceler.Length - 1; i++)
            {
                lbKelimeler.Items.Add(Ingilizceler[i]);
            }
            //lbKelimeler.Items.AddRange(Ingilizceler);
        }
    }
}
