using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingMusteriler
{
    public class cMusteri
    {
        public int MusteriNo { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MTC28NR; Initial Catalog=VideoMarket; uid=sa; pwd=1234");

        DataSet ds = new DataSet();

        public DataSet GetMusteriler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Musteriler", conn);
            try
            {
                da.Fill(ds, "Musteriler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }
    }
}
