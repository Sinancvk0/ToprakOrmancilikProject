using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using ToprakProject.Models;

namespace ToprakProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IDocumentService _documentService;

        public AboutController(IAboutService aboutService, IDocumentService documentService)
        {
            _aboutService = aboutService;
            _documentService = documentService;
        }

        public IActionResult Index()
        {
            var aboutValues = _aboutService.TGetList(); 
            var documentValues = _documentService.TGetList(); 

        
            var combinedModel = new CombinedModel
            {
                Abouts = aboutValues,
                Documents = documentValues
            };

            return View(combinedModel);
        }
    }
}
