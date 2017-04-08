using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Gunler : byte
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        enum Subeler //int kabul edilir. Hafızada 4 byte yer açılır.
        {
            Beşiktaş = 1220,
            Taksim = 1320,
            Bakırköy,
            Kadıköy = 1820
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Gunler.Cuma.ToString());
            int Kod = (int)Gunler.Cuma;
            MessageBox.Show("Günün Kodu: " + Kod);

            //if(Secim == (int)Gunler.Cuma) //Secim == 4 gibi
            //{
            //  .......
            //}

            MessageBox.Show("Şubeniz : " + Subeler.Beşiktaş);
            MessageBox.Show("Şube kodunuz : " + (int)Subeler.Beşiktaş);

            MessageBox.Show("Şubeniz : " + Subeler.Bakırköy);
            MessageBox.Show("Şube kodunuz : " + (int)Subeler.Bakırköy);

            //System.Enum sınıfından türetilmiştir.
            string[] SubeIsimleri = System.Enum.GetNames(typeof(Subeler));
            foreach (string sube in SubeIsimleri)
            {
                MessageBox.Show(sube);
            }
        }
    }
}
