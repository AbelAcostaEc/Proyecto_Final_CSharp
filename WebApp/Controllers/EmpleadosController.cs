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
        //creación empleado
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Empleado empleado)
        {
            //Grabar Empleado
            db.Empleados.Add(empleado);
            db.SaveChanges();
            TempData["mensaje"] = $"El empleado {empleado.Nombre} creado exitosamente";
            return RedirectToAction("Index");
        }


        //edicion empleado
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Empleado empleado = db.Empleados.Find(id);
            return View(empleado);
        }
        [HttpPost]
        public IActionResult Edit(Empleado empleado)
        {
            //Grabar Empleado
            db.Empleados.Update(empleado);
            db.SaveChanges();

            TempData["mensaje"] = $"El empleado {empleado.Nombre} ha sido actualizado exitosamente";
            return RedirectToAction("Index");
        }

        //borrar empleado
        // presenta formulario datos empelado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Empleado empleado = db.Empleados.Find(id);
            return View(empleado);
        }
        //borra empleado
        [HttpPost]
        public IActionResult Delete(Empleado empleado)
        {
            //Grabar Empleado
            db.Empleados.Remove(empleado);
            db.SaveChanges();

            TempData["mensaje"] = $"El empleado {empleado.Nombre} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }

    }
}
