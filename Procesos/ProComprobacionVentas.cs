using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProComprobacionVentas
    {
        readonly PeriodoPruebaDB db;

        public ProComprobacionVentas(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public bool CompruebaVentas(Empleado empleadoP)
        {
            var configuracion = db.Configuraciones.Single();

            var tmpEmpleado = db.Empleados
                .Include(emp => emp.Ventas)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);

            var ventastotal = 0;

            foreach (var venta in tmpEmpleado.Ventas)
            {
                if (venta.Estado == EstadoVenta.Completado)
                {
                    ventastotal = ventastotal + 1;
                }
            }
            


            if (ventastotal >= configuracion.VentasMinimo)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
