using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Header: ViewComponent
    {
        private readonly IProductService _productService;

        public Header(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_productService.TGetList();

            return View(values);  
        }
    }
}
