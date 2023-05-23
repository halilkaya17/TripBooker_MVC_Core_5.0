using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.ViewComponents.Default
{
    public class _SubAboutPartial : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            return View(values);
        }

    }

}