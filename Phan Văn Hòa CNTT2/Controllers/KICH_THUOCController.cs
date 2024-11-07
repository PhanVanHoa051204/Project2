using System;
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
    public class KICH_THUOCController : Controller
    {
        private PhanVanHoa_K22CNTT2Entities db = new PhanVanHoa_K22CNTT2Entities();

        // GET: KICH_THUOC
        public ActionResult Index()
        {
            var kICH_THUOC = db.KICH_THUOC.Include(k => k.SAN_PHAM);
            return View(kICH_THUOC.ToList());
        }

        // GET: KICH_THUOC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KICH_THUOC kICH_THUOC = db.KICH_THUOC.Find(id);
            if (kICH_THUOC == null)
            {
                return HttpNotFound();
            }
            return View(kICH_THUOC);
        }

        // GET: KICH_THUOC/Create
        public ActionResult Create()
        {
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM");
            return View();
        }

        // POST: KICH_THUOC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_KICH_THUOC,MA_SAN_PHAM,KICH_THUOC1,HE_SO_GIA")] KICH_THUOC kICH_THUOC)
        {
            if (ModelState.IsValid)
            {
                db.KICH_THUOC.Add(kICH_THUOC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", kICH_THUOC.MA_SAN_PHAM);
            return View(kICH_THUOC);
        }

        // GET: KICH_THUOC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KICH_THUOC kICH_THUOC = db.KICH_THUOC.Find(id);
            if (kICH_THUOC == null)
            {
                return HttpNotFound();
            }
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", kICH_THUOC.MA_SAN_PHAM);
            return View(kICH_THUOC);
        }

        // POST: KICH_THUOC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_KICH_THUOC,MA_SAN_PHAM,KICH_THUOC1,HE_SO_GIA")] KICH_THUOC kICH_THUOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kICH_THUOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", kICH_THUOC.MA_SAN_PHAM);
            return View(kICH_THUOC);
        }

        // GET: KICH_THUOC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KICH_THUOC kICH_THUOC = db.KICH_THUOC.Find(id);
            if (kICH_THUOC == null)
            {
                return HttpNotFound();
            }
            return View(kICH_THUOC);
        }

        // POST: KICH_THUOC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KICH_THUOC kICH_THUOC = db.KICH_THUOC.Find(id);
            db.KICH_THUOC.Remove(kICH_THUOC);
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
