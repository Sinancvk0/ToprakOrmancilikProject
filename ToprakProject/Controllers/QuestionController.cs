﻿using Bussiness.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    [AllowAnonymous]

    public class QuestionController : Controller
    {
    
        private readonly IQuestionService _ques;
  
        public QuestionController(IQuestionService ques)
        {
            _ques = ques;
        }

        public IActionResult Index()
        {
            var values=_ques.TGetList();
            return View(values);
        }
    }
}
