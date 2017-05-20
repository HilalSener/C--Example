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
    public class cFilmSatis
    {
        private int SatisNo;
        private DateTime Tarih;
        private int FilmNo;
        private int MusteriNo;
        private int Adet;
        private double BirimFiyat;

        #region Properties
        public int SatisNo1
        {
            get
            {
                return SatisNo;
            }

            set
            {
                SatisNo = value;
            }
        }

        public DateTime Tarih1
        {
            get
            {
                return Tarih;
            }

            set
            {
                Tarih = value;
            }
        }

        public int FilmNo1
        {
            get
            {
                return FilmNo;
            }

            set
            {
                FilmNo = value;
            }
        }

        public int MusteriNo1
        {
            get
            {
                return MusteriNo;
            }

            set
            {
                MusteriNo = value;
            }
        }

        public int Adet1
        {
            get
            {
                return Adet;
            }

            set
            {
                Adet = value;
            }
        }

        public double BirimFiyat1
        {
            get
            {
                return BirimFiyat;
            }

            set
            {
                BirimFiyat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void SatislariGetir(ListView liste, TextBox ToplamAdet, TextBox ToplamTutar)
        {
            liste.Items.Clear();
            int TAdet = 0;
            double TTutar = 0;
            SqlCommand comm = new SqlCommand("select SatisNo, Tarih, FilmAd, MusteriAd + ' ' + MusteriSoyad as Musteri, BirimFiyat, Adet, BirimFiyat*Adet as Tutar, fs.FilmNo, fs.MusteriNo from FilmSatis fs inner join Filmler f on fs.FilmNo = f.FilmNo inner join Musteriler m on fs.MusteriNo = m.MusteriNo where fs.Silindi = 0 order by Tarih desc ", conn);
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
                        if (j == 5) TAdet += Convert.ToInt32(dr[j]);
                        if (j == 6) TTutar += Convert.ToDouble(dr[j]);
                    }
                    i++;
                }
                dr.Close();
                ToplamAdet.Text = TAdet.ToString();
                ToplamTutar.Text = TTutar.ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
    }
}
