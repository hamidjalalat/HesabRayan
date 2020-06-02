using Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HJ_Template_MVC.Controllers
{
    public partial class UnitProductController : BaseController
    {
        public virtual ActionResult Index()
        {
            return View(MyUnitOfWork.UnitProductRepository.Get());
        }
        // GET: UnitProduct
        public virtual ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create([Bind(Include = "Id,Name")] UnitProduct unitProduct)
        {
            if (ModelState.IsValid)
            {
                MyUnitOfWork.UnitProductRepository.Insert(unitProduct);
                MyUnitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(unitProduct);
        }
    }
}