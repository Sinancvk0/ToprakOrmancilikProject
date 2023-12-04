using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            var values = _galleryService.TGetList();
            return View(values);
        }
    }
}
