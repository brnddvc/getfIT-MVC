using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using getfitEF.Models;

namespace getfitEF.Controllers
{
    public class UplataIsplatasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UplataIsplatas
        public ActionResult Index()
        {
            var uplataIsplatas = db.UplataIsplatas.Include(u => u.SifGodina).Include(u => u.SifMjesec);
            return View(uplataIsplatas.ToList());
        }

        // GET: UplataIsplatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UplataIsplata uplataIsplata = db.UplataIsplatas.Find(id);
            if (uplataIsplata == null)
            {
                return HttpNotFound();
            }
            return View(uplataIsplata);
        }

        // GET: UplataIsplatas/Create
        public ActionResult Create()
        {
            ViewBag.Sifra = new SelectList(db.SifGodinas, "Sifra", "Sifra");
            ViewBag.Sifra1 = new SelectList(db.SifMjesecs, "Sifra1", "Naziv");
            return View();
        }

        // POST: UplataIsplatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sifra,Sifra1,Uplata,Isplata")] UplataIsplata uplataIsplata)
        {
            if (ModelState.IsValid)
            {
                db.UplataIsplatas.Add(uplataIsplata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Sifra = new SelectList(db.SifGodinas, "Sifra", "Sifra", uplataIsplata.Sifra);
            ViewBag.Sifra1 = new SelectList(db.SifMjesecs, "Sifra1", "Naziv", uplataIsplata.Sifra1);
            return View(uplataIsplata);
        }

        // GET: UplataIsplatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UplataIsplata uplataIsplata = db.UplataIsplatas.Find(id);
            if (uplataIsplata == null)
            {
                return HttpNotFound();
            }
            ViewBag.Sifra = new SelectList(db.SifGodinas, "Sifra", "Sifra", uplataIsplata.Sifra);
            ViewBag.Sifra1 = new SelectList(db.SifMjesecs, "Sifra1", "Naziv", uplataIsplata.Sifra1);
            return View(uplataIsplata);
        }

        // POST: UplataIsplatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sifra,Sifra1,Uplata,Isplata")] UplataIsplata uplataIsplata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uplataIsplata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Sifra = new SelectList(db.SifGodinas, "Sifra", "Sifra", uplataIsplata.Sifra);
            ViewBag.Sifra1 = new SelectList(db.SifMjesecs, "Sifra1", "Naziv", uplataIsplata.Sifra1);
            return View(uplataIsplata);
        }

        // GET: UplataIsplatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UplataIsplata uplataIsplata = db.UplataIsplatas.Find(id);
            if (uplataIsplata == null)
            {
                return HttpNotFound();
            }
            return View(uplataIsplata);
        }

        // POST: UplataIsplatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UplataIsplata uplataIsplata = db.UplataIsplatas.Find(id);
            db.UplataIsplatas.Remove(uplataIsplata);
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
