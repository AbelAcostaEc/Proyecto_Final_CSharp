using Microsoft.EntityFrameworkCore;
using Procesos;
using System;
using System.Linq;

namespace AppConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //grabar datos en Base
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using (var db = PeriodoPruebaDBBuilder.Crear())
            {

                //mostrar lista para definir que se ha grabado correctamente
                #region 
                /*
                
                var listaEmpleados = db.Empleados
                    .Include(empleado => empleado.Evaluacion)
                    .Include(empleado => empleado.Implemento);


                Console.WriteLine("Listado de Empleados");
                foreach (var empleado in listaEmpleados)
                {
                    Console.WriteLine(
                        empleado.Nombre + " " +
                        empleado.Cedula + " " +
                        empleado.Correo + " " +
                        "Evaluacion: "+empleado.Evaluacion.Calificacion + " " +
                        "Estado Implemento: "+ empleado.Implemento.Estado 

                    );
                }

                var listaCapacitaciones = db.Capacitaciones;

                Console.WriteLine("Listado de Capacitaciones");
                foreach (var capacitacion in listaCapacitaciones)
                {
                    Console.WriteLine(
                        capacitacion.Tema + " " +
                        capacitacion.Fecha.ToShortDateString() 
                    );
                }

                var listaCapacitacionesAsitencia = db.CapacitacionAsistencias
                    .Include(capacitacionAsistencia => capacitacionAsistencia.Capacitacion)
                    .Include(capacitacionAsistencia => capacitacionAsistencia.Empleado);

                Console.WriteLine("Listado de Asistencia de Capacitaciones");
                foreach (var capacitacionAsistencia in listaCapacitacionesAsitencia)
                {
                    Console.WriteLine(
                        capacitacionAsistencia.Capacitacion.Tema + " " +
                        capacitacionAsistencia.Empleado.Nombre + " " +
                        capacitacionAsistencia.Capacitacion.Fecha
                    );
                }

                //Operacion Proyeccion
                var listaEmpleadosP = db.Empleados
                    .Select(empleado=> new
                    {
                        empleado.EmpleadoId,
                        empleado.Nombre
                    
                    });


                foreach (var empleado in listaEmpleados)
                   
                {
                    Console.Write(empleado.EmpleadoId+ " "+empleado.Nombre);
                }

                */
                #endregion


                //Dato empleado para verificar procesos 
                var tmpEmpleado = db.Empleados.Single(emp => emp.EmpleadoId == 4);
                //verificar horas totales

                #region 

                ProTotalHoras prohora = new ProTotalHoras(db);

                if (prohora.ApruebaHoras(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó las horas necesarias");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó las horas necesarias");

                }

                #endregion

                //verificar dias totales

                #region 
                ProTotalDias proDias = new ProTotalDias(db);

                if (proDias.ApruebaDias(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó los días necesarias");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó los días necesarias");

                }

                #endregion

                //Verificar ventas totales
                #region 
                ProComprobacionVentas proventa = new ProComprobacionVentas(db);

                if (proventa.CompruebaVentas(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó las ventas necesarias");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó las ventas necesarias");

                }
                #endregion

                //Verificar Evaluacion
                #region 
                ProEvaluacion proEvaluacion = new ProEvaluacion(db);

                if (proEvaluacion.CompruebaEvaluacion(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó la Evaluación de Supervisor");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó la Evaluación de Supervisor");

                }
                #endregion

                //Verificar Implemento
                #region 
                ProcesoEstadoImplemento proImplemento = new ProcesoEstadoImplemento(db);

                if (proImplemento.CompruebaImplemento(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó el estado de Implementos");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó el estado de Implementos");

                }
                #endregion

                //Verificar Asistenica a Capacitacion
                #region 
                ProAsistenciaCapacitacion proAsisCap = new ProAsistenciaCapacitacion(db);

                if (proAsisCap.CompruebaAsistencia(tmpEmpleado))
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " aprobó la asistencia a capacitaciones");

                }
                else
                {
                    Console.WriteLine("El empleado " + tmpEmpleado.Nombre + " no aprobó la asistencia a capacitaciones");

                }
                #endregion

                //Verificar Asistenica a Capacitacion
                #region 
                ProAprobacionContrato proContrato = new ProAprobacionContrato(db);

                if (proContrato.ApruebaContrato(tmpEmpleado))
                {
                    Console.WriteLine("Se aprobó el contrato del empleado " + tmpEmpleado.Nombre );

                }
                else
                {
                    Console.WriteLine("No se aprobó el contrato del empleado " + tmpEmpleado.Nombre);

                }
                #endregion

                Console.WriteLine("------------LISTA BIOMETRICO-------------");
                var listaBIo = db.Biometricos;

                foreach (var bio in listaBIo)
                {
                    Console.WriteLine(
                        bio.BiometricoId + " " +
                         "Fecha:  " +
                        bio.Fecha.ToShortDateString() + " " +
                        "Entrada:  " +
                        bio.Entrada.Hour + " " +
                        bio.Entrada.Minute + " " +
                        "Salida:  " +
                        bio.Salida.Hour + " " +
                        bio.Salida.Minute + " " +
                        "Empleado:  " +
                        bio.EmpleadoId + " " 



                    );
                }
            }
        }
    }
}
