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
    [YetkiUyeEkle]
    public class KurumsalUyeController : Controller
    {
        private Model1 db = new Model1();

        // GET: KurumsalUye
        public ActionResult Index()
        {
            return View(db.EMLAKCI.ToList());
        }

        // GET: KurumsalUye/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMLAKCI eMLAKCI = db.EMLAKCI.Find(id);
            if (eMLAKCI == null)
            {
                return HttpNotFound();
            }
            return View(eMLAKCI);
        }

        // GET: KurumsalUye/Create
        [YetkiCreate]
        public ActionResult Create()
        {
            return View();
        }

        // POST: KurumsalUye/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMLAKCIID,ADSOYAD,EMAIL,TELEFON,SIFRE,YETKI_CREATE,YETKI_EDIT,YETKI_DELETE")] EMLAKCI eMLAKCI)
        {
            if (ModelState.IsValid)
            {
                db.EMLAKCI.Add(eMLAKCI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMLAKCI);
        }

        // GET: KurumsalUye/Edit/5
        [YetkiEdit]
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMLAKCI eMLAKCI = db.EMLAKCI.Find(id);
            if (eMLAKCI == null)
            {
                return HttpNotFound();
            }
            return View(eMLAKCI);
        }

        // POST: KurumsalUye/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMLAKCIID,ADSOYAD,EMAIL,TELEFON,SIFRE,YETKI_CREATE,YETKI_EDIT,YETKI_DELETE")] EMLAKCI eMLAKCI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMLAKCI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMLAKCI);
        }

        // GET: KurumsalUye/Delete/5
        [YetkiDelete]
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMLAKCI eMLAKCI = db.EMLAKCI.Find(id);
            if (eMLAKCI == null)
            {
                return HttpNotFound();
            }
            return View(eMLAKCI);
        }

        // POST: KurumsalUye/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            EMLAKCI eMLAKCI = db.EMLAKCI.Find(id);
            db.EMLAKCI.Remove(eMLAKCI);
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
