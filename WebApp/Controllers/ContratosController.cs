using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using Modelo.Operaciones;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Procesos;

namespace WebApp.Controllers
{
    public class ContratosController : Controller
    {
        private readonly PeriodoPruebaDB db;
        public ContratosController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var listaContratos = db.Contratos
                 .Include(contrato => contrato.Empleado);
            return View(listaContratos);

        }
        // Pantalla para la validación de la matrícula
        
        public IActionResult Validar(int id)
        {

            CalcHoras horastotales = new CalcHoras();

            var contrato = db.Contratos
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Evaluacion)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Implemento)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Biometricos)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Permisos)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.CapacitacionAsistencias)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Ventas)



                 .Single(contrato => contrato.ContratoId == id)   // Consulta el contrato id
                ;


            //MUESTRA HORAS TOTALES
            var TotalHorasLaboradas = 0;
            foreach (var bio in contrato.Empleado.Biometricos)
            {

                TotalHorasLaboradas = TotalHorasLaboradas + horastotales.HoraTotal(bio);
            }

            //MUESTRA VENTAS TOTALES
            var ventastotal = 0;

            foreach (var venta in contrato.Empleado.Ventas)
            {
                if (venta.Estado == EstadoVenta.Completado)
                {
                    ventastotal = ventastotal + 1;
                }
            }


            ViewBag.horas = TotalHorasLaboradas;
            ViewBag.ventasEfectivas = ventastotal;
            ViewBag.CapacitacionesTotales = db.Capacitaciones.Count();


            return View(contrato);
        }
       
        //Metodo para validar
        [HttpPost]
        public IActionResult Validar(Contrato contrato)
        {
            ProAprobacionContrato pro = new ProAprobacionContrato(db);
            var tmpEmpleado = db.Empleados.Find(contrato.EmpleadoId);

            if (pro.ApruebaContrato(tmpEmpleado)){
                
                contrato.Estado = ContratoEstado.Aprobada;
                contrato.Fecha = System.DateTime.Now;
                TempData["mensaje"] = $"Contrato del Empleado {contrato.Empleado.Nombre} ha sido aprobado ";
            }
            else
            {
                contrato.Estado = ContratoEstado.Rechazada;
                contrato.Fecha = System.DateTime.Now;
                TempData["mensaje"] = $"Contrato del Empleado {contrato.Empleado.Nombre} ha sido rechazado ";
            }

            contrato.Empleado = null;
            contrato.EmpleadoId = tmpEmpleado.EmpleadoId;

            db.Contratos.Update(contrato);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
