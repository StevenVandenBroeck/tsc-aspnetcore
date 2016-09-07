using Microsoft.AspNetCore.Mvc;

namespace TscWebApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
