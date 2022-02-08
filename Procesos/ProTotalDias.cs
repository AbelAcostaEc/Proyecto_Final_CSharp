using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Procesos
{
    public class ProTotalDias
    {
        readonly PeriodoPruebaDB db;

        public ProTotalDias(PeriodoPruebaDB db)
        {
            this.db = db;
        }

        public bool ApruebaDias(Empleado empleadoP)
        {
            var configuracion = db.Configuraciones.Single();

            var tmpEmpleado = db.Empleados
                .Include(emp => emp.Biometricos)
                .Include(emp => emp.Permisos)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);

            var permiso = tmpEmpleado.Permisos.Count();
            var biometrico = tmpEmpleado.Biometricos.Count();


            if (biometrico < configuracion.DiasMinimos)
            {
                biometrico = biometrico + permiso;
            }


            if (biometrico == configuracion.DiasMinimos)
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
