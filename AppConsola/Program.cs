using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Abel = new Empleado()
            {
                Nombre = "Abel Acosta",
                Cedula = 1726139924,
                Correo = "abel@gmail.com",
                Celular = 0999200394,
                Biometricos = new List<Biometrico>() { new Biometrico() { } },
                Permisos = new List<Permiso>() { new Permiso() { } },
                Ventas = new List<Venta>() { new Venta() { } },
                Evaluacion = new Evaluacion()
            };
            Biometrico Dia1 = new Biometrico()
            {

            }
        }
    }
}
