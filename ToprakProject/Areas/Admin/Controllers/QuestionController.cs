using Bussiness.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ToprakProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values=_questionService.TGetList();
            return Json(values);

        }
        [HttpGet]
        public IActionResult AddQue()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQue(Question question)
        {
            _questionService.TAdd(question);
            return Ok();
        }
        [HttpPost]
        public IActionResult DeleteQue(int  id )
        {
            var values = _questionService.TGetById(id);

            _questionService.TDelete(values);

            return Ok();
        }
    }
}
