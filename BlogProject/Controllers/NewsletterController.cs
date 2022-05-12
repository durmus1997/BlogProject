using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class NewsletterController : Controller
    {

        NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter newsletter)
        {
            newsletter.MailStatus = true;
            nm.AddNewsletter(newsletter);
            return PartialView();
        }
    }
}
