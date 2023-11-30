using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Gallery:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();  
        }
    }
}
