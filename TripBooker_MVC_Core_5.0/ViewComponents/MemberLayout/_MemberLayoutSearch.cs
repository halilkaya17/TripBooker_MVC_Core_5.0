﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}