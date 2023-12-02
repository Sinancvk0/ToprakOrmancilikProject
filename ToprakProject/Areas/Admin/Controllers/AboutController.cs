using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values=_aboutService.TGetList();    
            return Json(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(About about, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                about.Image = "/images/" + fileName;
            }
            _aboutService.TAdd(about);
            return Ok();
        }
        [HttpPost]

        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);

            _aboutService.TDelete(values);

            return Ok();
        }
    }
}
