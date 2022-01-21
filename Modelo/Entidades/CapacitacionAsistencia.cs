using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class CapacitacionAsistencia
    {
        public int CapacitacionId { get; set; }
        public int EmpleadoId { get; set; }

        // relacion
        public Empleado Empleado { get; set; }
        public Capacitacion Capacitacion { get; set; }
    }
}
