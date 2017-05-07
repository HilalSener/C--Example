using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace VideoMarket
{
    public class cFilmTuru
    {
        private int _filmTurNo;
        private string _turAd;
        private string _aciklama;

        #region Properties
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

        public string TurAd
        {
            get
            {
                return _turAd;
            }

            set
            {
                _turAd = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmTurleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from FilmTurleri where Silindi = 0", conn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();  //Kontrol edilcek işlemler.
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;  //Hata durumunda çalışır.
            }
            finally { conn.Close(); }  //hatayla karşılaşılsın ya da karşılaşılmasın mutlaka çalışır.
        }

        public bool FilmTuruKontrol(string FilmTuru)
        {
            bool VarMi = false;
            SqlCommand comm = new SqlCommand("select * from FilmTurleri where TurAd = @TurAd and Silindi = 0", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();  
                while (dr.Read())
                {
                    VarMi = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message; 
            }
            finally { conn.Close(); }

            return VarMi;
        }

        public bool FilmTuruEkle(string FilmTuru, string Aciklama)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into FilmTurleri (TurAd, Aciklama) values(@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
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
    }
}
