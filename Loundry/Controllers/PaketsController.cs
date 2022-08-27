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
    public class PaketsController : Controller
    {
        private loundryEntities db = new loundryEntities();

        // GET: Pakets
        public ActionResult Index()
        {
            return View(db.Pakets.ToList());
        }

        // GET: Pakets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Pakets.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // GET: Pakets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pakets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Paket,Nama_Paket,Harga")] Paket paket)
        {
            if (ModelState.IsValid)
            {
                db.Pakets.Add(paket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paket);
        }

        // GET: Pakets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Pakets.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: Pakets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Paket,Nama_Paket,Harga")] Paket paket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paket);
        }

        // GET: Pakets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Pakets.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: Pakets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paket paket = db.Pakets.Find(id);
            db.Pakets.Remove(paket);
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
