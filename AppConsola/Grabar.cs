using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace AppConsola
{
    public class Grabar
    {

        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaEmpleados = (List<Empleado>)listas[ListasTipo.Empleados];
            var listaCapacitaciones = (List<Capacitacion>)listas[ListasTipo.Capacitaciones];
            var listaCapacitacionAsitencia = (List<CapacitacionAsistencia>)listas[ListasTipo.AsistenciaCapacitacion];
            var listaConfiguracion = (List<Configuracion>)listas[ListasTipo.Configuracion];


            using (PeriodoPruebaDB db = PeriodoPruebaDBBuilder.Crear())
            {
                // Se asegura que se borre y vuelva a crear la base de datos
                db.PreparaDB();
                // Agrega los listados
                db.Empleados.AddRange(listaEmpleados);
                db.Capacitaciones.AddRange(listaCapacitaciones);
                db.CapacitacionAsistencias.AddRange(listaCapacitacionAsitencia);
                db.Configuraciones.AddRange(listaConfiguracion);
                // Guarda todos los datos
                db.SaveChanges();
            }

            
        }
    }
}
