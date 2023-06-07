using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrenyReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}
