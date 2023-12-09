using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DocumentController : Controller
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetList()
        {
            var values=_documentService.TGetList();
            return Json(values);
        }
        [HttpGet]
        public IActionResult AddDocument()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDocument(Document document,IFormFile image)
        {
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                document.Image = "/images/" + fileName;
            }
            _documentService.TAdd(document);
             return Ok();
        }
        [HttpPost]
        public IActionResult DeleteDocument(int id)
        {
            var values = _documentService.TGetById(id);
            _documentService.TDelete(values);

            return Ok();
        }
    }
}
