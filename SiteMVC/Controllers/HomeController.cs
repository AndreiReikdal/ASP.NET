using Microsoft.AspNetCore.Mvc;
using SiteMVC.Models;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteMVC.Controllers
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
            HomeModel home = new HomeModel();

            home.Nome = "Ferdinado Suares";
            

            return View(home);
        }

        public IActionResult Privacy()
        {
            PaginaModel pagina = new PaginaModel();

            
            pagina.CPF = "26516984614";
            return View(pagina);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
