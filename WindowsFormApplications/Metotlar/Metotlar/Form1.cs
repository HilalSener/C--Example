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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Bilgiler veritabanına kaydedilecek.
            //MessageBox.Show("Öğrenci bilgileri kayıt edildi!");
            EkranaGoruntule("Öğrenci bilgileri kayıt edildi!");
            ////txtAdi.Clear();
            //txtSoyadi.Clear();
            //txtTelefon.Clear();
            //txtAdres.Clear();
            //txtAdi.Focus();
            Temizle();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Bilgiler veritabanında güncellenecek. Kullanıcı öğrenci bilgiler değişti diye bilgilendirilecek. Ve Textboxlar temizlenip yeni giriş için ad textboxınq gofcus olunacakçü
            EkranaGoruntule("Öğrenci bilgileri değiştirildi!");
            //txtAdi.Clear();
            //txtSoyadi.Clear();
            //txtTelefon.Clear();
            //txtAdres.Clear();
            //txtAdi.Focus();
            Temizle();
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void EkranaGoruntule(string Mesaj)
        {
            MessageBox.Show(Mesaj);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EkranaGoruntule("Öğrenci bilgileri girildi.");
            //MessageBox.Show("Öğrenci bilgileri silindi!");
            Temizle();

        }
    }
}
