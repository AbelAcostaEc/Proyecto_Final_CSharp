using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Permiso
    {
        public int PermisoId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public DateTime Fecha { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
