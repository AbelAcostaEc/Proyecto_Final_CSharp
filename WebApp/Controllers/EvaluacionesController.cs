using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            IEnumerable<Evaluacion> listaEvaluaciones = db.Evaluaciones.Include(e=>e.Empleado).ToList();
            return View(listaEvaluaciones);
        }
        //creación Evaluacion
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Evaluacion evaluacion)
        {
            //Grabar Evaluacion
            db.Evaluaciones.Add(evaluacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La evaluacion {evaluacion.Fecha} creado exitosamente";
            return RedirectToAction("Index");
        }


        //edicion Evaluacion
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Evaluacion evaluacion = db.Evaluaciones.Find(id);
            return View(evaluacion);
        }
        [HttpPost]
        public IActionResult Edit(Evaluacion evaluacion)
        {
            //Grabar Evaluacion
            db.Evaluaciones.Update(evaluacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La evaluacion  {evaluacion.Fecha} ha sido actualizado exitosamente";
            return RedirectToAction("Index");
        }

        //borrar Evaluacion
        // presenta formulario datos Evaluacion
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Evaluacion evaluacion = db.Evaluaciones.Find(id);
            return View(evaluacion);
        }
        //borra Evaluacion
        [HttpPost]
        public IActionResult Delete(Evaluacion evaluacion)
        {
            //Grabar Evaluacion
            db.Evaluaciones.Remove(evaluacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La evaluacion {evaluacion.Fecha} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }

    }
}
