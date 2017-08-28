using Blog.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.HSS13.Blog.Models
{
    public class EtiketService
    {
        BlogDbContext ent = new BlogDbContext();
        public List<Etiket> CokKullanilanEtiketler()
        {
            //En çok makaleyle ilişkilendirilmiş 5 adet etiketi döndürecek list koleksiyonunu oluşturuyoruz.
            List<Etiket> etiketListe = (from e in ent.Etiketler
                                        orderby e.Makaleler.Count() descending
                                        select e).Take(5).ToList();
            return etiketListe;
        }
    }
}