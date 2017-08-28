using Blog.DAL.DataModel;
using MVC.HSS13.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.HSS13.Blog.Controllers
{
    public class UyeController : Controller
    {
        UyeService us = new UyeService();
        public ActionResult Index()
        {
            //Tüm üyeleri View sayfasına (server -> client) Json olarak gönderiyoruz.
            return View();
        }

        public JsonResult UyeListesi()
        {
            var liste = us.TumUyeler();
            return Json(liste, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UyeGiris()
        {
            return View();
        }

        [HttpPost]
        public string UyeGiris(string Email, string Sifre)
        {
            Uye uye = us.UyeKontrol(Email, Sifre);
            if (uye == null) return "Hatalı email veya şifre girişi";
            Session["uye"] = uye.UyeID;
            return "Hoşgeldiniz...<script type='type/javascript'>setTimeout(function(){window.location='/'}, 3000);</script>";
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            //View' dn gelen model bilgileri UyeService aracılığıyla kayıt edilcek.
            return View();
        }
    }
}