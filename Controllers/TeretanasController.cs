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
    public class TeretanasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Teretanas
        public ActionResult Index()
        {
            var teretanas = db.Teretanas.Include(t => t.SifTeretana);
            return View(teretanas.ToList());
        }

        public ActionResult Contact()
        {
            var teretanas = db.Teretanas.Include(t => t.SifTeretana);
            return View(teretanas.ToList());
        }

        // GET: Teretanas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teretana teretana = db.Teretanas.Find(id);
            if (teretana == null)
            {
                return HttpNotFound();
            }
            return View(teretana);
        }

        // GET: Teretanas/Create
        public ActionResult Create()
        {
            ViewBag.Sifra = new SelectList(db.SifTeretanas, "Sifra", "Naziv");
            return View();
        }

        // POST: Teretanas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sifra,Adresa,Kapacitet,Telefon")] Teretana teretana)
        {
            if (ModelState.IsValid)
            {
                db.Teretanas.Add(teretana);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Sifra = new SelectList(db.SifTeretanas, "Sifra", "Naziv", teretana.Sifra);
            return View(teretana);
        }

        // GET: Teretanas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teretana teretana = db.Teretanas.Find(id);
            if (teretana == null)
            {
                return HttpNotFound();
            }
            ViewBag.Sifra = new SelectList(db.SifTeretanas, "Sifra", "Naziv", teretana.Sifra);
            return View(teretana);
        }

        // POST: Teretanas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sifra,Adresa,Kapacitet,Telefon")] Teretana teretana)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teretana).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Sifra = new SelectList(db.SifTeretanas, "Sifra", "Naziv", teretana.Sifra);
            return View(teretana);
        }

        // GET: Teretanas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teretana teretana = db.Teretanas.Find(id);
            if (teretana == null)
            {
                return HttpNotFound();
            }
            return View(teretana);
        }

        // POST: Teretanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Teretana teretana = db.Teretanas.Find(id);
            db.Teretanas.Remove(teretana);
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
