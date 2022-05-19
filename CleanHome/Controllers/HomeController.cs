using CleanHome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CleanHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string lang)
        {
            if (lang == null)
            return View("indexen");

            if (lang == "EN")
                return View("indexen");

            if (lang == "BG")
                return View("indexbg");

            if (lang == "DT")
                return View("index");

            return View("indexen");
        }

        public IActionResult Service(string lang)
        {
            if (lang == null)
                return View("serviceen");

            if (lang == "EN")
                return View("serviceen");

            if (lang == "BG")
                return View("servicebg");

            if (lang == "DT")
                return View("index");

            return View("serviceen");
        }

        public IActionResult Contact(string lang)
        {
            if (lang == null)
                return View("contacten");

            if (lang == "EN")
                return View("contacten");

            if (lang == "BG")
                return View("contactbg");

            if (lang == "DT")
                return View("contact");

            return View("contacten");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}