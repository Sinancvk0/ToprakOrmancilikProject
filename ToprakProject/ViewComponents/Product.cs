using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Product:ViewComponent
    {
        private readonly IProductService _product;

        public Product(IProductService product)
        {
            _product = product;
        }

        public IViewComponentResult Invoke()
        {
            var values=_product.TGetList(); 
            return View(values);
        }
    }
}
