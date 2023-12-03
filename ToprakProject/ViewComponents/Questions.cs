using Bussiness.Services;
using Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.ViewComponents
{
    public class Questions:ViewComponent
    {
       private readonly IQuestionService _questionService;

        public Questions(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _questionService.TGetList();

            return View(values);
        }
    }
}
