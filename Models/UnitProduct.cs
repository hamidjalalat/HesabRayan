using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class UnitProduct:BaseEntity
    {
        public UnitProduct() : base()
        {

        }
        [Display(Name = "نام واحد کالا")]   
        public string Name { get; set; }

    }
}
