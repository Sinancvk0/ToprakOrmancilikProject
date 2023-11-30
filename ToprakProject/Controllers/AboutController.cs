using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
