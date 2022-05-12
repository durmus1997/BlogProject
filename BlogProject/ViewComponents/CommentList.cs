using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke(int postId)
        {
            var commentValues = new List<UserComment>
            {
                new UserComment {ID=1,UserName="Durmuş"},
                new UserComment {ID=2,UserName="Muhammet"},
                new UserComment {ID=3,UserName="Bilal"},
            };
            return View(commentValues);
        }
    }
}
