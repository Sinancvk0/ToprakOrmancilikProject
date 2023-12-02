using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contact;

        public ContactController(IContactService contact)
        {
            _contact = contact;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values= _contact.TGetList();
            return Json(values);
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contact.TAdd(contact);  
            return Ok();
        }
        [HttpPost]
        public IActionResult DeleteContact(int id)
        {
            var values=_contact.TGetById(id);
            _contact.TDelete(values);   
            return Ok();    
        }
    }
}
