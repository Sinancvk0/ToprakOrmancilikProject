using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
