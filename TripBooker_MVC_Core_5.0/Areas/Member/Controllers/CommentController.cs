using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
