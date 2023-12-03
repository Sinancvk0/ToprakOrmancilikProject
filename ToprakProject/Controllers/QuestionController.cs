using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
