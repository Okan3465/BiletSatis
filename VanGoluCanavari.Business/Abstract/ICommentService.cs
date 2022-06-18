using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanGoluCanavari.Entity;

namespace VanGoluCanavari.Business.Abstract
{
   public interface ICommentService
    {
        void AddComment(Comment comment);

        List<Comment> GetList();
    }
}
