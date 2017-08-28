using MVC.HSS13.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.HSS13.Blog.Controllers
{
    public class HomeController : Controller
    {
        MakaleService ms = new MakaleService();
        YorumService ys = new YorumService();
        EtiketService es = new EtiketService();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SonMakaleler()
        {
            return PartialView(ms.SonMakaleler());
        }

        public ActionResult SonYorumlar()
        {
            return PartialView(ys.SonYorumlar());
        }

        public ActionResult CokKullanilanEtiketler()
        {
            return PartialView(es.CokKullanilanEtiketler());
        }

        public ActionResult MakalelerByEtiket(int EtiketID)
        {
            return View(ms.MakalelerByEtiket(EtiketID));
        }

        public ActionResult MakaleByYorum(int makaleID)
        {
            return View(ms.MakaleByYorum(makaleID));
        }
    }
}