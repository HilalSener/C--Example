using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Ogrenci
        {
            private int _id;
            private string _ad;
            private string _soyad;

            public struct Veli
            {
                private string _adi;
                private string _soyadi;
                private string _telefonu;

                #region Properties
                public string Adi
                {
                    get
                    {
                        return _adi;
                    }

                    set
                    {
                        _adi = value;
                    }
                }

                public string Soyadi
                {
                    get
                    {
                        return _soyadi;
                    }

                    set
                    {
                        _soyadi = value;
                    }
                }

                public string Telefonu
                {
                    get
                    {
                        return _telefonu;
                    }

                    set
                    {
                        _telefonu = value;
                    }
                } 
                #endregion
            }

            #region Properties
            public int Id
            {
                get
                {
                    return _id;
                }

                set
                {
                    _id = value;
                }
            }

            public string Ad
            {
                get
                {
                    return _ad;
                }

                set
                {
                    _ad = value;
                }
            }

            public string Soyad
            {
                get
                {
                    return _soyad;
                }

                set
                {
                    _soyad = value;
                }
            } 
            #endregion

            //Default construtor var ve müdahale edemiyoruz. Fakat istediğimiz kadar parametreli yapıcı metot tanımlayabiliyoruz.
            public Ogrenci(int ID, string Adi, string Soyadi)
            {
                _id = ID;
                _ad = Adi;
                _soyad = Soyadi;
            }

            //Methods

            //Yıkıcı metot yok. Value type olduğu için faaliyet alanı sonlandığında otomatik olarak stack hafızadan atılırlar. 

            //Inheritance(Kalıtım) desteklenmez.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Hasan";
            o1.Soyad = "Çevik";
            Ogrenci.Veli oveli1 = new Ogrenci.Veli();
            oveli1.Adi = "Hüseyin";
            oveli1.Soyadi = "Çelik";
            oveli1.Telefonu = "5334645469";

            Ogrenci o2 = new Ogrenci(1, "Ali", "Uçar");
            MessageBox.Show("Öğrenci: " + o2.Ad + " " + o2.Soyad);
        }
    }
}
