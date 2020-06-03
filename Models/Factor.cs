using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Factor
    {
        public Factor() : base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string NameCustomer { get; set; }

        public virtual List<FactorDetail> FactorDetails { get; set; }

    }
}
