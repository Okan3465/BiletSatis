using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanGoluCanavari.Business.Abstract;
using VanGoluCanavari.Data.Abstract;
using VanGoluCanavari.Entity;

namespace VanGoluCanavari.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddComment(Comment comment)
        {
            _commentRepository.Create(comment);
        }

        public List<Comment> GetList()
        {
            return _commentRepository.GetAll();
        }
    }
}
