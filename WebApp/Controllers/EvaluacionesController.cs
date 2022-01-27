using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class EvaluacionesController : Controller
    {
        private readonly PeriodoPruebaDB db;

        public EvaluacionesController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Evaluacion> listaEvaluaciones = db.Evaluaciones;
            return View(listaEvaluaciones);
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
