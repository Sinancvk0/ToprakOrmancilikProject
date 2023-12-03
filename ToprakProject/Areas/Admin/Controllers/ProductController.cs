using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

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
            return View();
        }

        [HttpGet]
        public IActionResult GetList()
        {

            var values=_product.TGetList();
            return Json(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product,IFormFile image)
        {
            if (image != null && image.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }


                product.Image = "/images/" + fileName;
            }
            _product.TAdd(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var values = _product.TGetById(id);
            _product.TDelete(values);   

            return Ok();    
        }
        
    }
}
