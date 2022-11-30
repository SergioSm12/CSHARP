using Microsoft.AspNetCore.Mvc;
using PortafolioPractica.Models;
using PortafolioPractica.Services;
using System.Diagnostics;

namespace PortafolioPractica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataProyects dataProyects;

        public HomeController(ILogger<HomeController> logger, IDataProyects dataProyects)
        {
            _logger = logger;
            this.dataProyects = dataProyects;
        }

        public IActionResult Index()
        {
            var proyects = dataProyects.ObtenerProyecto().Take(3).ToList();
            var modelo = new HomeIndexViewModel
            {
                Proyectos = proyects,
            };
            return View(modelo);
        }

        public IActionResult Proyectos()
        { 
            var proyects =dataProyects.ObtenerProyecto();
            return View(proyects);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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