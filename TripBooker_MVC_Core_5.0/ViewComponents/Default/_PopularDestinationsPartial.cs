using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {
        DestinationManager destinationManager= new DestinationManager(new EFDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

    }
}
