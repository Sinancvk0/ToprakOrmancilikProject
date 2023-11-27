using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Questions:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
