using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class SubAbout :ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }

    }
}
