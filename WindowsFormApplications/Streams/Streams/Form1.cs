using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;

namespace Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Stream (Akım - Text dosyasına yazma - okuma I/O işlemleri için System.IO kütüphanesi - namespace eklenmelidir.
        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Ornek.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(fs);
            //StreamWriter sw = new StreamWriter("Ornek.txt"); // Dosyayı her seferinde yeniden oluşturup baştan yazar.
            StreamWriter sw = new StreamWriter("Ornek.txt", true); //Dosyayı kayıt ekleme amacıyla açar.
            sw.Write("1.Satır");
            sw.Write("2.Satır");
            sw.WriteLine("3.Satır");
            sw.WriteLine("4.Satır");

            sw.Close();

            StreamReader sr = new StreamReader("Ornek.txt");
            MessageBox.Show(sr.ReadToEnd());

            sr.Close();
        }
    }
}
