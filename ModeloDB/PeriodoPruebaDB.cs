using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class PeriodoPruebaDB : DbContext

    {
        //Declaración entidades del modelo DB
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Biometrico> Biometricos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Linea concexion SQL SERVER
            string conSQLServer = "server = ABEL-ASAA\\SQLEXPRESS; Initial Catalog = PeriodoPrueba; trusted_connection=true;";

            //Conexion con sql server
            options.UseSqlServer(conSQLServer);

        }
    }
}
