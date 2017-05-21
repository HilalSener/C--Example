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
        private int satisNo;
        private DateTime tarih;
        private int filmNo;
        private int musteriNo;
        private int adet;
        private double birimFiyat;
        
        #region Properties
        public int SatisNo
        {
            get
            {
                return satisNo;
            }

            set
            {
                satisNo = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }

        public int FilmNo
        {
            get
            {
                return filmNo;
            }

            set
            {
                filmNo = value;
            }
        }

        public int MusteriNo
        {
            get
            {
                return musteriNo;
            }

            set
            {
                musteriNo = value;
            }
        }

        public int Adet
        {
            get
            {
                return adet;
            }

            set
            {
                adet = value;
            }
        }

        public double BirimFiyat
        {
            get
            {
                return birimFiyat;
            }

            set
            {
                birimFiyat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void SatislariGetir(ListView liste, TextBox ToplamAdet, TextBox ToplamTutar)
        {
            liste.Items.Clear();
            int TAdet = 0;
            double TTutar = 0;
            SqlCommand comm = new SqlCommand("select SatisNo, Tarih, FilmAd, MusteriAd + ' ' + MusteriSoyad as Musteri, BirimFiyat, Adet, BirimFiyat*Adet as Tutar, fs.MusteriNo, fs.FilmNo from FilmSatis fs inner join Filmler f on fs.FilmNo = f.FilmNo inner join Musteriler m on fs.MusteriNo = m.MusteriNo where fs.Silindi = 0 order by Tarih desc, SatisNo desc", conn);
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

        public bool SatisEkle(cFilmSatis fs)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into FilmSatis (Tarih, FilmNo, MusteriNo, Adet, BirimFiyat) values(@Tarih, @FilmNo, @MusteriNo, @Adet, @BirimFiyat)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = fs.tarih;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = fs.filmNo;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = fs.musteriNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = fs.adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = fs.birimFiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool StokGuncelleBySatis(int FilmNo, int Adet)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set Miktar -= @Adet where FilmNo = @FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sonuc;
        }

        public bool SatisSil(int SatisNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update FilmSatis set Silindi = 1 where SatisNo = @SatisNo", conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = SatisNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool SatisGuncelle(int SatisNo, int Adet, double Fiyat)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update FilmSatis Adet = @Adet, BirimFiyat = @BirimFiyat where SatisNo = @SatisNo", conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = SatisNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = Fiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sonuc;
        }
    }
}
