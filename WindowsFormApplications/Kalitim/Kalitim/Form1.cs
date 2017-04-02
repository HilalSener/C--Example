using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Canli canli = new Canli();  Abstract class lar miras alınır, ancak new ile çoğaltılıp kullanılamaz. 
            //canli.Beslenme = "Enerji";

            Bitki b = new Bitki();
            b.Beslenme = "Gübre";

            Hayvan h = new Hayvan();
            h.Hareket = "Koşar";
            MessageBox.Show(h.YeniDogan(), "Hayvan");

            Insan ins = new Insan();
            ins.Düsünme = "Ara sıra";  //miras alınan sınıftaki metot farklı sonuç üretiyor (çok biçimlilik - polymorphism)
            MessageBox.Show(ins.YeniDogan(), "Insan");

            //Kisi k = new Kisi();  Sealed(Mühürlenmiş) class lar new ile çoğaltılıp kullanılabilir, ancak miras alınamazlar.
            //k.Ad = "Sema";
        }
    }

    //class Kisi : Insan  //Sealed(Mühürlenmiş) class lar new ile çoğaltılıp kullanılabilir, ancak miras alınamazlar.
    //{
    //    private string _ad;
    //    private string _soyad;

    //    #region Properties
    //    public string Ad
    //    {
    //        get
    //        {
    //            return _ad;
    //        }

    //        set
    //        {
    //            _ad = value;
    //        }
    //    }

    //    public string Soyad
    //    {
    //        get
    //        {
    //            return _soyad;
    //        }

    //        set
    //        {
    //            _soyad = value;
    //        }
    //    } 
    //    #endregion
    //}
}
