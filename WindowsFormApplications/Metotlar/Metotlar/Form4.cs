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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int a = 5; //Stack hafıza value type
            MessageBox.Show(a.ToString());
            DegerAl(a);
            MessageBox.Show(a.ToString());

            //string Sehir = "Izmir";
            //MessageBox.Show(Sehir.ToString());
            //ReferansAl(Sehir);
            //MessageBox.Show(Sehir.ToString());

            string[] Sehirler = { "İzmir", "Ankara", "Bursa", "Adana"};
            MessageBox.Show(Sehirler[0]);
            ReferansAl(Sehirler);
            MessageBox.Show(Sehirler[0]);
        }

        private void DegerAl(int a)
        {
            a = 10;
        }

        private void ReferansAl(string[] Iller)
        {
            Iller[0] = "İstanbul";
        }

        //private void ReferansAl(string Sehir)
        //{
        //    Sehir = "Istanbul"; 
        //}
    }
}
