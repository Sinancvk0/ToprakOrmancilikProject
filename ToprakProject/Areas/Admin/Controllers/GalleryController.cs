using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
