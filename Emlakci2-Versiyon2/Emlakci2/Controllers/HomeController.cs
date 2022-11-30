using Emlakci2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlakci2.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            //var ev = db.EV.ToList();
            //var evdetay = db.EV_DETAY.ToList();
            //var emlakci = db.EMLAKCI.ToList();
            //var evsahibi = db.EV_SAHIBI.ToList();
            //var musteri = db.MUSTERI.ToList();
            //var teslimev = db.TESLIM_EDILEN_EV.ToList();
            List<EV> evler = db.EV.ToList();
            List<EMLAKCI> emlakcilar = db.EMLAKCI.ToList();
            //deneme icin yazildi, gerek yok
            return View();
        }
        public ActionResult Detay()
        {
            List<EV> evler = db.EV.ToList();
            return View(evler);
            //return View(db.EV.Where(i => i.EVID == id).FirstOrDefault());
        }
        public ActionResult Iletisim()
        {
            List<EMLAKCI> emlakcilar = db.EMLAKCI.ToList();
            return View(emlakcilar);
        }
        public ActionResult Incele(int id)
        {
            //Evin idsini alarak o id ile uyan kaydin detaylarini goruntuler
            List<EV> evler = db.EV.ToList();
            return View(db.EV.Where(i => i.EVID == id).FirstOrDefault());
        }
        //public ActionResult KullaniciSayfa()
        //{
        //    return View();
        //}
    }
}