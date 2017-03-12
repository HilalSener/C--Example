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

        }

        //Listbox a türkçe kelimeleri yazdır.
        //Türkçe textbox aktif ingilizce inaktif
        //Listboxta bir kelimeye çift tıklanınca ilgili kelimeyi textbox a yazacak ve bul deyince o sözcüğü bulacak.
        //Kullanıcı kelimeri kendi yazmayacak, listeden seçecek.
        //İngilizce içinde bunun tam tersi

        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtTurkce.Text != "")
            {
                for (int i = 0; i <= Turkceler.Length - 1; i++)
                {
                    if (Turkceler[i] == txtTurkce.Text)
                        txtIngilizce.Text = Ingilizceler[i];
                    else
                        MessageBox.Show("Bu kelime sözlükte yok!");
                }
            }
        }

        private void lbKelimeler_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
