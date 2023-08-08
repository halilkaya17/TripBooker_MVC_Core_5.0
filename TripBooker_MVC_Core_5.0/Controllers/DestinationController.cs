using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        private readonly UserManager<AppUser> _userManager;
        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        //[HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        //[HttpPost]
        //public IActionResult DestinationDetails(Destination p)
        //{
        //    return View();
        //}
    }
}