using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values=_blogService.TGetList(); 
            return View(values);
        }
        public IActionResult Details(int id)
        {
            var detail = _blogService.TGetById(id);
            if (detail == null)
            {
                return NotFound();
            }

            return View(detail);
        }
    }
}
