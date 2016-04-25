﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wardrobe2MVC.Models;

namespace Wardrobe2MVC.Controllers
{
    public class PantsController : Controller
    {
        private Wardrobe2MVCContext db = new Wardrobe2MVCContext();

        // GET: Pants
        public ActionResult Index()
        {
            return View(db.Pants.ToList());
        }

        // GET: Pants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pants pants = db.Pants.Find(id);
            if (pants == null)
            {
                return HttpNotFound();
            }
            return View(pants);
        }

        // GET: Pants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PantID,Nickname,PhotoURL,Type,Color,Season,Occasion")] Pants pants)
        {
            if (ModelState.IsValid)
            {
                db.Pants.Add(pants);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pants);
        }

        // GET: Pants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pants pants = db.Pants.Find(id);
            if (pants == null)
            {
                return HttpNotFound();
            }
            return View(pants);
        }

        // POST: Pants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PantID,Nickname,PhotoURL,Type,Color,Season,Occasion")] Pants pants)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pants).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pants);
        }

        // GET: Pants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pants pants = db.Pants.Find(id);
            if (pants == null)
            {
                return HttpNotFound();
            }
            return View(pants);
        }

        // POST: Pants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pants pants = db.Pants.Find(id);
            db.Pants.Remove(pants);
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
