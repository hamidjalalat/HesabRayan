using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class FactorDetail:BaseEntity
    {
        public FactorDetail() : base()
        {

        }
        [Display(Name = "نام کالا")]
        public string Name { get; set; }

        [Display(Name = "قیمت")]
        public Int64 Price { get; set; }

        [Display(Name = "وزن")]
        public Int64 Weight { get; set; }

        [Display(Name = "واحد")]
        public string UnitProduct { get; set; }

        [Display(Name = "تعداد")]
        public int Count { get; set; }
        public Guid FactorId { get; set; }
        public virtual Factor Factor { get; set; }
    }
}
