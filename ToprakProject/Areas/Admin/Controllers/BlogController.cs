using Bussiness.Services;
using Helper;
using Microsoft.AspNetCore.Mvc;
using Model;
using ToprakProject.ViewComponents;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly FileUpload _fileUpload;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(IBlogService blogService, FileUpload fileUpload, IWebHostEnvironment webHostEnvironment)
        {
            _blogService = blogService;
            _fileUpload = fileUpload;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values=_blogService.TGetList();
            return Json(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                blog.Image = "/images/" + fileName;
            }
            _blogService.TAdd(blog);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteBlog(int id)
        {
           var values=_blogService.TGetById(id);
            _blogService.TDelete(values);   
            return Ok();    

        }
    }
}
