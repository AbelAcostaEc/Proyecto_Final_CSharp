using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class BiometricosController : Controller
    {
        private readonly PeriodoPruebaDB db;

        public BiometricosController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Biometrico> listaBiometricos = db.Biometricos;
            return View(listaBiometricos);
        }

        //creación Biometrico
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Biometrico biometrico)
        {
            //Grabar Biometrico
            db.Biometricos.Add(biometrico);
            db.SaveChanges();

            TempData["mensaje"] = $"Biometrico de fecha {biometrico.Fecha} creada exitosamente";
            return RedirectToAction("Index");
        }

        //edicion Biometrico
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Biometrico biometrico = db.Biometricos.Find(id);
            return View(biometrico);
        }
        [HttpPost]
        public IActionResult Edit(Biometrico biometrico)
        {
            //Grabar Biometrico
            db.Biometricos.Update(biometrico);
            db.SaveChanges();

            TempData["mensaje"] = $"Biometrico de fecha {biometrico.Fecha} ha sido actualizada exitosamente";
            return RedirectToAction("Index");
        }

        //borrar Biometrico
        // presenta formulario datos Biometrico
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Biometrico biometrico = db.Biometricos.Find(id);
            return View(biometrico);
        }
        //borra Biometrico
        [HttpPost]
        public IActionResult Delete(Biometrico biometrico)
        {
            //Grabar Biometrico
            db.Biometricos.Remove(biometrico);
            db.SaveChanges();

            TempData["mensaje"] = $"Biometrico de fecha {biometrico.Fecha} ha sido eliminada exitosamente";
            return RedirectToAction("Index");
        }

    }
}
