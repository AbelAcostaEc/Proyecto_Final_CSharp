using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum EstadoVenta { Completado, Rechazado }

    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public EstadoVenta Estado { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
