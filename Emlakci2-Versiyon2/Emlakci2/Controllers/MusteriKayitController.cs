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
    public class MusteriKayitController : Controller
    {
        private Model1 db = new Model1();

        // GET: MusteriKayit
        public ActionResult Index()
        {
            return View(db.MUSTERI.ToList());
        }

        // GET: MusteriKayit/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUSTERI mUSTERI = db.MUSTERI.Find(id);
            if (mUSTERI == null)
            {
                return HttpNotFound();
            }
            return View(mUSTERI);
        }

        // GET: MusteriKayit/Create
        [YetkiCreate]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusteriKayit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MUSTERIID,ADSOYAD,TELEFON,MINFIYAT,MAXFIYAT,TUR,IL,SATISDURUM,ESYADURUM,OGRENCIBEKAR,ALINANILANNO")] MUSTERI mUSTERI)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.MUSTERI.Add(mUSTERI);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(mUSTERI);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        // GET: MusteriKayit/Edit/5
        [YetkiEdit]
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUSTERI mUSTERI = db.MUSTERI.Find(id);
            if (mUSTERI == null)
            {
                return HttpNotFound();
            }
            return View(mUSTERI);
        }

        // POST: MusteriKayit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MUSTERIID,ADSOYAD,TELEFON,MINFIYAT,MAXFIYAT,TUR,IL,SATISDURUM,ESYADURUM,OGRENCIBEKAR,ALINANILANNO")] MUSTERI mUSTERI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mUSTERI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mUSTERI);
        }

        // GET: MusteriKayit/Delete/5
        [YetkiDelete]
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUSTERI mUSTERI = db.MUSTERI.Find(id);
            if (mUSTERI == null)
            {
                return HttpNotFound();
            }
            return View(mUSTERI);
        }

        // POST: MusteriKayit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            MUSTERI mUSTERI = db.MUSTERI.Find(id);
            db.MUSTERI.Remove(mUSTERI);
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
