using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
     
            return View();
        }
    }
}
