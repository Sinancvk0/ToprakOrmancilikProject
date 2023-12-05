using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
