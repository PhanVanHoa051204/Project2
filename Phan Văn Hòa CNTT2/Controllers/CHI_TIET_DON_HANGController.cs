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
    public class CHI_TIET_DON_HANGController : Controller
    {
        private PhanVanHoa_K22CNTT2Entities db = new PhanVanHoa_K22CNTT2Entities();

        // GET: CHI_TIET_DON_HANG
        public ActionResult Index()
        {
            var cHI_TIET_DON_HANG = db.CHI_TIET_DON_HANG.Include(c => c.DON_HANG).Include(c => c.KICH_THUOC).Include(c => c.SAN_PHAM);
            return View(cHI_TIET_DON_HANG.ToList());
        }

        // GET: CHI_TIET_DON_HANG/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHI_TIET_DON_HANG cHI_TIET_DON_HANG = db.CHI_TIET_DON_HANG.Find(id);
            if (cHI_TIET_DON_HANG == null)
            {
                return HttpNotFound();
            }
            return View(cHI_TIET_DON_HANG);
        }

        // GET: CHI_TIET_DON_HANG/Create
        public ActionResult Create()
        {
            ViewBag.MA_DON_HANG = new SelectList(db.DON_HANG, "MA_DON_HANG", "TRANG_THAI");
            ViewBag.MA_KICH_THUOC = new SelectList(db.KICH_THUOC, "MA_KICH_THUOC", "KICH_THUOC1");
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM");
            return View();
        }

        // POST: CHI_TIET_DON_HANG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_CHI_TIET_DON_HANG,MA_DON_HANG,MA_SAN_PHAM,MA_KICH_THUOC,SO_LUONG,THANH_TIEN")] CHI_TIET_DON_HANG cHI_TIET_DON_HANG)
        {
            if (ModelState.IsValid)
            {
                db.CHI_TIET_DON_HANG.Add(cHI_TIET_DON_HANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MA_DON_HANG = new SelectList(db.DON_HANG, "MA_DON_HANG", "TRANG_THAI", cHI_TIET_DON_HANG.MA_DON_HANG);
            ViewBag.MA_KICH_THUOC = new SelectList(db.KICH_THUOC, "MA_KICH_THUOC", "KICH_THUOC1", cHI_TIET_DON_HANG.MA_KICH_THUOC);
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", cHI_TIET_DON_HANG.MA_SAN_PHAM);
            return View(cHI_TIET_DON_HANG);
        }

        // GET: CHI_TIET_DON_HANG/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHI_TIET_DON_HANG cHI_TIET_DON_HANG = db.CHI_TIET_DON_HANG.Find(id);
            if (cHI_TIET_DON_HANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MA_DON_HANG = new SelectList(db.DON_HANG, "MA_DON_HANG", "TRANG_THAI", cHI_TIET_DON_HANG.MA_DON_HANG);
            ViewBag.MA_KICH_THUOC = new SelectList(db.KICH_THUOC, "MA_KICH_THUOC", "KICH_THUOC1", cHI_TIET_DON_HANG.MA_KICH_THUOC);
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", cHI_TIET_DON_HANG.MA_SAN_PHAM);
            return View(cHI_TIET_DON_HANG);
        }

        // POST: CHI_TIET_DON_HANG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_CHI_TIET_DON_HANG,MA_DON_HANG,MA_SAN_PHAM,MA_KICH_THUOC,SO_LUONG,THANH_TIEN")] CHI_TIET_DON_HANG cHI_TIET_DON_HANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHI_TIET_DON_HANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MA_DON_HANG = new SelectList(db.DON_HANG, "MA_DON_HANG", "TRANG_THAI", cHI_TIET_DON_HANG.MA_DON_HANG);
            ViewBag.MA_KICH_THUOC = new SelectList(db.KICH_THUOC, "MA_KICH_THUOC", "KICH_THUOC1", cHI_TIET_DON_HANG.MA_KICH_THUOC);
            ViewBag.MA_SAN_PHAM = new SelectList(db.SAN_PHAM, "MA_SAN_PHAM", "TEN_SAN_PHAM", cHI_TIET_DON_HANG.MA_SAN_PHAM);
            return View(cHI_TIET_DON_HANG);
        }

        // GET: CHI_TIET_DON_HANG/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHI_TIET_DON_HANG cHI_TIET_DON_HANG = db.CHI_TIET_DON_HANG.Find(id);
            if (cHI_TIET_DON_HANG == null)
            {
                return HttpNotFound();
            }
            return View(cHI_TIET_DON_HANG);
        }

        // POST: CHI_TIET_DON_HANG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHI_TIET_DON_HANG cHI_TIET_DON_HANG = db.CHI_TIET_DON_HANG.Find(id);
            db.CHI_TIET_DON_HANG.Remove(cHI_TIET_DON_HANG);
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
