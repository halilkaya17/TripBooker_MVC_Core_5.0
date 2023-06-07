using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.Areas.Member.Models;

namespace TripBooker_MVC_Core_5._0.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail=values.Email;
            userEditViewModel.imgurl = values.ImageUrl;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename = Guid.NewGuid() + extension; 
                var savelocation = resource + "/wwwroot/UserImages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                user.ImageUrl=imagename;
            }
            user.Name=p.name;
            user.Surname=p.surname;
            user.Email = p.mail;            
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }    
            return View();
        }
    }
}
