using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Message:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
