using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }

        public IActionResult Index()
        {
            var values= _product.TGetList();    
            return View(values);
        }
    }
}
