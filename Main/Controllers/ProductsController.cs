using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;
using Infrastructure;

namespace HJ_Template_MVC.Controllers
{
    public partial class ProductsController : BaseController
    {

        // GET: Products
        public virtual ActionResult Index()
        {
            return View(MyUnitOfWork.ProductRepository.Get());
        }

        // GET: Products/Details/5
        public virtual ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = MyUnitOfWork.ProductRepository.GetById(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public virtual ActionResult Create()
        {
            ViewBag.UnitProductId = new SelectList(db.UnitProducts, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create([Bind(Include = "Id,Name,Price,Weight,UnitProductId")] Product product)
        {
            if (ModelState.IsValid)
            {
                MyUnitOfWork.ProductRepository.Insert(product);
                MyUnitOfWork.Save();
           
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = MyUnitOfWork.ProductRepository.GetById(id.Value);

            ViewBag.UnitProductId = new SelectList(db.UnitProducts, "Id", "Name", product.UnitProductId);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit([Bind(Include = "Id,Name,Price,Weight,UnitProductId")] Product product)
        {
            if (ModelState.IsValid)
            {
                MyUnitOfWork.ProductRepository.Update(product);
                MyUnitOfWork.Save();
            
                return RedirectToAction("Index");
            }
            ViewBag.UnitProductId = new SelectList(db.UnitProducts, "Id", "Name", product.UnitProductId);
            return View(product);
        }

        // GET: Products/Delete/5
        public virtual ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = MyUnitOfWork.ProductRepository.GetById(id.Value);
         
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            Product product = MyUnitOfWork.ProductRepository.GetById(id);
            MyUnitOfWork.ProductRepository.Delete(product);
            MyUnitOfWork.Save();
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
