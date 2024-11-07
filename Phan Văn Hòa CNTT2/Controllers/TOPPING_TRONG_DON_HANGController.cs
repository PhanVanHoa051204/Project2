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
    public class TOPPING_TRONG_DON_HANGController : Controller
    {
        private PhanVanHoa_K22CNTT2Entities db = new PhanVanHoa_K22CNTT2Entities();

        // GET: TOPPING_TRONG_DON_HANG
        public ActionResult Index()
        {
            var tOPPING_TRONG_DON_HANG = db.TOPPING_TRONG_DON_HANG.Include(t => t.CHI_TIET_DON_HANG).Include(t => t.TOPPING);
            return View(tOPPING_TRONG_DON_HANG.ToList());
        }

        // GET: TOPPING_TRONG_DON_HANG/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG = db.TOPPING_TRONG_DON_HANG.Find(id);
            if (tOPPING_TRONG_DON_HANG == null)
            {
                return HttpNotFound();
            }
            return View(tOPPING_TRONG_DON_HANG);
        }

        // GET: TOPPING_TRONG_DON_HANG/Create
        public ActionResult Create()
        {
            ViewBag.MA_CHI_TIET_DON_HANG = new SelectList(db.CHI_TIET_DON_HANG, "MA_CHI_TIET_DON_HANG", "MA_CHI_TIET_DON_HANG");
            ViewBag.MA_TOPPING = new SelectList(db.TOPPINGs, "MA_TOPPING", "TEN_TOPPING");
            return View();
        }

        // POST: TOPPING_TRONG_DON_HANG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_TOPPING_DON_HANG,MA_CHI_TIET_DON_HANG,MA_TOPPING,SO_LUONG_TOPPING")] TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG)
        {
            if (ModelState.IsValid)
            {
                db.TOPPING_TRONG_DON_HANG.Add(tOPPING_TRONG_DON_HANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MA_CHI_TIET_DON_HANG = new SelectList(db.CHI_TIET_DON_HANG, "MA_CHI_TIET_DON_HANG", "MA_CHI_TIET_DON_HANG", tOPPING_TRONG_DON_HANG.MA_CHI_TIET_DON_HANG);
            ViewBag.MA_TOPPING = new SelectList(db.TOPPINGs, "MA_TOPPING", "TEN_TOPPING", tOPPING_TRONG_DON_HANG.MA_TOPPING);
            return View(tOPPING_TRONG_DON_HANG);
        }

        // GET: TOPPING_TRONG_DON_HANG/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG = db.TOPPING_TRONG_DON_HANG.Find(id);
            if (tOPPING_TRONG_DON_HANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MA_CHI_TIET_DON_HANG = new SelectList(db.CHI_TIET_DON_HANG, "MA_CHI_TIET_DON_HANG", "MA_CHI_TIET_DON_HANG", tOPPING_TRONG_DON_HANG.MA_CHI_TIET_DON_HANG);
            ViewBag.MA_TOPPING = new SelectList(db.TOPPINGs, "MA_TOPPING", "TEN_TOPPING", tOPPING_TRONG_DON_HANG.MA_TOPPING);
            return View(tOPPING_TRONG_DON_HANG);
        }

        // POST: TOPPING_TRONG_DON_HANG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_TOPPING_DON_HANG,MA_CHI_TIET_DON_HANG,MA_TOPPING,SO_LUONG_TOPPING")] TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tOPPING_TRONG_DON_HANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MA_CHI_TIET_DON_HANG = new SelectList(db.CHI_TIET_DON_HANG, "MA_CHI_TIET_DON_HANG", "MA_CHI_TIET_DON_HANG", tOPPING_TRONG_DON_HANG.MA_CHI_TIET_DON_HANG);
            ViewBag.MA_TOPPING = new SelectList(db.TOPPINGs, "MA_TOPPING", "TEN_TOPPING", tOPPING_TRONG_DON_HANG.MA_TOPPING);
            return View(tOPPING_TRONG_DON_HANG);
        }

        // GET: TOPPING_TRONG_DON_HANG/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG = db.TOPPING_TRONG_DON_HANG.Find(id);
            if (tOPPING_TRONG_DON_HANG == null)
            {
                return HttpNotFound();
            }
            return View(tOPPING_TRONG_DON_HANG);
        }

        // POST: TOPPING_TRONG_DON_HANG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TOPPING_TRONG_DON_HANG tOPPING_TRONG_DON_HANG = db.TOPPING_TRONG_DON_HANG.Find(id);
            db.TOPPING_TRONG_DON_HANG.Remove(tOPPING_TRONG_DON_HANG);
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
