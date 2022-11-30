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
    public class TeslimKayitController : Controller
    {
        private Model1 db = new Model1();

        // GET: TeslimKayit
        public ActionResult Index()
        {
            var tESLIM_EDILEN_EV = db.TESLIM_EDILEN_EV.Include(t => t.EV).Include(t => t.MUSTERI);
            return View(tESLIM_EDILEN_EV.ToList());
        }

        // GET: TeslimKayit/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TESLIM_EDILEN_EV tESLIM_EDILEN_EV = db.TESLIM_EDILEN_EV.Find(id);
            if (tESLIM_EDILEN_EV == null)
            {
                return HttpNotFound();
            }
            return View(tESLIM_EDILEN_EV);
        }

        // GET: TeslimKayit/Create
        [YetkiCreate]
        public ActionResult Create()
        {
            ViewBag.EVID = new SelectList(db.EV, "EVID", "IL");
            ViewBag.MUSTERIID = new SelectList(db.MUSTERI, "MUSTERIID", "ADSOYAD");
            return View();
        }

        // POST: TeslimKayit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TESLIMEDILENID,TARIH,ISLEMTAMAMLANDIMI,EVID,MUSTERIID")] TESLIM_EDILEN_EV tESLIM_EDILEN_EV)
        {
            if (ModelState.IsValid)
            {
                db.TESLIM_EDILEN_EV.Add(tESLIM_EDILEN_EV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EVID = new SelectList(db.EV, "EVID", "IL", tESLIM_EDILEN_EV.EVID);
            ViewBag.MUSTERIID = new SelectList(db.MUSTERI, "MUSTERIID", "ADSOYAD", tESLIM_EDILEN_EV.MUSTERIID);
            return View(tESLIM_EDILEN_EV);
        }

        // GET: TeslimKayit/Edit/5
        [YetkiEdit]
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TESLIM_EDILEN_EV tESLIM_EDILEN_EV = db.TESLIM_EDILEN_EV.Find(id);
            if (tESLIM_EDILEN_EV == null)
            {
                return HttpNotFound();
            }
            ViewBag.EVID = new SelectList(db.EV, "EVID", "IL", tESLIM_EDILEN_EV.EVID);
            ViewBag.MUSTERIID = new SelectList(db.MUSTERI, "MUSTERIID", "ADSOYAD", tESLIM_EDILEN_EV.MUSTERIID);
            return View(tESLIM_EDILEN_EV);
        }

        // POST: TeslimKayit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TESLIMEDILENID,TARIH,ISLEMTAMAMLANDIMI,EVID,MUSTERIID")] TESLIM_EDILEN_EV tESLIM_EDILEN_EV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tESLIM_EDILEN_EV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EVID = new SelectList(db.EV, "EVID", "IL", tESLIM_EDILEN_EV.EVID);
            ViewBag.MUSTERIID = new SelectList(db.MUSTERI, "MUSTERIID", "ADSOYAD", tESLIM_EDILEN_EV.MUSTERIID);
            return View(tESLIM_EDILEN_EV);
        }

        // GET: TeslimKayit/Delete/5
        [YetkiDelete]
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TESLIM_EDILEN_EV tESLIM_EDILEN_EV = db.TESLIM_EDILEN_EV.Find(id);
            if (tESLIM_EDILEN_EV == null)
            {
                return HttpNotFound();
            }
            return View(tESLIM_EDILEN_EV);
        }

        // POST: TeslimKayit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            TESLIM_EDILEN_EV tESLIM_EDILEN_EV = db.TESLIM_EDILEN_EV.Find(id);
            db.TESLIM_EDILEN_EV.Remove(tESLIM_EDILEN_EV);
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
