using Blog.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.HSS13.Blog.Models
{
    public class MakaleService
    {
        BlogDbContext ent = new BlogDbContext();

        public List<Makale> SonMakaleler()
        {
            var makaleListe = (from m in ent.Makaleler
                               orderby m.Tarih descending
                               select m).Take(3).ToList();

            //var makaleListe = ent.Makaleler.OrderByDescending(m => m.Tarih).Take(3).ToList(); //Lambda ifadesi
            return makaleListe;
        }

        public List<Makale> MakalelerByEtiket(int etiketID)
        {
            var makaleListe = (from e in ent.Etiketler
                               where e.EtiketID == etiketID
                               select e.Makaleler).ToList();
           
            return makaleListe[0];
        }

        public Makale MakaleByYorum(int makaleID)
        {
            var makale = ent.Makaleler.Where(m => m.MakaleID == makaleID).FirstOrDefault();
            return makale;
        }

        public List<Makale> TumMakaleler()
        {
            var makaleListe = (from m in ent.Makaleler
                               orderby m.Tarih descending
                               select m).ToList();
            return makaleListe;
        }
    }
}