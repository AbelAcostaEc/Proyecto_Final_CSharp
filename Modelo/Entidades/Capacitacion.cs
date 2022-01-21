using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Capacitacion
    {
        public int CapacitacionId { get; set; }
        public DateTime Fecha { get; set; }

        public string Tema { get; set; }

        public IList<CapacitacionAsistencia> CapacitacionAsistencias { get; set; }




    }
}
