using Microsoft.AspNetCore.Mvc;

namespace GDSTheme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
