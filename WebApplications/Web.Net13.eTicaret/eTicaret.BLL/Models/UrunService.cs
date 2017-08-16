using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.BLL.Models
{
    public class UrunService
    {
        SaglikDbContext ent = new SaglikDbContext();

        public List<Urun> GetUrunByID(int ID)
        {
            var Products = (from k in ent.Urunler
                            where k.silindi == false && k.urunid == ID
                            select k).ToList();
            return Products;
        }
        public List<Urun> GetAllUrunler()
        {
            var Products = (from k in ent.Urunler
                              where k.silindi == false
                              select k).ToList();
            return Products;
        }
        public List<Urun> GetAllUrunlerByKategori(string KategoriNo)
        {
            int kno = Convert.ToInt32(KategoriNo);
            var Products = (from k in ent.Urunler
                            where k.silindi == false && k.Kategori.id == kno
                            select k).ToList();
            return Products;
        }
        public List<Urun> GetAllUrunlerByKategoriAndAltKategori(string KategoriNo, string AltKategoriNo)
        {
            int kno = Convert.ToInt32(KategoriNo);
            int altkno = Convert.ToInt32(AltKategoriNo);
            var Products = (from k in ent.Urunler
                            where k.silindi == false && k.Kategori.id == kno && k.AltKategori.id == altkno
                            select k).ToList();
            return Products;
        }

    }
}
