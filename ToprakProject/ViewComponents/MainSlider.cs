using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ToprakProject.ViewComponents
{
    public class MainSlider :ViewComponent
    {
        private readonly ISliderService _slider;

        public MainSlider(ISliderService slider)
        {
            _slider = slider;
        }

        public IViewComponentResult Invoke()
        {
            var values = _slider.TGetList();
            return View(values);
        }
    }
}
