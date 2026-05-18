using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresantationNew.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
