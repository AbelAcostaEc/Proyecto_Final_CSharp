using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public DateTime Fecha { get; set; }
        public String Calificacion { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
