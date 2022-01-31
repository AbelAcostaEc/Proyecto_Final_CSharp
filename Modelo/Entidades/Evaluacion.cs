using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum Calificacion { Excelente,Buena, Mala}
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public Calificacion Calificacion { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
