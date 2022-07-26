using Day1_T1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day1_T1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employee_Page()
        {
            return View();
        }

        public IActionResult Depts_Page()
        {
            return View();
        }
        public IActionResult Contact_Us()
        {
            return View();
        }
        public IActionResult About_Us()
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