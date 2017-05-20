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
        private double _fiyat;

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

        public double Fiyat
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

        public bool FilmKontrol(string FilmAd, string Yonetmen)
        {
            bool VarMi = false;
            SqlCommand comm = new SqlCommand("select * from Filmler where FilmAd = @FilmAd and Yonetmen = @Yonetmen and Varmi = 1", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = FilmAd;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows) VarMi = true;
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return VarMi;
        }

        public bool FilmKontrol(string FilmAd, string Yonetmen, int FilmNo)
        {
            bool VarMi = false;
            SqlCommand comm = new SqlCommand("select * from Filmler where FilmAd = @FilmAd and Yonetmen = @Yonetmen and FilmNo != @FilmNo and Varmi = 1", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = FilmAd;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            comm.Parameters.Add("@FilmNo", SqlDbType.VarChar).Value = FilmNo;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows) VarMi = true;
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return VarMi;
        }

        public bool FilmEkle(cFilm f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular, Ozet, Miktar, Fiyat) values (@FilmAd, @FilmTurNo, @Yonetmen, @Oyuncular, @Ozet, @Miktar, @Fiyat)", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = f._fiyat;
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

        public bool FilmGuncelle(cFilm f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set FilmAd = @FilmAd, FilmTurNo = @FilmTurNo, Yonetmen = @Yonetmen, Oyuncular = @Oyuncular, Ozet = @Ozet, Miktar = @Miktar, Fiyat = @Fiyat where FilmNo = @FilmNo", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = f._fiyat;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;
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

        public bool FilmSil(int FilmNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set Varmi = 0 where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());   //insert, update ve delete de kullanılır. 
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public void FilmleriGosterByAdaGore(ListView liste, string AdaGore)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo, FilmAd, Filmler.FilmTurNo, TurAd, Yonetmen, Oyuncular, Ozet, Miktar, Fiyat from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi = 1 and FilmAd like @FilmAd + '%'", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = AdaGore;
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
        public void FilmleriGosterBySorgulama(ListView liste, string AdaGore, string TureGore, string YonetmeneGore, string OyuncularaGore)
        {
            liste.Items.Clear();
            //string Sorgu = "select * from Musteriler where Silindi = 0";
            //if (AdaGore != "") Sorgu += " and MusteriAd like @MusteriAd + '%' ";
            //SqlCommand comm = new SqlCommand(Sorgu, conn);
            SqlCommand comm = new SqlCommand("select FilmNo, FilmAd, Filmler.FilmTurNo, TurAd, Yonetmen, Oyuncular, Ozet, Miktar, Fiyat from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi = 1 and FilmAd like @FilmAd + '%' and TurAd like @TurAd + '%' and Yonetmen like @Yonetmen + '%' and Oyuncular like @Oyuncular + '%' ", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = TureGore;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = YonetmeneGore;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = OyuncularaGore;
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
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
    }
}
