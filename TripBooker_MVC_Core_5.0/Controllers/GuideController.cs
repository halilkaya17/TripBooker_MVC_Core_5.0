using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());
        public IActionResult Index()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}