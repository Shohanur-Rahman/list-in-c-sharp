using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
