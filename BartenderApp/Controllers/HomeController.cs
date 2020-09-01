using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BartenderApp.Models;
/// <summary>
/// It may not look like much but I did put quite a bit of time into this project. This is round 3 of full on restarts for the application.
/// Most of the time spent on troubleshooting and writing the code in the first place was torublesome becuase I could not for the life of me find resources to help with syntax and general knowledge.
/// By the time I found those resources I didnt have enough time to properly finish the code
/// I made sure to mark everything I could figure out
/// </summary>
namespace BartenderApp.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
