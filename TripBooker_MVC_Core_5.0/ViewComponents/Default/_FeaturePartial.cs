using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TripBooker_MVC_Core_5._0.ViewComponents.Default
{
    public class _FeaturePartial: ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());

        public IViewComponentResult Invoke()
        {
           // var values = featureManager.TGetList();
           //Viewbag.image1=featureManager.get
            return View();
        }
    }
}
