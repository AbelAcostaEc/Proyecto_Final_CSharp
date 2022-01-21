using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Implemento
    {
         public int ImplementoId { get; set; }
        public String Estado { get; set; }
        public String Observacion { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
