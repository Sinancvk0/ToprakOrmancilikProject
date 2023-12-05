using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IMessageService _message;

        public MessageController(IMessageService message)
        {
            _message = message;
        }

        public IActionResult Index()
        {
            var values = _message.TGetList();
            return View(values);
        }
        public IActionResult Details(int id)
        {
            var detail = _message.TGetById(id);
            if (detail == null)
            {
                return NotFound();
            }

            return View(detail);

          
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _message.TGetById(id);

            _message.TDelete(values);

            return Ok();

        }
    }
}
