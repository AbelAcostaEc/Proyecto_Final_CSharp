using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum ContratoEstado { Pendiente, Aprobada, Rechazada, Anulada }

    public class Contrato
    {
        public int ContratoId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public ContratoEstado Estado { get; set; }


        //relacion empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
