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
        public DbSet<Implemento> Implementos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Capacitacion> Capacitaciones  { get; set; }
        public DbSet<CapacitacionAsistencia> CapacitacionAsistencias  { get; set; }

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
            //Relaciones 1 a muchos
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

            //cardinalidad ventas empleado
            model.Entity<Permiso>()
                .HasOne(permiso => permiso.Empleado)
                .WithMany(empleado => empleado.Permisos)
                .HasForeignKey(permiso => permiso.EmpleadoId);

            //Relaciones 1 a 1
            //empleado evaluacion 
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Evaluacion)
                .WithOne(evaluacion => evaluacion.Empleado)
                .HasForeignKey<Evaluacion>(evaluacion => evaluacion.EmpleadoId);

            //empleado implemento 
            model.Entity<Empleado>()
                .HasOne(empleado => empleado.Implemento)
                .WithOne(implemento => implemento.Empleado)
                .HasForeignKey<Implemento>(implemento => implemento.EmpleadoId);


            // Relacion muchos a muchos Capacitacion - empleado
            //-Capacitacion
            model.Entity<CapacitacionAsistencia>()
              .HasOne(capacitacionasistencia => capacitacionasistencia.Capacitacion)
              .WithMany(capacitacion => capacitacion.CapacitacionAsistencias)
              .HasForeignKey(capacitacionasistencia => capacitacionasistencia.CapacitacionId);

            //-Empleado
            model.Entity<CapacitacionAsistencia>()
              .HasOne(capacitacionasistencia => capacitacionasistencia.Empleado)
              .WithMany(empleado => empleado.CapacitacionAsistencias)
              .HasForeignKey(capacitacionasistencia => capacitacionasistencia.EmpleadoId);

            //clave primaria formada por 2 foraneas
            model.Entity<CapacitacionAsistencia>()
             .HasKey(capacitacionasistencia => new { capacitacionasistencia.CapacitacionId, capacitacionasistencia.EmpleadoId });
        }
    }
}
