using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
