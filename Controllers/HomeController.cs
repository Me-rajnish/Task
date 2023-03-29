using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult HomePage()
        {
            return View();
        }


    }
}