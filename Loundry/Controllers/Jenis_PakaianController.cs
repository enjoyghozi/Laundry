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
    public class Jenis_PakaianController : Controller
    {
        private loundryEntities db = new loundryEntities();

        // GET: Jenis_Pakaian
        public ActionResult Index()
        {
            return View(db.Jenis_Pakaian.ToList());
        }

        // GET: Jenis_Pakaian/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jenis_Pakaian jenis_Pakaian = db.Jenis_Pakaian.Find(id);
            if (jenis_Pakaian == null)
            {
                return HttpNotFound();
            }
            return View(jenis_Pakaian);
        }

        // GET: Jenis_Pakaian/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jenis_Pakaian/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Jenis_Pakaian,Nama_Pakaian,Harga")] Jenis_Pakaian jenis_Pakaian)
        {
            if (ModelState.IsValid)
            {
                db.Jenis_Pakaian.Add(jenis_Pakaian);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jenis_Pakaian);
        }

        // GET: Jenis_Pakaian/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jenis_Pakaian jenis_Pakaian = db.Jenis_Pakaian.Find(id);
            if (jenis_Pakaian == null)
            {
                return HttpNotFound();
            }
            return View(jenis_Pakaian);
        }

        // POST: Jenis_Pakaian/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Jenis_Pakaian,Nama_Pakaian,Harga")] Jenis_Pakaian jenis_Pakaian)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jenis_Pakaian).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jenis_Pakaian);
        }

        // GET: Jenis_Pakaian/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jenis_Pakaian jenis_Pakaian = db.Jenis_Pakaian.Find(id);
            if (jenis_Pakaian == null)
            {
                return HttpNotFound();
            }
            return View(jenis_Pakaian);
        }

        // POST: Jenis_Pakaian/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jenis_Pakaian jenis_Pakaian = db.Jenis_Pakaian.Find(id);
            db.Jenis_Pakaian.Remove(jenis_Pakaian);
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
