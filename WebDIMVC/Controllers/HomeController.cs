using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebDIMVC.Models;
using WebDIMVC.services;

namespace WebDIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAwesomeDataService _awesomeDataService;
        public IActionResult Greeting()
        {
            return View();
           

        }
        public HomeController(ILogger<HomeController> logger, IAwesomeDataService awesomeDataService)
        {
            _logger = logger;
            _awesomeDataService = awesomeDataService;
        }

        public IActionResult Index()
        {
            return View();
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
