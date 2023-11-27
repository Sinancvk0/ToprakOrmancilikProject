using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ToprakProject.ViewComponents
{
    public class MainSlider :ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
