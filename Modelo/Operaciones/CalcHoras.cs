using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Operaciones
{
    public class CalcHoras
    {
        public int HoraTotal(Biometrico biometrico)
        {

            int respuesta = 0;
            if (  biometrico.Entrada.Minute<=5 && biometrico.Salida.Minute>=0)
            {

                TimeSpan entrada = new TimeSpan(8, 0, 0); 
                TimeSpan salida = new TimeSpan(12, 0, 0);


                TimeSpan diferencia = (biometrico.Salida.Date+salida) - (biometrico.Entrada.Date + entrada);
                var diferenciaenminutos = diferencia.TotalHours;
                 respuesta = ((int)diferenciaenminutos);
            }
            else
            {
                TimeSpan salida = new TimeSpan(12, 0, 0);
                TimeSpan diferencia = (biometrico.Salida.Date + salida) - biometrico.Entrada;
                var diferenciaenminutos = diferencia.TotalHours;
                respuesta = ((int)diferenciaenminutos);
            }
            

            return respuesta;
        }
    }
}
