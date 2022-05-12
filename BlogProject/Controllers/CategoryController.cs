using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoryManager _cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = _cm.GetAllCategories();
            return View(values);
        }
    }
}
