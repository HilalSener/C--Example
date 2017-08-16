using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.BLL.Models
{
    public class SatisService
    {
        SaglikDbContext ent = new SaglikDbContext();

        public bool SatisEkle(Satis s)
        {
            ent.Satislar.Add(s);
            try
            {
                ent.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return false;
        }

        public int SonSatisNoBul(int kullanicino)
        {
            var sat = (from s in ent.Satislar
                       where s.Kullanici.id == kullanicino && s.silindi == false
                       select s).ToList().Last();

            return sat.satisid;
            //return ent.Satislar.Where(s => s.Kullanici.id == kullanicino && s.silindi == false).ToList().Last().satisid;
        }
    }
}
