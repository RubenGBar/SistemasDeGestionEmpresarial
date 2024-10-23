using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Controllers
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

            DateTime horaActual = DateTime.Now;
            String saludo = "";

            if (horaActual.Hour >= 6 && horaActual.Hour < 12)
            {
                saludo = "Buenos días";
            }
            else if (horaActual.Hour >= 12 && horaActual.Hour < 20)
            {
                saludo = "Buenas tardes";
            }
            else if (horaActual.Hour >= 20 && horaActual.Hour < 6)
            {
                saludo = "Buenas noches";
            }

            ViewData["saludo"] = saludo;

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
