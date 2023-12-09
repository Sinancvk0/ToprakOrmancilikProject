using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using ToprakProject.Models;

namespace ToprakProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _db;

        public AboutController(IAboutService db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var values=_db.TGetList();
        
            return View(values);
        }
    }
}
