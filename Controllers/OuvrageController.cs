using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP06.DAL;
using TP06.Models;

namespace TP06.Controllers
{
    public class OuvrageController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Ouvrage
        public ActionResult Index()
        {
            return View(db.Ouvrages.ToList());
        }

        // GET: Ouvrage/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.Ouvrages.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // GET: Ouvrage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ouvrage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titre,Descriptif,Prix")] Ouvrage ouvrage)
        {
            if (ModelState.IsValid)
            {
                db.Ouvrages.Add(ouvrage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ouvrage);
        }

        // GET: Ouvrage/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.Ouvrages.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // POST: Ouvrage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titre,Descriptif,Prix")] Ouvrage ouvrage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ouvrage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ouvrage);
        }

        // GET: Ouvrage/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ouvrage ouvrage = db.Ouvrages.Find(id);
            if (ouvrage == null)
            {
                return HttpNotFound();
            }
            return View(ouvrage);
        }

        // POST: Ouvrage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ouvrage ouvrage = db.Ouvrages.Find(id);
            db.Ouvrages.Remove(ouvrage);
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
