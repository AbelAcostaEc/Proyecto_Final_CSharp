using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Biometrico dia1 = new Biometrico()
            {
                Entrada = new DateTime(2021, 11, 01, 8, 03, 02),
                Salida = new DateTime(2021, 11, 01, 12, 01, 25),
                Fecha = new DateTime(2021, 11, 01),
            };
            Biometrico dia2 = new Biometrico()
            {
                Entrada = new DateTime(2021, 11, 02, 8, 01, 45),
                Salida = new DateTime(2021, 11, 02, 12, 00, 34),
                Fecha = new DateTime(2021, 11, 02),
            };
            Biometrico dia3 = new Biometrico()
            {
                Entrada = new DateTime(2021, 11, 03, 8, 05, 10),
                Salida = new DateTime(2021, 11, 03, 12, 02, 18),
                Fecha = new DateTime(2021, 11, 03),
            };

            //ventas
            Venta v1 = new Venta()
            {
                Fecha = new DateTime(2021, 11, 02),
                Estado = "Completado"
            };
            Venta v2 = new Venta()
            {
                Fecha = new DateTime(2021, 11, 03),
                Estado = "Rechazada"
            };

            Empleado Empleado1 = new Empleado()
            {
                Nombre = "Abel Acosta",
                Cedula = 1726139924,
                Correo = "abel@gmail.com",
                Celular = 0999200394,
                Biometricos = new List<Biometrico>() { dia1,dia2,dia3},
                Permisos = new List<Permiso>() {  },
                Ventas = new List<Venta>() { v1,v2 },
                Evaluacion = new Evaluacion()
                {
                    Fecha= new DateTime(2022,01,05),
                    Calificacion="Buena"
                }
            };

            // Andrea
            

            PeriodoPruebaDB repos = new PeriodoPruebaDB();
            repos.Empleados.Add(Empleado1);
            repos.SaveChanges();


        }
    }
}
