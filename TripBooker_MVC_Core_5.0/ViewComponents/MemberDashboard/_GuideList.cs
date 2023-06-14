using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManageer = new GuideManager(new EFGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManageer.TGetList();
            return View(values);
        }
    }
}
