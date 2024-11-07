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
    public class QUAN_TRI_VIENController : Controller
    {
        private PhanVanHoa_K22CNTT2Entities db = new PhanVanHoa_K22CNTT2Entities();

        // GET: QUAN_TRI_VIEN
        public ActionResult Index()
        {
            return View(db.QUAN_TRI_VIEN.ToList());
        }

        // GET: QUAN_TRI_VIEN/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUAN_TRI_VIEN qUAN_TRI_VIEN = db.QUAN_TRI_VIEN.Find(id);
            if (qUAN_TRI_VIEN == null)
            {
                return HttpNotFound();
            }
            return View(qUAN_TRI_VIEN);
        }

        // GET: QUAN_TRI_VIEN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QUAN_TRI_VIEN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MA_QUAN_TRI,TEN_DANG_NHAP,MAT_KHAU,VAI_TRO")] QUAN_TRI_VIEN qUAN_TRI_VIEN)
        {
            if (ModelState.IsValid)
            {
                db.QUAN_TRI_VIEN.Add(qUAN_TRI_VIEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qUAN_TRI_VIEN);
        }

        // GET: QUAN_TRI_VIEN/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUAN_TRI_VIEN qUAN_TRI_VIEN = db.QUAN_TRI_VIEN.Find(id);
            if (qUAN_TRI_VIEN == null)
            {
                return HttpNotFound();
            }
            return View(qUAN_TRI_VIEN);
        }

        // POST: QUAN_TRI_VIEN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MA_QUAN_TRI,TEN_DANG_NHAP,MAT_KHAU,VAI_TRO")] QUAN_TRI_VIEN qUAN_TRI_VIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qUAN_TRI_VIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qUAN_TRI_VIEN);
        }

        // GET: QUAN_TRI_VIEN/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUAN_TRI_VIEN qUAN_TRI_VIEN = db.QUAN_TRI_VIEN.Find(id);
            if (qUAN_TRI_VIEN == null)
            {
                return HttpNotFound();
            }
            return View(qUAN_TRI_VIEN);
        }

        // POST: QUAN_TRI_VIEN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QUAN_TRI_VIEN qUAN_TRI_VIEN = db.QUAN_TRI_VIEN.Find(id);
            db.QUAN_TRI_VIEN.Remove(qUAN_TRI_VIEN);
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
