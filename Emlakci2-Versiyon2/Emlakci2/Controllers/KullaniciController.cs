using Emlakci2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlakci2.Controllers
{
    public class KullaniciController : Controller
    {
        Model1 db = new Model1();
        // GET: Kullanici
        public ActionResult Index()
        {
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
    }

}