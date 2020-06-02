using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public decimal Price { get; set; }

        [Display(Name = "وزن")]
        public long Weight { get; set; }

        [Display(Name = "واحد")]
        public int UnitProductId { get; set; }

    }
}
