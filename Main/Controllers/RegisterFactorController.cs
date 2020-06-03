using Infrastructure;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace HJ_Template_MVC.Controllers
{
    public partial class RegisterFactorController : BaseController
    {
        // GET: RegisterFactor
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult GetProducts()
        {
            var listProduct = MyUnitOfWork
                .ProductRepository
                .Get()
                .ToList();
            List<ProductViewModel> listProductViewModel = new List<ProductViewModel>();
            foreach (var item in listProduct)
            {
                ProductViewModel vm = new ProductViewModel();
                vm.Id = item.Id;
                vm.Name = item.Name;
                vm.Price = item.Price;
                vm.UnitProduct = MyUnitOfWork.UnitProductRepository.GetById(item.Id).Name;
                vm.Weight = item.Weight;
                vm.UnitProductId = item.UnitProductId;
                listProductViewModel.Add(vm);

            }
            var result = new { listProduct = listProductViewModel };

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public virtual ActionResult GetRegisterFactor(string jsonFactor, string nameCustomer)
        {
            var listFactorDetial = JsonConvert.DeserializeObject<List<FactorDtailViewModel>>(jsonFactor);
            bool status = false;
            try
            {
                Factor oFactor = new Factor();

                oFactor.Date =  DateTime.Now.ToShamsi();
                oFactor.NameCustomer = nameCustomer;
                oFactor.FactorDetails = new List<FactorDetail>();

                foreach (var item in listFactorDetial)
                {
                    FactorDetail oFactorDetail = new FactorDetail();

                    oFactorDetail.Name = item.Name;
                    oFactorDetail.Price = item.Price;
                    oFactorDetail.Weight = item.Weight;
                    oFactorDetail.UnitProduct = item.UnitProduct;
                    oFactorDetail.Id = item.Id;
                    oFactorDetail.FactorId = oFactor.Id;
                    oFactorDetail.Count = item.Count;
                    oFactor.FactorDetails.Add(oFactorDetail);
                }

                db.Factors.Add(oFactor);
                db.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return Json(status);
        }
    }
}