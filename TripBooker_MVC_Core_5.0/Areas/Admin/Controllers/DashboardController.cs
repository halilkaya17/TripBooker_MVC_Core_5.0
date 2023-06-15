using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
