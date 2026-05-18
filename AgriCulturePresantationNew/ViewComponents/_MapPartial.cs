using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresantationNew.ViewComponents
{
    public class _MapPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            AgriCultureContext agriCultureContext = new AgriCultureContext();
            var values = agriCultureContext.Addresses.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
