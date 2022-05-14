using DemoApp6.Models;
using DemoApp6.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DemoApp6.Controllers
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

        public IActionResult AddPeson(PersonViewModel personViewModel)
        {
            //if(personViewModel == null)
            //    return View("Error");
            //if(personViewModel.Name == null)
            //    return RedirectToAction("Index");

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(personViewModel.Name);
            //Console.WriteLine(stringBuilder.ToString());

            return View(personViewModel);
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