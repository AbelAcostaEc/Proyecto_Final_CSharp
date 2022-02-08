using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;

namespace Procesos
{
    public class ProEvaluacion
    {
        readonly PeriodoPruebaDB db;

        public ProEvaluacion(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public bool CompruebaEvaluacion(Empleado empleadoP)
        {

            var tmpEmpleado = db.Empleados
                .Include(emp => emp.Evaluacion)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);


            if (tmpEmpleado.Evaluacion.Calificacion == Calificacion.Excelente || tmpEmpleado.Evaluacion.Calificacion == Calificacion.Buena)
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
