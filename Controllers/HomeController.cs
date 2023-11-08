using IGCwebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IGCwebsite.Controllers
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

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult productNav()
        {
            return View();
        }
        public IActionResult FarmModule()
        {
            return View();
        }
        public IActionResult BroilerFarm()
        {
            return View();
        }
        public IActionResult BreederFarm()
        {
            return View();
        }
        public IActionResult LayerFarm()
        {
            return View();
        }
        public IActionResult FeedMill()
        {
            return View();
        }
        public IActionResult Hatchery()
        {
            return View();
        }
        public IActionResult Processes()
        {
            return View();
        }
        public IActionResult SupplyChain()
        {
            return View();
        }
        public IActionResult NewsandUpdates()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult BookingDemo()
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
