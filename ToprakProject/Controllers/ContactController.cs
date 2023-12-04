using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values=_contactService.TGetList();
            return View(values);
        }
    }
}
