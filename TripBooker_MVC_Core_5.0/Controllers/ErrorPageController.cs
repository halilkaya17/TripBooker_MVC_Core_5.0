using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
