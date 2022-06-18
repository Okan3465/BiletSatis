using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanGoluCanavari.Business.Concrete;
using VanGoluCanavari.Data.Concrete;
using VanGoluCanavari.Entity;

namespace VanGoluCanavari.WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCoreCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CommentAdd(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ComentStatus = true;
            cm.AddComment(p);
            return View();
        }
    }
}
