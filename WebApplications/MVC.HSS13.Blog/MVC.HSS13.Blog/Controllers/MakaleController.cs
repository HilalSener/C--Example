using MVC.HSS13.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.HSS13.Blog.Controllers
{
    public class MakaleController : Controller
    {
        MakaleService ms = new MakaleService();
        public ActionResult Index()
        {
            return View(ms.TumMakaleler());
        }
    }
}