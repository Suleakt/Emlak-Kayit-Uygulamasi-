using Emlakci2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;//forms authentication icin eklendi

namespace Emlakci2.Controllers
{
    public class AccountController : Controller
    {
        //Model1 db = new Model1();
        //
        // GET: /Account/
        //string e;
        public static string create;
        public static string edit;
        public static string delete;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(EMLAKCI user)
        {
            Model1 eml = new Model1();
            var u = eml.EMLAKCI.Where(a => a.ADSOYAD.Equals(user.ADSOYAD) && a.SIFRE.Equals(user.SIFRE)).FirstOrDefault();
            if (u != null)
            {
               
                //ad ve sifre eslesiyorsa
                FormsAuthentication.SetAuthCookie(u.ADSOYAD, false);
                //session ekleme
                //e = u.ADSOYAD;
                //Session["yetki"] = u.YETKI_CREATE;
                create = u.YETKI_CREATE;
                edit = u.YETKI_EDIT;
                delete = u.YETKI_DELETE;
                if (create == "0")
                {
                    Session["yetki"] = "0";
                }
                if (edit == "0")
                {
                    //Bu sekilde "0" atanmayip u.YETKI_EDIT seklinde ataninca yetki calismiyor
                    Session["yetki2"] = "0";
                }
                if (delete == "0")
                {
                    Session["yetki3"] = "0";
                }
                //eger yetkilerden herhangi biri kisitlanmissa kurumsal uye kaydi yapamaz
                if(create=="0" || edit=="0" || delete == "0"){
                    Session["uye"] = "0";
                }
                //session bitis

                return RedirectToAction("Index", "Home");
            }
            else
            {
                //ad ve sifre eslesmiyorsa
                ViewBag.LoginError = "Hatalı Kullanıcı Adı veya Şifre";
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            //Çıkış yapa tiklandiginda tekrar Login sayfasina yonlendirilir
            return RedirectToAction("Login");
        }

    }
}