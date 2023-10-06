using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Calculator.Models;

namespace Calculator.Controllers
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
            ViewBag.Operations = Data.operations;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public void GetData(int a, int b)
        {
            Data.a = a;
            Data.b = b;
        }
        [HttpGet]
        public int Operation(int id)
        {
            switch (id)
            {
                case 0: 
                    return Data.a + Data.b;
                case 1:
                    return Data.a - Data.b;
                case 2:
                    return Data.a * Data.b;
                case 3:
                    return Data.a / Data.b;
            }
            return Data.a + Data.b;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}