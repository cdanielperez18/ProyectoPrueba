using Microsoft.AspNetCore.Mvc;
using ProyectoPrueba.Models;
using System.Diagnostics;

namespace ProyectoPrueba.Controllers
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

        public IActionResult Configuracion()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
			ViewBag.NumeroTarjeta = 111;
			return View();
        }

        public IActionResult DashboardAnual()
        {
			ViewBag.NumeroTarjeta = 999;
			return View();
        }

        public IActionResult DashboardMensual()
        {
			ViewBag.NumeroTarjeta = 222;
			return View();
        }

        public IActionResult DashboardSemanal()
        {
			ViewBag.NumeroTarjeta = 777;
			return View();
        }

        public IActionResult Perfil()
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
