using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
