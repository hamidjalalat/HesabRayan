using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class ProductViewModel
    {
        public ProductViewModel() : base()
        {

        }
        public int Id { get; set; }

        [Display(Name = "نام کالا")]
        public string Name { get; set; }

        [Display(Name = "قیمت")]
        public Int64 Price { get; set; }

        [Display(Name = "وزن")]
        public Int64 Weight { get; set; }

        [Display(Name = "واحد")]
        public int UnitProductId { get; set; }

        [Display(Name = "واحد")]
        public string UnitProduct { get; set; }
    }
}
