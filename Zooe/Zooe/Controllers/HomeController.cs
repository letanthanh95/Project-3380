using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zooe.Models;
using Zooe.Team10;

namespace Zooe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Sourvenirs()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TicketIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Card()
        {
            return View();
        }

        [HttpGet("{firstName}/{lastName}/{address}")]

        public string GetQuery(string id, string firstName, string lastName, string address)
        {
            return $"{firstName}:{lastName}:{address}";
        }
        public IActionResult Report()
        {
            Models.ReportContext context = HttpContext.RequestServices.GetService(typeof(Models.ReportContext)) as Models.ReportContext;

            return View(context.GetReports());
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
