﻿using Bussiness.Services;

using Microsoft.AspNetCore.Mvc;
using Model;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _galleryService.TGetList();
            return Json(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Gallery gallery, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                gallery.Image = "/images/" + fileName;
            }
            _galleryService.TAdd(gallery);
            return Ok();
        }
        [HttpPost]

        public IActionResult DeleteGallery(int id)
        {
            var values = _galleryService.TGetById(id);

            _galleryService.TDelete(values);

            return Ok();
        }

    }
}
