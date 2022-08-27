using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Loundry.Models;

namespace Loundry.Controllers
{
    public class PewangiController : Controller
    {
        private loundryEntities db = new loundryEntities();

        // GET: Pewangi
        public ActionResult Index()
        {
            return View(db.Pewangis.ToList());
        }

        // GET: Pewangi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pewangi pewangi = db.Pewangis.Find(id);
            if (pewangi == null)
            {
                return HttpNotFound();
            }
            return View(pewangi);
        }

        // GET: Pewangi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pewangi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Pewangi,Nama_Pewangi")] Pewangi pewangi)
        {
            if (ModelState.IsValid)
            {
                db.Pewangis.Add(pewangi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pewangi);
        }

        // GET: Pewangi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pewangi pewangi = db.Pewangis.Find(id);
            if (pewangi == null)
            {
                return HttpNotFound();
            }
            return View(pewangi);
        }

        // POST: Pewangi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Pewangi,Nama_Pewangi")] Pewangi pewangi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pewangi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pewangi);
        }

        // GET: Pewangi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pewangi pewangi = db.Pewangis.Find(id);
            if (pewangi == null)
            {
                return HttpNotFound();
            }
            return View(pewangi);
        }

        // POST: Pewangi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pewangi pewangi = db.Pewangis.Find(id);
            db.Pewangis.Remove(pewangi);
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
