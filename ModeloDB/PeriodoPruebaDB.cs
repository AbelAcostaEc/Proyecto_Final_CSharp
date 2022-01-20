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

        //configuracipon de la conexion
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Linea concexion SQL SERVER
            string conSQLServer = "server = ABEL-ASAA\\SQLEXPRESS; Initial Catalog = PeriodoPrueba; trusted_connection=true;";

            //Conexion con sql server
            options.UseSqlServer(conSQLServer);

        }

        //configuracion modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //cardinalidad biometricos empleados
            model.Entity<Biometrico>()
                .HasOne(biometrico => biometrico.Empleado)
                .WithMany(empleado => empleado.Biometricos)
                .HasForeignKey(biometrico => biometrico.EmpleadoId);

            //cardinalidad ventas empleado
            model.Entity<Venta>()
                .HasOne(venta => venta.Empleado)
                .WithMany(empleado => empleado.Ventas)
                .HasForeignKey(venta => venta.EmpleadoId);

            //empleado evaluaacion 2 calses 1 a uno
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Evaluacion)
                .WithOne(evaluacion => evaluacion.Empleado)
                .HasForeignKey<Evaluacion>(evaluacion => evaluacion.EmpleadoId);

        }
    }
}
