using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly PeriodoPruebaDB db;
        public EmpleadosController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Empleado> listaEmpleados = db.Empleados;
            return View(listaEmpleados);
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
