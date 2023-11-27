using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Product:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
