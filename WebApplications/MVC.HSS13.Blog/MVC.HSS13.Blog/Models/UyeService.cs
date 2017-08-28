using Blog.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.HSS13.Blog.Models
{
    public class UyeService
    {
        BlogDbContext ent = new BlogDbContext();

        public List<UyeModel> TumUyeler()
        {
            var liste = (from u in ent.Uyeler
                         select new UyeModel { uyeAdSoyad = u.Ad + " " + u.Soyad, email = u.Email }).ToList();

            return liste;
        }

        public Uye UyeKontrol(string email, string sifre)
        {
            Uye uye = (from u in ent.Uyeler
                     where u.Email == email && u.Sifre == sifre
                     select u).FirstOrDefault();
            return uye;
        }
    }
}