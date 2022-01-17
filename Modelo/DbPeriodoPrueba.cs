using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class DbPeriodoPrueba:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Biometrico> Biometricos { get; set; }
        public DbSet<Evaluacion> Evaluacions { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
