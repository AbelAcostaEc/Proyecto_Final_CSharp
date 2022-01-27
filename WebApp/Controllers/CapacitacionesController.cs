using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class CapacitacionesController : Controller
    {
        private readonly PeriodoPruebaDB db;
        public CapacitacionesController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Capacitacion> listaCapacitaciones = db.Capacitaciones;
            return View(listaCapacitaciones);
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
