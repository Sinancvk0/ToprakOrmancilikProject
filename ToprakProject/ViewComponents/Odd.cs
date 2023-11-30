using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Odd:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
