using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            //int ort = (a+b) / 2;
            int ort =OrtalamaBul(a,b);
            MessageBox.Show("Ortalama = " + ort);
           // MessageBox.Show("Ortalama = " + OrtalamaBul(a, b));
        }

        private int OrtalamaBul(int Sayi1, int Sayi2)
        {
            return (Sayi1 + Sayi2) / 2;
        }
    }
}
