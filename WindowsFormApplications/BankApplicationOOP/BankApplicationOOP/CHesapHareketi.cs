using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationOOP
{
    public class cHesapHareketi
    {
        private int _Id;
        private string _hesapNo;
        private string _tarih;
        private double _tutar;
        private string _islemTuru;

        #region Properties
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
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

        public string Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public double Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }

        public string IslemTuru
        {
            get
            {
                return _islemTuru;
            }

            set
            {
                _islemTuru = value;
            }
        } 
        #endregion

        public bool HesapHareketEkle(string Id, string HesapNo, string Tarih, double Tutar, string IslemTuru)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(Id + ";" + HesapNo + ";" + Tarih + ";" + Tutar + ";" + IslemTuru);
            HareketYaz.Close();

            return true;
        }

        public bool HesapHareketEkle(cHesapHareketi hh)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(hh._Id + ";" + hh._hesapNo + ";" + hh._tarih + ";" + hh._tutar + ";" + hh._islemTuru);
            HareketYaz.Close();

            return true;
        }

        public void HesapHareketleriGoster(string HesapNo, ListView liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunan = DosyaOku.ReadLine();
            int i = 0;
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (HesapNo == Degerler[1])
                {
                    liste.Items.Add(Degerler[0]);
                    liste.Items[i].SubItems.Add(Degerler[1]);
                    liste.Items[i].SubItems.Add(Degerler[2]);
                    liste.Items[i].SubItems.Add(Degerler[3]);
                    liste.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
