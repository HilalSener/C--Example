using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            StreamWriter DosyaYaz = new StreamWriter("Metin.txt");
            DosyaYaz.WriteLine(txtSatir.Text);

            DosyaYaz.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            StreamWriter DosyaEkle = new StreamWriter("Metin.txt", true);
            DosyaEkle.WriteLine(txtSatir.Text);

            DosyaEkle.Close();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            StreamReader DosyaOku = new StreamReader("Metin.txt");
            rbtxtMetin.Text = DosyaOku.ReadLine(); //1 satır okur.

            DosyaOku.Close();
        }

        private void btnHepsiniOku_Click(object sender, EventArgs e)
        {
            StreamReader DosyaOku = new StreamReader("Metin.txt");
            rbtxtMetin.Text = DosyaOku.ReadToEnd(); //Sona kadar hepsini okur.
            //ReadToEnd yerine ReadLine kullanmayı deneyelim. İpucu, "null" ile kontrol et!

            DosyaOku.Close();
        }
    }
}
