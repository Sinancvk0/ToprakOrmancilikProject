﻿using Microsoft.AspNetCore.Mvc;

namespace ToprakProject.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
