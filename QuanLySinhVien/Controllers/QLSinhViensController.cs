using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class QLSinhViensController : Controller
    {
        private QLSinhVienEntities db = new QLSinhVienEntities();

        // GET: QLSinhViens
        public ActionResult Index()
        {
            return View(db.QLSinhViens.ToList());
        }

        // GET: QLSinhViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLSinhVien qLSinhVien = db.QLSinhViens.Find(id);
            if (qLSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(qLSinhVien);
        }

        // GET: QLSinhViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QLSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,first_name,last_name,email,gender,ip_address")] QLSinhVien qLSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.QLSinhViens.Add(qLSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qLSinhVien);
        }

        // GET: QLSinhViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLSinhVien qLSinhVien = db.QLSinhViens.Find(id);
            if (qLSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(qLSinhVien);
        }

        // POST: QLSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,first_name,last_name,email,gender,ip_address")] QLSinhVien qLSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qLSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qLSinhVien);
        }

        // GET: QLSinhViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLSinhVien qLSinhVien = db.QLSinhViens.Find(id);
            if (qLSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(qLSinhVien);
        }

        // POST: QLSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QLSinhVien qLSinhVien = db.QLSinhViens.Find(id);
            db.QLSinhViens.Remove(qLSinhVien);
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
