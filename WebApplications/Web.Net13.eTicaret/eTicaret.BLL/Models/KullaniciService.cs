using eTicaret.DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.BLL.Models
{
    public class KullaniciService
    {
        SaglikDbContext ent = new SaglikDbContext();

        public Kullanici KullaniciKontrol(string email, string sifre)
        {
            var user = (from k in ent.Kullanicilar
                        where k.kullaniciad == email && k.sifre == sifre && k.silindi == false
                        select k).FirstOrDefault();
            return user;
        }

        public Kullanici KullaniciKontrolByAdmin(string email, string sifre)
        {
            var user = (from k in ent.Kullanicilar
                        where k.admin == true && k.kullaniciad == email && k.sifre == sifre && k.silindi == false
                        select k).FirstOrDefault();
            return user;
        }

        public bool AdresGuncelle(Kullanici k)
        {
            var user = (from u in ent.Kullanicilar
                        where u.id == k.id
                        select k).FirstOrDefault();

            user.ad = k.ad;
            user.soyad = k.soyad;
            user.tckno = k.tckno;
            user.telefon = k.telefon;
            user.adres = k.adres;
            user.ilce = k.ilce;
            user.il = k.il;

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

        public bool KategoriEkle(Kategori k)
        {
            ent.Kategoriler.Add(k);
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
    }
}
