using Amazon.OpsWorks.Model;
using LaboratorioN2.Dominio;
using LaboratorioN2.Models;
using LaboratorioN2.Models.ViewModels;
using LaboratorioN2.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IPersona ipersona;
        public HomeController(ILogger<HomeController> logger, IPersona ipersona)
        {
            this.ipersona = ipersona;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult Save(PersonaViewModel personaVM)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", personaVM);
            }
            else
            {
                if (personaVM.EdadPersona >= 18)
                {
                    Persona p = new()
                    {
                        NombrePersona = personaVM.NombrePersona,
                        EdadPersona = personaVM.EdadPersona,
                        DescripcionPersona = personaVM.DescripcionPersona
                    };
                    ipersona.Save(p);
                    return View("Personas");
                }
                else
                {

                    return View("Index", personaVM);
                }
            }
        }
        
        public IActionResult Personas()
        {
            
            return RedirectToAction("GetAll");   
        }
        public IActionResult GetAll()
        {
            var DandoFormatoJson = ipersona.ListarDatos();
            return Json(new { data = DandoFormatoJson });
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
