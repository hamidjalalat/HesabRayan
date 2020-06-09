using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ViewModels
{
   public class ProductViewModel
    {
        public ProductViewModel() : base()
        {

        }
        public int Id { get; set; }

        [Display(Name = "نام کالا")]
        [Remote(action: "CheckProductname", controller: "Products", areaName: "",
            ErrorMessage = "نام کالا تکراری می باشد")]
        public string Name { get; set; }

        [Display(Name = "قیمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن قیمت الزامی می باشد")]
        public Int64 Price { get; set; }

        [Display(Name = "وزن")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن وزن الزامی می باشد")]
        public Int64 Weight { get; set; }

        [Display(Name = "واحد")]
        public int UnitProductId { get; set; }

        [Display(Name = "واحد")]
        public string UnitProduct { get; set; }
    }
}
