﻿using System;
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
    public class ZaposleniksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Zaposleniks
        public ActionResult Index()
        {
            var zaposleniks = db.Zaposleniks.Include(z => z.SifSpol);
            return View(zaposleniks.ToList());
        }

        // GET: Zaposleniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zaposlenik zaposlenik = db.Zaposleniks.Find(id);
            if (zaposlenik == null)
            {
                return HttpNotFound();
            }
            return View(zaposlenik);
        }

        // GET: Zaposleniks/Create
        public ActionResult Create()
        {
            ViewBag.Sifra = new SelectList(db.SifSpols, "Sifra", "Naziv");
            return View();
        }

        // POST: Zaposleniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,DatumRodjenja,Sifra,BrojKartice,BrojLicneKarte,AdresaPrebivalista,Telefon,Email")] Zaposlenik zaposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Zaposleniks.Add(zaposlenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Sifra = new SelectList(db.SifSpols, "Sifra", "Naziv", zaposlenik.Sifra);
            return View(zaposlenik);
        }

        // GET: Zaposleniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zaposlenik zaposlenik = db.Zaposleniks.Find(id);
            if (zaposlenik == null)
            {
                return HttpNotFound();
            }
            ViewBag.Sifra = new SelectList(db.SifSpols, "Sifra", "Naziv", zaposlenik.Sifra);
            return View(zaposlenik);
        }

        // POST: Zaposleniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,DatumRodjenja,Sifra,BrojKartice,BrojLicneKarte,AdresaPrebivalista,Telefon,Email")] Zaposlenik zaposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zaposlenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Sifra = new SelectList(db.SifSpols, "Sifra", "Naziv", zaposlenik.Sifra);
            return View(zaposlenik);
        }

        // GET: Zaposleniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zaposlenik zaposlenik = db.Zaposleniks.Find(id);
            if (zaposlenik == null)
            {
                return HttpNotFound();
            }
            return View(zaposlenik);
        }

        // POST: Zaposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zaposlenik zaposlenik = db.Zaposleniks.Find(id);
            db.Zaposleniks.Remove(zaposlenik);
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
