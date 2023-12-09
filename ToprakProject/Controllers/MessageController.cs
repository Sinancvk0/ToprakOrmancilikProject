using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;
using ToprakProject.Models;

namespace ToprakProject.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactViewModel contactViewModel)
        {
            _messageService.TAdd(contactViewModel.Message);

            return Ok();
        }
    }
}
