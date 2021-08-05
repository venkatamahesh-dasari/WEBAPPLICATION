using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMVC.Models;
using System.Diagnostics;

namespace SampleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public ViewResult Index()
        {
            ViewBag.Title = "Application";
            ViewData["Property1"] = "App";
            ViewData["Book"] = new BookModel() { Author = "Mahesh", Id = 1 };
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult GetAllBooks()
        {
            return View();
        }
    }
}