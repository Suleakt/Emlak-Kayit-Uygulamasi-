using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Emlakci2.Models;

namespace Emlakci2.Controllers
{
    public class EvKayitController : Controller
    {
        private Model1 db = new Model1();

        // GET: EvKayit
        public ActionResult Index()
        {
            var eV = db.EV.Include(e => e.EV_SAHIBI);
            return View(eV.ToList());
        }

        // GET: EvKayit/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EV eV = db.EV.Find(id);
            if (eV == null)
            {
                return HttpNotFound();
            }
            return View(eV);
        }

        // GET: EvKayit/Create
        [YetkiCreate]
        public ActionResult Create()
        {
            ViewBag.EVSAHIBIID = new SelectList(db.EV_SAHIBI, "EVSAHIBIID", "AD");
            return View();
        }

        // POST: EvKayit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EVID,IL,ILCE,MAHALLE,SATISDURUM,TUR,ILANNO,FIYAT,ODASAY,METREKARE,EVSAHIBIID,SATILDIMI,IMAGE,KATNO,ADRES,EVYAPIMTARIHI,ESYADURUM,OGRENCIBEKAR,AIDAT,DEPOZITO,BALKON,BANYOSAY,SITEMI,OTOPARK,YAKITTIPI,ISINMATIPI,FIYATTUR,ACIKLAMA")] EV eV)
        {
            if (ModelState.IsValid)
            {
                db.EV.Add(eV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EVSAHIBIID = new SelectList(db.EV_SAHIBI, "EVSAHIBIID", "AD", eV.EVSAHIBIID);
            return View(eV);
        }

        // GET: EvKayit/Edit/5
        [YetkiEdit]
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EV eV = db.EV.Find(id);
            if (eV == null)
            {
                return HttpNotFound();
            }
            ViewBag.EVSAHIBIID = new SelectList(db.EV_SAHIBI, "EVSAHIBIID", "AD", eV.EVSAHIBIID);
            return View(eV);
        }

        // POST: EvKayit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EVID,IL,ILCE,MAHALLE,SATISDURUM,TUR,ILANNO,FIYAT,ODASAY,METREKARE,EVSAHIBIID,SATILDIMI,IMAGE,KATNO,ADRES,EVYAPIMTARIHI,ESYADURUM,OGRENCIBEKAR,AIDAT,DEPOZITO,BALKON,BANYOSAY,SITEMI,OTOPARK,YAKITTIPI,ISINMATIPI,FIYATTUR,ACIKLAMA")] EV eV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EVSAHIBIID = new SelectList(db.EV_SAHIBI, "EVSAHIBIID", "AD", eV.EVSAHIBIID);
            return View(eV);
        }

        // GET: EvKayit/Delete/5
        [YetkiDelete]
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EV eV = db.EV.Find(id);
            if (eV == null)
            {
                return HttpNotFound();
            }
            return View(eV);
        }

        // POST: EvKayit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            EV eV = db.EV.Find(id);
            db.EV.Remove(eV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
