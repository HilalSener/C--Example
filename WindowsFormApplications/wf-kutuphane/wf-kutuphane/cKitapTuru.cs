using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_kutuphane
{
    public class cKitapTuru
    {
        private int _id;
        private string _kitapTuru;

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

        public string KitapTuru
        {
            get
            {
                return _kitapTuru;
            }

            set
            {
                _kitapTuru = value;
            }
        }

        public void KitapTurleriGoster(ListBox liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");
            string Okunan = DosyaOku.ReadLine();
            while(Okunan != null)
            {
                string[] Degerler = Okunan.Split(';');
                liste.Items.Add(Degerler[1]);
                Okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public bool KitapTuruEkle(cKitapTuru kt)
        {
            StreamWriter DosyaYaz = new StreamWriter("KitapTurleri.txt", true);
            DosyaYaz.WriteLine(kt._id  + ";" + kt._kitapTuru);
            DosyaYaz.Close();
            return true;
        }

        public bool KitapTuruVarmi(string KitapTuru)
        {
            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");
            string Okunan = DosyaOku.ReadLine();
            while(Okunan != null)
            {
                string[] Degerler = Okunan.Split(';');
                if (Degerler[1] == KitapTuru)
                {
                    DosyaOku.Close();
                    return true;
                }
                Okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
        #endregion

        public int SonIDBul()
        {
            int id = 0;
            StreamWriter DosyaOlustur = new StreamWriter("KitapTurleri.txt", true);
            DosyaOlustur.Close();

            StreamReader DosyaOku = new StreamReader("KitapTurleri.txt");
            string Okunan = DosyaOku.ReadLine();
            if (Okunan == null)
                id = 1;
            else
                while(Okunan != null)
                {
                    string[] Degerler = Okunan.Split(';');
                    id = (Convert.ToInt32(Degerler[0]) + 1);
                    Okunan = DosyaOku.ReadLine();
                }
            DosyaOku.Close();
            return id;
        }
    }
}
