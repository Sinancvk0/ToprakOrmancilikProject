using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Slider:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
