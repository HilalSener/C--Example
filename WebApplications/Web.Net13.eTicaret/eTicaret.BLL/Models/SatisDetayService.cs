using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.BLL.Models
{
    public class SatisDetayService
    {
        SaglikDbContext ent = new SaglikDbContext();

        public bool SatisDetaylariEkleBySepet(DataTable dt, int SatisNo)
        {
            SatisDetay sd;
            foreach (DataRow dr in dt.Rows)  //Sepet içindeki siparişleri elde ediyoruz.
            {
                sd = new SatisDetay();
                sd.Satis.satisid = SatisNo;
                sd.Urun.urunid = Convert.ToInt32(dr["urunid"]);
                sd.adet = Convert.ToInt32(dr["adet"]);
                sd.birimfiyat = Convert.ToDecimal(dr["fiyat"]);
                sd.tutar = Convert.ToDecimal(dr["tutar"]);
                ent.SatisDetaylari.Add(sd);  //her bir siparişi ara katmana ekliyoruz.
            }
            try
            {
                ent.SaveChanges();  //Ara katmana göre tüm siparişleri bir defada veritabanına kaydediyoruz. Transaction yapısı var, hata durumunda hiç kayıt yapmıyor. 
                return true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return false;
        }

    }
}
