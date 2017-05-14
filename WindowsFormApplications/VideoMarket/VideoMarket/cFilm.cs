using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarket
{
    public class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private int _miktar;
        private int _fiyat;

        #region Properties
        public int FilmNo
        {
            get
            {
                return _filmNo;
            }

            set
            {
                _filmNo = value;
            }
        }

        public string FilmAd
        {
            get
            {
                return _filmAd;
            }

            set
            {
                _filmAd = value;
            }
        }

        public int FilmTurNo
        {
            get
            {
                return _filmTurNo;
            }

            set
            {
                _filmTurNo = value;
            }
        }

        public string Yonetmen
        {
            get
            {
                return _yonetmen;
            }

            set
            {
                _yonetmen = value;
            }
        }

        public string Oyuncular
        {
            get
            {
                return _oyuncular;
            }

            set
            {
                _oyuncular = value;
            }
        }

        public string Ozet
        {
            get
            {
                return _ozet;
            }

            set
            {
                _ozet = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }

        public int Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo, FilmAd, Filmler.FilmTurNo, TurAd, Yonetmen, Oyuncular, Ozet, Miktar, Fiyat from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi = 1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    for (int j = 1; j < liste.Columns.Count; j++)
                    {
                        liste.Items[i].SubItems.Add(dr[j].ToString());
                    }
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
    }
}
