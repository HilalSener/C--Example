using MVC.HSS13.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.HSS13.Blog.Controllers
{
    public class YorumController : Controller
    {
        YorumService ys = new YorumService();
        public ActionResult Index()
        {
            return View(ys.TumYorumlar());
        }
    }
}