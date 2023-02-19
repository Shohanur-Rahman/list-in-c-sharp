using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Diagnostics;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<Student> students = new List<Student>();

            var studnet = new Student()
            {
                Id = 1,
                FirstName = "Tamim",
                LastName = "Iqbal",
                Mobile = "01750519157",
                Email = "tamim@gmail.com"
            };
            students.Add(studnet);

            var studnet2 = new Student()
            {
                Id = 2,
                FirstName = "Shakib",
                LastName = "Al Hasan",
                Mobile = "01750519157",
                Email = "shakib@gmail.com"
            };
            students.Add(studnet2);

            var studnet3 = new Student()
            {
                Id = 3,
                FirstName = "Mushfiqur",
                LastName = "Rahim",
                Mobile = "01750519157",
                Email = "mushfiq@gmail.com"
            };
            students.Add(studnet3);

            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}