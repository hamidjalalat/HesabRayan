using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UnitProductRepository:Repository<Models.UnitProduct>,IUnitProductRepository
    {
        public UnitProductRepository(Models.DataBaseContext databaseContext)
			: base(databaseContext)
		{
        }
    }
}
