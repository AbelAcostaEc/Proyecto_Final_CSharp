using System;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Procesos
{
    public class ProTotalHoras
    {
        public PeriodoPruebaDB db;

        public ProTotalHoras(PeriodoPruebaDB db)
        {
            this.db = db;
        }

        public bool ApruebaHoras(Empleado empleadoP)
        {

            var tmpEmpleado = db.Empleados
                .Include(emp => emp.Biometricos)
                .Single(emp => emp.EmpleadoId == empleadoP.EmpleadoId);

            var horaF = 0;

            foreach (var bio in tmpEmpleado.Biometricos)
            {

                CalcHoras calcular = new CalcHoras();
                horaF = horaF + calcular.HoraTotal(bio);

            }
            if (horaF == 360)
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
