using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Featured:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
