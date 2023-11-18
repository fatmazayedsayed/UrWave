using Microsoft.AspNetCore.Mvc;

namespace UrWave_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
