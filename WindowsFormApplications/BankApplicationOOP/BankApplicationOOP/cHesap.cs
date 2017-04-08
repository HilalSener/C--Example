using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationOOP
{
    public class cHesap
    {
        private int _id;
        private string _hesapNo;
        private string _acilisTarihi;
        private string _ad;
        private string _soyad;
        private string _tckno;
        private double _bakiye;
        private string _hesapTuru;

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

        public string HesapNo
        {
            get
            {
                return _hesapNo;
            }

            set
            {
                _hesapNo = value;
            }
        }

        public string AcilisTarihi
        {
            get
            {
                return _acilisTarihi;
            }

            set
            {
                _acilisTarihi = value;
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

        public string Tckno
        {
            get
            {
                return _tckno;
            }

            set
            {
                _tckno = value;
            }
        }

        public double Bakiye
        {
            get
            {
                return _bakiye;
            }

            set
            {
                _bakiye = value;
            }
        }

        public string HesapTuru
        {
            get
            {
                return _hesapTuru;
            }

            set
            {
                _hesapTuru = value;
            }
        }
        #endregion

        public int SonIDBul()
        {
            StreamWriter DosyaOlustur = new StreamWriter("HesapKartlari.txt", true);
            DosyaOlustur.Close();

            int ID;
            string[] Degerler = new string[8];
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            if (okunan == null)
                ID= 1;
            else
                while (okunan != null)
                {
                    Degerler = okunan.Split(';');
                    okunan = DosyaOku.ReadLine();
                }
            ID = Convert.ToInt32(Degerler[0]) + 1;
            DosyaOku.Close();
            return ID;
        }

        Random rnd = new Random();
        string YeniHesapNo;
        public string HesapNoOlustur()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapKontrol();
            } while (Varmi);
            return YeniHesapNo;
        }

        public bool HesapKontrol()
        {
            YeniHesapNo = "ACC" + rnd.Next(1000, 10000); //Ratgele 1000 - 9999 arasında bir sayı üretir.
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (YeniHesapNo == Degerler[1])
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

       public bool YeniHesapAc(int Id, string No, string Tarih, string Adi, string Soyadi, string TCKNo, Double Bakiye, string HesapTuru)
       {
           StreamWriter KartYaz = new StreamWriter("HesapKartlari.txt", true);
           KartYaz.WriteLine(Id + ";" + No + ";" + Tarih + ";" +  Adi + ";" + Soyadi + ";" + TCKNo + ";" + Bakiye + ";" + HesapTuru);

           KartYaz.Close();
            return true;
       }

        public bool YeniHesapAc(cHesap h)
        {
            StreamWriter KartYaz = new StreamWriter("HesapKartlari.txt", true);
            KartYaz.WriteLine(h._id + ";" + h._hesapNo + ";" + h._acilisTarihi + ";" + h._ad + ";" + h._soyad + ";" + h._tckno + ";" + h._bakiye + ";" + h._hesapTuru);

            KartYaz.Close();
            return true;
        }

        public void HesapBilgileriGoster(string HesapNo, TextBox Ad, TextBox Soyad, TextBox TCKNo, TextBox HesapTuru, TextBox AcilisTarihi)
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (HesapNo == Degerler[1])
                {
                    Ad.Text = Degerler[3];
                    Soyad.Text = Degerler[4];
                    TCKNo.Text = Degerler[5];
                    HesapTuru.Text = Degerler[7];
                    AcilisTarihi.Text = Degerler[2];
                    break;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public cHesap HesapBilgileriGoster(string HesapNo)
        {
            cHesap h = new cHesap();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (HesapNo == Degerler[1])
                {
                    h._ad = Degerler[3];
                    h._soyad = Degerler[4];
                    h._tckno = Degerler[5];
                    h._hesapTuru = Degerler[7];
                    h._acilisTarihi = Degerler[2];
                    break;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();

            return h;
        }
    }
}
