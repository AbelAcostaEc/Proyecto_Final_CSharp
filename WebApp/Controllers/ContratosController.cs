using Microsoft.AspNetCore.Mvc;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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


            var contrato = db.Contratos
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Evaluacion)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Implemento)
                .Include(contrato => contrato.Empleado)
                    .ThenInclude(empleado => empleado.Biometricos)


                 .Single(contrato => contrato.ContratoId == id)   // Consulta el contrato id
                ;
            return View(contrato);
        }
    }
}
