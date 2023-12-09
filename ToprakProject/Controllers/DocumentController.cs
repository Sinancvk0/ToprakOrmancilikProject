using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    [AllowAnonymous]
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
     
            return View();
        }
    }
}
