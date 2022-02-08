using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;

namespace Procesos
{
    public class ProAsistenciaCapacitacion
    {
        readonly PeriodoPruebaDB db;

        public ProAsistenciaCapacitacion(PeriodoPruebaDB db)
        {
            this.db = db;
        }

        public bool CompruebaAsistencia(Empleado empleadoP)
        {
            var tmpEmpleado = db.Empleados
                .Include(emp => emp.CapacitacionAsistencias)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);

            var capacitaciones = db.Capacitaciones.Count();

            if (tmpEmpleado.CapacitacionAsistencias.Count() == capacitaciones)
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
