﻿using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
