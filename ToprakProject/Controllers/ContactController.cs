using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;
using ToprakProject.Models;

namespace ToprakProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
  

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
       
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            var ContactViewModel = new ContactViewModel
            {
                Contacts = values,
            };
            return View(ContactViewModel);
        }
    }
}
