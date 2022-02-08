using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;

namespace Procesos
{
    public class ProcesoEstadoImplemento
    {
        readonly PeriodoPruebaDB db;

        public ProcesoEstadoImplemento(PeriodoPruebaDB db)
        {
            this.db = db;

        }

        public bool CompruebaImplemento(Empleado empleadoP)
        {

            var tmpEmpleado = db.Empleados
                .Include(emp => emp.Implemento)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);


            if (tmpEmpleado.Implemento.Estado == EstadoImplemento.Excelente || tmpEmpleado.Implemento.Estado == EstadoImplemento.Bueno)
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
