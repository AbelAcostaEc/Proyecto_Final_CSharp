using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;

namespace Procesos
{
    public class ProAprobacionContrato
    {
        readonly PeriodoPruebaDB db;
        public ProAprobacionContrato(PeriodoPruebaDB db)
        {
            this.db = db;
        }

        public bool ApruebaContrato(Empleado empleadoP)
        {

            /* var tmpEmpleado = db.Empleados
                 .Include(emp => emp.Implemento)
                 .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);
            */

            ProTotalDias proDias = new ProTotalDias(db);
            ProTotalHoras prohora = new ProTotalHoras(db);
            ProComprobacionVentas proVentas = new ProComprobacionVentas(db);
            ProAsistenciaCapacitacion proAsisCap = new ProAsistenciaCapacitacion(db);
            ProEvaluacion proEvalua = new ProEvaluacion(db);
            ProcesoEstadoImplemento proImplemento = new ProcesoEstadoImplemento(db);


            if (proDias.ApruebaDias(empleadoP))
            {
                if (prohora.ApruebaHoras(empleadoP))
                {
                    if (proVentas.CompruebaVentas(empleadoP))
                    {
                        if (proAsisCap.CompruebaAsistencia(empleadoP))
                        {
                            if (proEvalua.CompruebaEvaluacion(empleadoP))
                            {
                                if (proImplemento.CompruebaImplemento(empleadoP))
                                {
                                    return true;
                                }

                            }

                        }

                    }

                }
            }

            return false;

        }
    }
}
