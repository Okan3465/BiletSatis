using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanGoluCanavari.Data.Abstract;
using VanGoluCanavari.Entity;

namespace VanGoluCanavari.Data.Concrete
{
  public class EfCoreCommentRepository : EfCoreGenericRepository<Comment, TurContext>, ICommentRepository
    {

    }
}
