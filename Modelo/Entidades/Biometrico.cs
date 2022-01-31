using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Biometrico
    {
        public int BiometricoId { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
