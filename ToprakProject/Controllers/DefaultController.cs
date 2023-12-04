using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class DefaultController : Controller
    {
        

        public IActionResult Index()
        {
        
            return View();
        }
    }
}
