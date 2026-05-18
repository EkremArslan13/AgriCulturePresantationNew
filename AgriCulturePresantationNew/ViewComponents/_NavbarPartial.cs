using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresantationNew.ViewComponents
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
