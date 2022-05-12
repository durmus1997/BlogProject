using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 3;
            cm.CommentAdd(comment);
            return PartialView();
        }

        public PartialViewResult PartialCommentList(int id)
        {
            var values = cm.GetAllComments(id);
            return PartialView(values);
        }
    }
}
