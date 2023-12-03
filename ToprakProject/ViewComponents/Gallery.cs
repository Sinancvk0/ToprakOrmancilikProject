using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Gallery:ViewComponent
    {
        private readonly IGalleryService _galleryService;

        public Gallery(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _galleryService.TGetList();
            return View(values);  
        }
    }
}
