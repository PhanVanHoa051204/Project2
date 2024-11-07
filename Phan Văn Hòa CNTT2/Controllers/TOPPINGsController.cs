﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Phan_Văn_Hòa_CNTT2.Models;

namespace Phan_Văn_Hòa_CNTT2.Controllers
{
    public class TOPPINGsController : Controller
    {
        private PhanVanHoa_K22CNTT2Entities db = new PhanVanHoa_K22CNTT2Entities();

        // GET: TOPPINGs
        public ActionResult Index()
        {
            return View(db.TOPPINGs.ToList());
        }

        // GET: TOPPINGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING tOPPING = db.TOPPINGs.Find(id);
            if (tOPPING == null)
            {
                return HttpNotFound();
            }
            return View(tOPPING);
        }

        // GET: TOPPINGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TOPPINGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_TOPPING,TEN_TOPPING,GIA_TOPPING")] TOPPING tOPPING)
        {
            if (ModelState.IsValid)
            {
                db.TOPPINGs.Add(tOPPING);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tOPPING);
        }

        // GET: TOPPINGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING tOPPING = db.TOPPINGs.Find(id);
            if (tOPPING == null)
            {
                return HttpNotFound();
            }
            return View(tOPPING);
        }

        // POST: TOPPINGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_TOPPING,TEN_TOPPING,GIA_TOPPING")] TOPPING tOPPING)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tOPPING).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tOPPING);
        }

        // GET: TOPPINGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING tOPPING = db.TOPPINGs.Find(id);
            if (tOPPING == null)
            {
                return HttpNotFound();
            }
            return View(tOPPING);
        }

        // POST: TOPPINGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TOPPING tOPPING = db.TOPPINGs.Find(id);
            db.TOPPINGs.Remove(tOPPING);
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
