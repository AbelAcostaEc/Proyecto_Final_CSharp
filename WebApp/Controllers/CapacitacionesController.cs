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
        //creación Capacitacion
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Capacitacion capacitacion)
        {
            //Grabar Capacitacion
            db.Capacitaciones.Add(capacitacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La Capacitación {capacitacion.Tema} ha sido creada exitosamente";
            return RedirectToAction("Index");
        }


        //edicion Capacitacion
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Capacitacion capacitacion = db.Capacitaciones.Find(id);
            return View(capacitacion);
        }
        [HttpPost]
        public IActionResult Edit(Capacitacion capacitacion)
        {
            //Actualizar Capacitacion
            db.Capacitaciones.Update(capacitacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La Capacitación {capacitacion.Tema} ha sido actualizada exitosamente";
            return RedirectToAction("Index");
        }

        //borrar Capacitacion
        // presenta formulario datos empelado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Capacitacion capacitacion = db.Capacitaciones.Find(id);
            return View(capacitacion);
        }
        //borra Capacitacion
        [HttpPost]
        public IActionResult Delete(Capacitacion capacitacion)
        {
            //Grabar Capacitacion
            db.Capacitaciones.Remove(capacitacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La Capacitación {capacitacion.Tema} ha sido eliminada exitosamente";
            return RedirectToAction("Index");
        }
    }
}
