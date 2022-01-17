using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Correo { get; set; }
        public int Celular { get; set; }

        // relacion Biometrico
        public List<Biometrico> Biometricos { get; set; }

        //relacion Permiso
        public List<Permiso> Permisos { get; set; }

        //relacion Ventas
        public List<Venta> Ventas { get; set; }
        //relacion evaluacion
        public Evaluacion Evaluacion { get; set; }
    }
}
