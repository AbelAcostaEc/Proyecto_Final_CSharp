using Microsoft.AspNetCore.Mvc;
using ModeloDB;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{

    public class VentasController : Controller
    {
        private readonly PeriodoPruebaDB db;

        public VentasController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Venta> listaVentas =db.Ventas.Include(v=>v.Empleado).ToList();
            return View(listaVentas);
        }


        //creación Venta
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Venta venta)
        {
            //Grabar Venta
            db.Ventas.Add(venta);
            db.SaveChanges();

            TempData["mensaje"] = $"La venta de fecha {venta.Fecha} creada exitosamente";
            return RedirectToAction("Index");
        }

        //edicion Venta
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Venta venta = db.Ventas.Find(id);
            return View(venta);
        }
        [HttpPost]
        public IActionResult Edit(Venta venta)
        {
            //Grabar Venta
            db.Ventas.Update(venta);
            db.SaveChanges();

            TempData["mensaje"] = $"La venta de fecha {venta.Fecha} ha sido actualizada exitosamente";
            return RedirectToAction("Index");
        }

        //borrar Venta
        // presenta formulario datos empelado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Venta venta = db.Ventas.Find(id);
            return View(venta);
        }
        //borra Venta
        [HttpPost]
        public IActionResult Delete(Venta venta)
        {
            //Grabar Venta
            db.Ventas.Remove(venta);
            db.SaveChanges();

            TempData["mensaje"] = $"La venta de fecha {venta.Fecha} ha sido eliminada exitosamente";
            return RedirectToAction("Index");
        }

    }
}
