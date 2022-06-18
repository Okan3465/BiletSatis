using VanGoluCanavari.Data.Abstract;
using VanGoluCanavari.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanGoluCanavari.Data.Concrete
{
   public class EfCoreCityRepository : EfCoreGenericRepository<City, TurContext>, ICityRepository
    {
        public string cityname()
        {
            throw new NotImplementedException();
        }
    }
}
