using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
