using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoMarket
{
    public class cMusteri
    {
        private int _musteriNo;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;

        #region Properties
        public int MusteriNo
        {
            get
            {
                return _musteriNo;
            }

            set
            {
                _musteriNo = value;
            }
        }

        public string MusteriAd
        {
            get
            {
                return _musteriAd;
            }

            set
            {
                _musteriAd = value;
            }
        }

        public string MusteriSoyad
        {
            get
            {
                return _musteriSoyad;
            }

            set
            {
                _musteriSoyad = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void MusterileriGoster(ListView lvMusteriler)
        {
            SqlCommand comm = new SqlCommand("select MusteriAd, MusteriSoyad, Telefon from Musteriler where Silindi = 0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvMusteriler.Items.Add(dr[0].ToString());
                    lvMusteriler.Items[i].SubItems.Add(dr[1].ToString());
                    lvMusteriler.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void MusteriBilgileriniGoster(ListView lvMusteriler, string MusteriAd)
        {
            lvMusteriler.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriAd, MusteriSoyad, Telefon from Musteriler where MusteriAd like @MusteriAd + '%' ", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = MusteriAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvMusteriler.Items.Add(dr[0].ToString());
                    lvMusteriler.Items[i].SubItems.Add(dr[1].ToString());
                    lvMusteriler.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public cMusteri GetSelectedMusteriDetail(ListView lvMusteriler)
        {
            cMusteri m = new cMusteri();
            SqlCommand comm = new SqlCommand("select MusteriNo, MusteriAd, MusteriSoyad, Telefon, Adres from Musteriler where MusteriAd = @MusteriAd and MusteriSoyad = @MusteriSoyad and Silindi = 0", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    m._musteriNo = Convert.ToInt32(dr[0].ToString());
                    m._musteriAd = dr[1].ToString();
                    m._musteriSoyad = dr[2].ToString();
                    m._telefon = dr[3].ToString();
                    m._adres = dr[4].ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return m;
        }

        public bool MusteriKontrol(string MusteriAd, string MusteriSoyad)
        {
            bool VarMi = false;
            SqlCommand comm = new SqlCommand("select * from Musteri where MusteriAd = @MusteriAd and MusteriSoyad = @MusteriSoyad and Silindi = 0", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.Int).Value = MusteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.Int).Value = MusteriSoyad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows) VarMi = true;
                //while (dr.Read())
                //{
                //    VarMi = true;
                //}
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return VarMi;
        }

        public bool MusteriEkle(cMusteri m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values(@Ad, @Soyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
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
