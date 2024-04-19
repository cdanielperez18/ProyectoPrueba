using Microsoft.AspNetCore.Mvc;

namespace ProyectoPrueba.Controllers
{
    public class IniciarSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
