using Blog.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.HSS13.Blog.Models
{
    public class YorumService
    {
        BlogDbContext ent = new BlogDbContext();
        public List<Yorum> SonYorumlar()
        {
            var yorumListe = (from y in ent.Yorumlar
                               orderby y.Tarih descending
                               select y).Take(3).ToList();

            //var makaleListe = ent.Makaleler.OrderByDescending(m => m.Tarih).Take(3).ToList(); //Lambda ifadesi
            return yorumListe;
        }

        public List<Yorum> TumYorumlar()
        {
            var yorumListe = (from y in ent.Yorumlar
                              orderby y.Tarih descending
                              select y).ToList();
            
            return yorumListe;
        }
    }
}