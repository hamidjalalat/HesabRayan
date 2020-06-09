using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
   public class Product:BaseEntity
    {
        public Product() : base()
        {

        }
        [Display(Name ="نام کالا")]
       
        public string Name { get; set; }

        [Display(Name = "قیمت")]
        public Int64 Price { get; set; }

        [Display(Name = "وزن")]
        public Int64 Weight { get; set; }

        [Display(Name = "واحد")]
        public int UnitProductId { get; set; }

    }
}
