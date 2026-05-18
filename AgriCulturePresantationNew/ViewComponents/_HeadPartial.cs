using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresantationNew.ViewComponents
{
    public class _HeadPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
