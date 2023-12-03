using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
