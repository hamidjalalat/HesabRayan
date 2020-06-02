using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;

namespace HJ_Template_MVC.Controllers
{
    public partial class testUnitProductsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: testUnitProducts
        public virtual ActionResult Index()
        {
            return View(db.UnitProducts.ToList());
        }

        // GET: testUnitProducts/Details/5
        public virtual ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitProduct unitProduct = db.UnitProducts.Find(id);
            if (unitProduct == null)
            {
                return HttpNotFound();
            }
            return View(unitProduct);
        }

        // GET: testUnitProducts/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        // POST: testUnitProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create([Bind(Include = "Id,Name")] UnitProduct unitProduct)
        {
            if (ModelState.IsValid)
            {
                db.UnitProducts.Add(unitProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unitProduct);
        }

        // GET: testUnitProducts/Edit/5
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitProduct unitProduct = db.UnitProducts.Find(id);
            if (unitProduct == null)
            {
                return HttpNotFound();
            }
            return View(unitProduct);
        }

        // POST: testUnitProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit([Bind(Include = "Id,Name")] UnitProduct unitProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unitProduct);
        }

        // GET: testUnitProducts/Delete/5
        public virtual ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitProduct unitProduct = db.UnitProducts.Find(id);
            if (unitProduct == null)
            {
                return HttpNotFound();
            }
            return View(unitProduct);
        }

        // POST: testUnitProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            UnitProduct unitProduct = db.UnitProducts.Find(id);
            db.UnitProducts.Remove(unitProduct);
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
