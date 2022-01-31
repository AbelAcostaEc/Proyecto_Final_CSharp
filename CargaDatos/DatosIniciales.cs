using System;
using System.Collections.Generic;
using Modelo.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {

        public enum ListasTipo
        {
            Empleados,AsistenciaCapacitacion,Capacitaciones,Configuracion
        }

        public Dictionary<ListasTipo, object> Carga()
        {
            //EMPLEADO 1 ------------------------------------------------------------------------------------------

            //Dias Biometrico Empleado 1
            Biometrico E1dia1 = new Biometrico() { Entrada = new DateTime(2021, 10, 1, 8, 1, 19), Salida = new DateTime(2021, 10, 1, 12, 3, 38), Fecha = new DateTime(2021, 10, 1), };
            Biometrico E1dia2 = new Biometrico() { Entrada = new DateTime(2021, 10, 2, 8, 3, 17), Salida = new DateTime(2021, 10, 2, 12, 0, 30), Fecha = new DateTime(2021, 10, 2), };
            Biometrico E1dia3 = new Biometrico() { Entrada = new DateTime(2021, 10, 3, 8, 1, 49), Salida = new DateTime(2021, 10, 3, 12, 4, 36), Fecha = new DateTime(2021, 10, 3), };
            Biometrico E1dia4 = new Biometrico() { Entrada = new DateTime(2021, 10, 4, 8, 2, 4), Salida = new DateTime(2021, 10, 4, 12, 3, 15), Fecha = new DateTime(2021, 10, 4), };
            Biometrico E1dia5 = new Biometrico() { Entrada = new DateTime(2021, 10, 5, 8, 0, 48), Salida = new DateTime(2021, 10, 5, 12, 2, 52), Fecha = new DateTime(2021, 10, 5), };
            Biometrico E1dia6 = new Biometrico() { Entrada = new DateTime(2021, 10, 6, 8, 1, 44), Salida = new DateTime(2021, 10, 6, 12, 1, 4), Fecha = new DateTime(2021, 10, 6), };
            Biometrico E1dia7 = new Biometrico() { Entrada = new DateTime(2021, 10, 7, 8, 7, 40), Salida = new DateTime(2021, 10, 7, 12, 4, 52), Fecha = new DateTime(2021, 10, 7), };
            Biometrico E1dia8 = new Biometrico() { Entrada = new DateTime(2021, 10, 8, 8, 3, 52), Salida = new DateTime(2021, 10, 8, 12, 4, 48), Fecha = new DateTime(2021, 10, 8), };
            Biometrico E1dia9 = new Biometrico() { Entrada = new DateTime(2021, 10, 9, 8, 3, 2), Salida = new DateTime(2021, 10, 9, 12, 5, 32), Fecha = new DateTime(2021, 10, 9), };
            Biometrico E1dia10 = new Biometrico() { Entrada = new DateTime(2021, 10, 10, 8, 0, 2), Salida = new DateTime(2021, 10, 10, 12, 5, 36), Fecha = new DateTime(2021, 10, 10), };
            Biometrico E1dia11 = new Biometrico() { Entrada = new DateTime(2021, 10, 11, 8, 5, 17), Salida = new DateTime(2021, 10, 11, 12, 5, 57), Fecha = new DateTime(2021, 10, 11), };
            Biometrico E1dia12 = new Biometrico() { Entrada = new DateTime(2021, 10, 12, 8, 7, 58), Salida = new DateTime(2021, 10, 12, 12, 0, 0), Fecha = new DateTime(2021, 10, 12), };
            Biometrico E1dia13 = new Biometrico() { Entrada = new DateTime(2021, 10, 13, 8, 1, 23), Salida = new DateTime(2021, 10, 13, 12, 5, 45), Fecha = new DateTime(2021, 10, 13), };
            Biometrico E1dia14 = new Biometrico() { Entrada = new DateTime(2021, 10, 14, 8, 2, 46), Salida = new DateTime(2021, 10, 14, 12, 0, 33), Fecha = new DateTime(2021, 10, 14), };
            Biometrico E1dia15 = new Biometrico() { Entrada = new DateTime(2021, 10, 15, 8, 1, 56), Salida = new DateTime(2021, 10, 15, 12, 3, 28), Fecha = new DateTime(2021, 10, 15), };
            Biometrico E1dia16 = new Biometrico() { Entrada = new DateTime(2021, 10, 16, 8, 3, 26), Salida = new DateTime(2021, 10, 16, 12, 0, 38), Fecha = new DateTime(2021, 10, 16), };
            Biometrico E1dia17 = new Biometrico() { Entrada = new DateTime(2021, 10, 17, 8, 1, 40), Salida = new DateTime(2021, 10, 17, 12, 3, 54), Fecha = new DateTime(2021, 10, 17), };
            Biometrico E1dia18 = new Biometrico() { Entrada = new DateTime(2021, 10, 18, 8, 1, 16), Salida = new DateTime(2021, 10, 18, 12, 0, 14), Fecha = new DateTime(2021, 10, 18), };
            Biometrico E1dia19 = new Biometrico() { Entrada = new DateTime(2021, 10, 19, 8, 2, 43), Salida = new DateTime(2021, 10, 19, 12, 1, 39), Fecha = new DateTime(2021, 10, 19), };
            Biometrico E1dia20 = new Biometrico() { Entrada = new DateTime(2021, 10, 20, 8, 3, 28), Salida = new DateTime(2021, 10, 20, 12, 3, 57), Fecha = new DateTime(2021, 10, 20), };
            Biometrico E1dia21 = new Biometrico() { Entrada = new DateTime(2021, 10, 21, 8, 7, 49), Salida = new DateTime(2021, 10, 21, 12, 2, 48), Fecha = new DateTime(2021, 10, 21), };
            Biometrico E1dia22 = new Biometrico() { Entrada = new DateTime(2021, 10, 22, 8, 7, 36), Salida = new DateTime(2021, 10, 22, 12, 4, 57), Fecha = new DateTime(2021, 10, 22), };
            Biometrico E1dia23 = new Biometrico() { Entrada = new DateTime(2021, 10, 23, 8, 1, 38), Salida = new DateTime(2021, 10, 23, 12, 5, 51), Fecha = new DateTime(2021, 10, 23), };
            Biometrico E1dia24 = new Biometrico() { Entrada = new DateTime(2021, 10, 24, 8, 1, 9), Salida = new DateTime(2021, 10, 24, 12, 2, 50), Fecha = new DateTime(2021, 10, 24), };
            Biometrico E1dia25 = new Biometrico() { Entrada = new DateTime(2021, 10, 25, 8, 7, 35), Salida = new DateTime(2021, 10, 25, 12, 0, 48), Fecha = new DateTime(2021, 10, 25), };
            Biometrico E1dia26 = new Biometrico() { Entrada = new DateTime(2021, 10, 26, 8, 0, 40), Salida = new DateTime(2021, 10, 26, 12, 3, 31), Fecha = new DateTime(2021, 10, 26), };
            Biometrico E1dia27 = new Biometrico() { Entrada = new DateTime(2021, 10, 27, 8, 3, 0), Salida = new DateTime(2021, 10, 27, 12, 2, 31), Fecha = new DateTime(2021, 10, 27), };
            Biometrico E1dia28 = new Biometrico() { Entrada = new DateTime(2021, 10, 28, 8, 3, 6), Salida = new DateTime(2021, 10, 28, 12, 2, 40), Fecha = new DateTime(2021, 10, 28), };
            Biometrico E1dia29 = new Biometrico() { Entrada = new DateTime(2021, 10, 29, 8, 6, 30), Salida = new DateTime(2021, 10, 29, 12, 1, 20), Fecha = new DateTime(2021, 10, 29), };
            Biometrico E1dia30 = new Biometrico() { Entrada = new DateTime(2021, 10, 30, 8, 5, 38), Salida = new DateTime(2021, 10, 30, 12, 4, 16), Fecha = new DateTime(2021, 10, 30), };
            Biometrico E1dia31 = new Biometrico() { Entrada = new DateTime(2021, 10, 31, 8, 6, 8), Salida = new DateTime(2021, 10, 31, 12, 1, 1), Fecha = new DateTime(2021, 10, 31), };
            Biometrico E1dia32 = new Biometrico() { Entrada = new DateTime(2021, 11, 1, 8, 2, 7), Salida = new DateTime(2021, 11, 1, 12, 5, 56), Fecha = new DateTime(2021, 11, 1), };
            Biometrico E1dia33 = new Biometrico() { Entrada = new DateTime(2021, 11, 2, 8, 3, 31), Salida = new DateTime(2021, 11, 2, 12, 2, 38), Fecha = new DateTime(2021, 11, 2), };
            Biometrico E1dia34 = new Biometrico() { Entrada = new DateTime(2021, 11, 3, 8, 6, 36), Salida = new DateTime(2021, 11, 3, 12, 4, 6), Fecha = new DateTime(2021, 11, 3), };
            Biometrico E1dia35 = new Biometrico() { Entrada = new DateTime(2021, 11, 4, 8, 7, 43), Salida = new DateTime(2021, 11, 4, 12, 3, 44), Fecha = new DateTime(2021, 11, 4), };
            Biometrico E1dia36 = new Biometrico() { Entrada = new DateTime(2021, 11, 5, 8, 2, 7), Salida = new DateTime(2021, 11, 5, 12, 0, 34), Fecha = new DateTime(2021, 11, 5), };
            Biometrico E1dia37 = new Biometrico() { Entrada = new DateTime(2021, 11, 6, 8, 3, 17), Salida = new DateTime(2021, 11, 6, 12, 3, 34), Fecha = new DateTime(2021, 11, 6), };
            Biometrico E1dia38 = new Biometrico() { Entrada = new DateTime(2021, 11, 7, 8, 4, 3), Salida = new DateTime(2021, 11, 7, 12, 2, 37), Fecha = new DateTime(2021, 11, 7), };
            Biometrico E1dia39 = new Biometrico() { Entrada = new DateTime(2021, 11, 8, 8, 6, 48), Salida = new DateTime(2021, 11, 8, 12, 1, 55), Fecha = new DateTime(2021, 11, 8), };
            Biometrico E1dia40 = new Biometrico() { Entrada = new DateTime(2021, 11, 9, 8, 3, 4), Salida = new DateTime(2021, 11, 9, 12, 4, 30), Fecha = new DateTime(2021, 11, 9), };
            Biometrico E1dia41 = new Biometrico() { Entrada = new DateTime(2021, 11, 10, 8, 4, 12), Salida = new DateTime(2021, 11, 10, 12, 3, 6), Fecha = new DateTime(2021, 11, 10), };
            Biometrico E1dia42 = new Biometrico() { Entrada = new DateTime(2021, 11, 11, 8, 5, 10), Salida = new DateTime(2021, 11, 11, 12, 0, 31), Fecha = new DateTime(2021, 11, 11), };
            Biometrico E1dia43 = new Biometrico() { Entrada = new DateTime(2021, 11, 12, 8, 1, 35), Salida = new DateTime(2021, 11, 12, 12, 3, 55), Fecha = new DateTime(2021, 11, 12), };
            Biometrico E1dia44 = new Biometrico() { Entrada = new DateTime(2021, 11, 13, 8, 2, 11), Salida = new DateTime(2021, 11, 13, 12, 5, 45), Fecha = new DateTime(2021, 11, 13), };
            Biometrico E1dia45 = new Biometrico() { Entrada = new DateTime(2021, 11, 14, 8, 7, 42), Salida = new DateTime(2021, 11, 14, 12, 2, 47), Fecha = new DateTime(2021, 11, 14), };
            Biometrico E1dia46 = new Biometrico() { Entrada = new DateTime(2021, 11, 15, 8, 4, 54), Salida = new DateTime(2021, 11, 15, 12, 4, 20), Fecha = new DateTime(2021, 11, 15), };
            Biometrico E1dia47 = new Biometrico() { Entrada = new DateTime(2021, 11, 16, 8, 0, 7), Salida = new DateTime(2021, 11, 16, 12, 4, 36), Fecha = new DateTime(2021, 11, 16), };
            Biometrico E1dia48 = new Biometrico() { Entrada = new DateTime(2021, 11, 17, 8, 7, 43), Salida = new DateTime(2021, 11, 17, 12, 3, 23), Fecha = new DateTime(2021, 11, 17), };
            Biometrico E1dia49 = new Biometrico() { Entrada = new DateTime(2021, 11, 18, 8, 6, 0), Salida = new DateTime(2021, 11, 18, 12, 0, 27), Fecha = new DateTime(2021, 11, 18), };
            Biometrico E1dia50 = new Biometrico() { Entrada = new DateTime(2021, 11, 19, 8, 0, 27), Salida = new DateTime(2021, 11, 19, 12, 0, 18), Fecha = new DateTime(2021, 11, 19), };
            Biometrico E1dia51 = new Biometrico() { Entrada = new DateTime(2021, 11, 20, 8, 7, 28), Salida = new DateTime(2021, 11, 20, 12, 0, 7), Fecha = new DateTime(2021, 11, 20), };
            Biometrico E1dia52 = new Biometrico() { Entrada = new DateTime(2021, 11, 21, 8, 4, 20), Salida = new DateTime(2021, 11, 21, 12, 0, 57), Fecha = new DateTime(2021, 11, 21), };
            Biometrico E1dia53 = new Biometrico() { Entrada = new DateTime(2021, 11, 22, 8, 6, 48), Salida = new DateTime(2021, 11, 22, 12, 3, 57), Fecha = new DateTime(2021, 11, 22), };
            Biometrico E1dia54 = new Biometrico() { Entrada = new DateTime(2021, 11, 23, 8, 0, 37), Salida = new DateTime(2021, 11, 23, 12, 5, 24), Fecha = new DateTime(2021, 11, 23), };
            Biometrico E1dia55 = new Biometrico() { Entrada = new DateTime(2021, 11, 24, 8, 5, 15), Salida = new DateTime(2021, 11, 24, 12, 5, 39), Fecha = new DateTime(2021, 11, 24), };
            Biometrico E1dia56 = new Biometrico() { Entrada = new DateTime(2021, 11, 25, 8, 7, 55), Salida = new DateTime(2021, 11, 25, 12, 4, 4), Fecha = new DateTime(2021, 11, 25), };
            Biometrico E1dia57 = new Biometrico() { Entrada = new DateTime(2021, 11, 26, 8, 0, 44), Salida = new DateTime(2021, 11, 26, 12, 1, 45), Fecha = new DateTime(2021, 11, 26), };
            Biometrico E1dia58 = new Biometrico() { Entrada = new DateTime(2021, 11, 27, 8, 6, 22), Salida = new DateTime(2021, 11, 27, 12, 3, 8), Fecha = new DateTime(2021, 11, 27), };
            Biometrico E1dia59 = new Biometrico() { Entrada = new DateTime(2021, 11, 28, 8, 1, 57), Salida = new DateTime(2021, 11, 28, 12, 0, 27), Fecha = new DateTime(2021, 11, 28), };
            Biometrico E1dia60 = new Biometrico() { Entrada = new DateTime(2021, 11, 29, 8, 3, 29), Salida = new DateTime(2021, 11, 29, 12, 0, 22), Fecha = new DateTime(2021, 11, 29), };
            Biometrico E1dia61 = new Biometrico() { Entrada = new DateTime(2021, 11, 30, 8, 1, 33), Salida = new DateTime(2021, 11, 30, 12, 4, 21), Fecha = new DateTime(2021, 11, 30), };
            Biometrico E1dia62 = new Biometrico() { Entrada = new DateTime(2021, 12, 1, 8, 3, 36), Salida = new DateTime(2021, 12, 1, 12, 1, 1), Fecha = new DateTime(2021, 12, 1), };
            Biometrico E1dia63 = new Biometrico() { Entrada = new DateTime(2021, 12, 2, 8, 6, 19), Salida = new DateTime(2021, 12, 2, 12, 3, 11), Fecha = new DateTime(2021, 12, 2), };
            Biometrico E1dia64 = new Biometrico() { Entrada = new DateTime(2021, 12, 3, 8, 4, 18), Salida = new DateTime(2021, 12, 3, 12, 2, 53), Fecha = new DateTime(2021, 12, 3), };
            Biometrico E1dia65 = new Biometrico() { Entrada = new DateTime(2021, 12, 4, 8, 3, 16), Salida = new DateTime(2021, 12, 4, 12, 1, 19), Fecha = new DateTime(2021, 12, 4), };
            Biometrico E1dia66 = new Biometrico() { Entrada = new DateTime(2021, 12, 5, 8, 7, 17), Salida = new DateTime(2021, 12, 5, 12, 4, 36), Fecha = new DateTime(2021, 12, 5), };
            Biometrico E1dia67 = new Biometrico() { Entrada = new DateTime(2021, 12, 6, 8, 0, 58), Salida = new DateTime(2021, 12, 6, 12, 5, 59), Fecha = new DateTime(2021, 12, 6), };
            Biometrico E1dia68 = new Biometrico() { Entrada = new DateTime(2021, 12, 7, 8, 3, 19), Salida = new DateTime(2021, 12, 7, 12, 4, 53), Fecha = new DateTime(2021, 12, 7), };
            Biometrico E1dia69 = new Biometrico() { Entrada = new DateTime(2021, 12, 8, 8, 1, 4), Salida = new DateTime(2021, 12, 8, 12, 0, 51), Fecha = new DateTime(2021, 12, 8), };
            Biometrico E1dia70 = new Biometrico() { Entrada = new DateTime(2021, 12, 9, 8, 2, 9), Salida = new DateTime(2021, 12, 9, 12, 2, 21), Fecha = new DateTime(2021, 12, 9), };
            Biometrico E1dia71 = new Biometrico() { Entrada = new DateTime(2021, 12, 10, 8, 5, 50), Salida = new DateTime(2021, 12, 10, 12, 4, 3), Fecha = new DateTime(2021, 12, 10), };
            Biometrico E1dia72 = new Biometrico() { Entrada = new DateTime(2021, 12, 11, 8, 2, 25), Salida = new DateTime(2021, 12, 11, 12, 1, 46), Fecha = new DateTime(2021, 12, 11), };
            Biometrico E1dia73 = new Biometrico() { Entrada = new DateTime(2021, 12, 12, 8, 7, 16), Salida = new DateTime(2021, 12, 12, 12, 2, 44), Fecha = new DateTime(2021, 12, 12), };
            Biometrico E1dia74 = new Biometrico() { Entrada = new DateTime(2021, 12, 13, 8, 3, 4), Salida = new DateTime(2021, 12, 13, 12, 4, 6), Fecha = new DateTime(2021, 12, 13), };
            Biometrico E1dia75 = new Biometrico() { Entrada = new DateTime(2021, 12, 14, 8, 7, 29), Salida = new DateTime(2021, 12, 14, 12, 3, 10), Fecha = new DateTime(2021, 12, 14), };
            Biometrico E1dia76 = new Biometrico() { Entrada = new DateTime(2021, 12, 15, 8, 3, 54), Salida = new DateTime(2021, 12, 15, 12, 0, 34), Fecha = new DateTime(2021, 12, 15), };
            Biometrico E1dia77 = new Biometrico() { Entrada = new DateTime(2021, 12, 16, 8, 2, 35), Salida = new DateTime(2021, 12, 16, 12, 1, 25), Fecha = new DateTime(2021, 12, 16), };
            Biometrico E1dia78 = new Biometrico() { Entrada = new DateTime(2021, 12, 17, 8, 0, 59), Salida = new DateTime(2021, 12, 17, 12, 4, 39), Fecha = new DateTime(2021, 12, 17), };
            Biometrico E1dia79 = new Biometrico() { Entrada = new DateTime(2021, 12, 18, 8, 0, 0), Salida = new DateTime(2021, 12, 18, 12, 2, 26), Fecha = new DateTime(2021, 12, 18), };
            Biometrico E1dia80 = new Biometrico() { Entrada = new DateTime(2021, 12, 19, 8, 2, 0), Salida = new DateTime(2021, 12, 19, 12, 1, 15), Fecha = new DateTime(2021, 12, 19), };
            Biometrico E1dia81 = new Biometrico() { Entrada = new DateTime(2021, 12, 20, 8, 5, 44), Salida = new DateTime(2021, 12, 20, 12, 4, 35), Fecha = new DateTime(2021, 12, 20), };
            Biometrico E1dia82 = new Biometrico() { Entrada = new DateTime(2021, 12, 21, 8, 2, 22), Salida = new DateTime(2021, 12, 21, 12, 0, 34), Fecha = new DateTime(2021, 12, 21), };
            Biometrico E1dia83 = new Biometrico() { Entrada = new DateTime(2021, 12, 22, 8, 6, 56), Salida = new DateTime(2021, 12, 22, 12, 1, 20), Fecha = new DateTime(2021, 12, 22), };
            Biometrico E1dia84 = new Biometrico() { Entrada = new DateTime(2021, 12, 23, 8, 6, 35), Salida = new DateTime(2021, 12, 23, 12, 3, 42), Fecha = new DateTime(2021, 12, 23), };
            Biometrico E1dia85 = new Biometrico() { Entrada = new DateTime(2021, 12, 24, 8, 4, 7), Salida = new DateTime(2021, 12, 24, 12, 1, 26), Fecha = new DateTime(2021, 12, 24), };
            Biometrico E1dia86 = new Biometrico() { Entrada = new DateTime(2021, 12, 25, 8, 0, 47), Salida = new DateTime(2021, 12, 25, 12, 2, 51), Fecha = new DateTime(2021, 12, 25), };
            Biometrico E1dia87 = new Biometrico() { Entrada = new DateTime(2021, 12, 26, 8, 6, 8), Salida = new DateTime(2021, 12, 26, 12, 5, 8), Fecha = new DateTime(2021, 12, 26), };
            Biometrico E1dia88 = new Biometrico() { Entrada = new DateTime(2021, 12, 27, 8, 2, 51), Salida = new DateTime(2021, 12, 27, 12, 3, 13), Fecha = new DateTime(2021, 12, 27), };
            Biometrico E1dia89 = new Biometrico() { Entrada = new DateTime(2021, 12, 28, 8, 4, 23), Salida = new DateTime(2021, 12, 28, 12, 4, 17), Fecha = new DateTime(2021, 12, 28), };
            Biometrico E1dia90 = new Biometrico() { Entrada = new DateTime(2021, 12, 29, 8, 5, 9), Salida = new DateTime(2021, 12, 29, 12, 4, 16), Fecha = new DateTime(2021, 12, 29), };

            //ventas Empleado 1

            Venta E1v1 = new Venta() { Fecha = new DateTime(2021, 11, 27), Estado = "Completado" };
            Venta E1v2 = new Venta() { Fecha = new DateTime(2021, 10, 2), Estado = "Completado" };
            Venta E1v3 = new Venta() { Fecha = new DateTime(2021, 12, 28), Estado = "Completado" };
            Venta E1v4 = new Venta() { Fecha = new DateTime(2021, 12, 19), Estado = "Completado" };
            Venta E1v5 = new Venta() { Fecha = new DateTime(2021, 12, 1), Estado = "Completado" };
            Venta E1v6 = new Venta() { Fecha = new DateTime(2021, 12, 18), Estado = "Completado" };
            Venta E1v7 = new Venta() { Fecha = new DateTime(2021, 12, 13), Estado = "Completado" };
            Venta E1v8 = new Venta() { Fecha = new DateTime(2021, 12, 7), Estado = "Completado" };
            Venta E1v9 = new Venta() { Fecha = new DateTime(2021, 12, 20), Estado = "Completado" };
            Venta E1v10 = new Venta() { Fecha = new DateTime(2021, 12, 21), Estado = "Completado" };
            Venta E1v11 = new Venta() { Fecha = new DateTime(2021, 10, 24), Estado = "Completado" };
            Venta E1v12 = new Venta() { Fecha = new DateTime(2021, 12, 14), Estado = "Completado" };
            Venta E1v13 = new Venta() { Fecha = new DateTime(2021, 11, 22), Estado = "Completado" };
            Venta E1v14 = new Venta() { Fecha = new DateTime(2021, 11, 20), Estado = "Completado" };
            Venta E1v15 = new Venta() { Fecha = new DateTime(2021, 12, 6), Estado = "Completado" };
            Venta E1v16 = new Venta() { Fecha = new DateTime(2021, 10, 14), Estado = "Completado" };
            Venta E1v17 = new Venta() { Fecha = new DateTime(2021, 10, 17), Estado = "Completado" };
            Venta E1v18 = new Venta() { Fecha = new DateTime(2021, 12, 27), Estado = "Completado" };
            Venta E1v19 = new Venta() { Fecha = new DateTime(2021, 11, 29), Estado = "Completado" };
            Venta E1v20 = new Venta() { Fecha = new DateTime(2021, 10, 7), Estado = "Completado" };
            Venta E1v21 = new Venta() { Fecha = new DateTime(2021, 10, 5), Estado = "Completado" };
            Venta E1v22 = new Venta() { Fecha = new DateTime(2021, 11, 29), Estado = "Completado" };
            Venta E1v23 = new Venta() { Fecha = new DateTime(2021, 11, 27), Estado = "Completado" };
            Venta E1v24 = new Venta() { Fecha = new DateTime(2021, 12, 8), Estado = "Completado" };
            Venta E1v25 = new Venta() { Fecha = new DateTime(2021, 10, 11), Estado = "Completado" };
            Venta E1v26 = new Venta() { Fecha = new DateTime(2021, 11, 23), Estado = "Completado" };
            Venta E1v27 = new Venta() { Fecha = new DateTime(2021, 10, 3), Estado = "Completado" };
            Venta E1v28 = new Venta() { Fecha = new DateTime(2021, 10, 8), Estado = "Completado" };
            Venta E1v29 = new Venta() { Fecha = new DateTime(2021, 10, 16), Estado = "Completado" };
            Venta E1v30 = new Venta() { Fecha = new DateTime(2021, 12, 28), Estado = "Completado" };




            Empleado Empleado1 = new Empleado()
            {
                Nombre = "Abel Acosta",
                Cedula = 1726139924,
                Correo = "abel@gmail.com",
                Celular = 0999200394,
                Biometricos = new List<Biometrico>() { E1dia1,E1dia2,E1dia3,E1dia4,E1dia5,E1dia6,E1dia7,E1dia8,E1dia9,E1dia10,
                                                       E1dia11,E1dia12,E1dia13,E1dia14,E1dia15,E1dia16,E1dia17,E1dia18,E1dia19,E1dia20,
                                                       E1dia21,E1dia22,E1dia23,E1dia24,E1dia25,E1dia26,E1dia27,E1dia28,E1dia29,E1dia30,
                                                       E1dia31,E1dia32,E1dia33,E1dia34,E1dia35,E1dia36,E1dia37,E1dia38,E1dia39,E1dia40,
                                                       E1dia41,E1dia42,E1dia43,E1dia44,E1dia45,E1dia46,E1dia47,E1dia48,E1dia49,E1dia50,
                                                       E1dia51,E1dia52,E1dia53,E1dia54,E1dia55,E1dia56,E1dia57,E1dia58,E1dia59,E1dia60,
                                                       E1dia61,E1dia62,E1dia63,E1dia64,E1dia65,E1dia66,E1dia67,E1dia68,E1dia69,E1dia70,
                                                       E1dia71,E1dia72,E1dia73,E1dia74,E1dia75,E1dia76,E1dia77,E1dia78,E1dia79,E1dia80,
                                                       E1dia81,E1dia82,E1dia83,E1dia84,E1dia85,E1dia86,E1dia87,E1dia88,E1dia89,E1dia90
                },
                Permisos = new List<Permiso>() { },
                Ventas = new List<Venta>() { E1v1, E1v2,E1v3,E1v4,E1v5,E1v6,E1v7,E1v8,E1v9,E1v10,
                                             E1v11, E1v12,E1v13,E1v14,E1v15,E1v16,E1v17,E1v18,E1v19,E1v20,
                                             E1v21, E1v22,E1v23,E1v24,E1v25,E1v26,E1v27,E1v28,E1v29,E1v30,
                },
                Implemento = new Implemento()
                {
                    Estado = EstadoImplemento.Excelente,
                    Observacion = "Implementos de trabajo en buen estado"
                },

                Evaluacion = new Evaluacion()
                {
                    Fecha = new DateTime(2022, 01, 05),
                    Calificacion = Calificacion.Buena
                }
            };

            //-----------------------------------------------------------------------------------------------------
            //EMPLEADO 2
            Biometrico E2dia1 = new Biometrico() { Entrada = new DateTime(2021, 10, 1, 8, 0, 38), Salida = new DateTime(2021, 10, 1, 12, 2, 44), Fecha = new DateTime(2021, 10, 1), };
            Biometrico E2dia2 = new Biometrico() { Entrada = new DateTime(2021, 10, 2, 8, 5, 24), Salida = new DateTime(2021, 10, 2, 12, 4, 39), Fecha = new DateTime(2021, 10, 2), };
            Biometrico E2dia3 = new Biometrico() { Entrada = new DateTime(2021, 10, 3, 8, 4, 31), Salida = new DateTime(2021, 10, 3, 12, 4, 22), Fecha = new DateTime(2021, 10, 3), };
            Biometrico E2dia4 = new Biometrico() { Entrada = new DateTime(2021, 10, 4, 8, 5, 39), Salida = new DateTime(2021, 10, 4, 12, 0, 46), Fecha = new DateTime(2021, 10, 4), };
            Biometrico E2dia5 = new Biometrico() { Entrada = new DateTime(2021, 10, 5, 8, 7, 48), Salida = new DateTime(2021, 10, 5, 12, 2, 39), Fecha = new DateTime(2021, 10, 5), };
            Biometrico E2dia6 = new Biometrico() { Entrada = new DateTime(2021, 10, 6, 8, 2, 37), Salida = new DateTime(2021, 10, 6, 12, 3, 42), Fecha = new DateTime(2021, 10, 6), };
            Biometrico E2dia7 = new Biometrico() { Entrada = new DateTime(2021, 10, 7, 8, 0, 59), Salida = new DateTime(2021, 10, 7, 12, 5, 15), Fecha = new DateTime(2021, 10, 7), };
            Biometrico E2dia8 = new Biometrico() { Entrada = new DateTime(2021, 10, 8, 8, 3, 53), Salida = new DateTime(2021, 10, 8, 12, 5, 31), Fecha = new DateTime(2021, 10, 8), };
            Biometrico E2dia9 = new Biometrico() { Entrada = new DateTime(2021, 10, 9, 8, 3, 7), Salida = new DateTime(2021, 10, 9, 12, 4, 43), Fecha = new DateTime(2021, 10, 9), };
            Biometrico E2dia10 = new Biometrico() { Entrada = new DateTime(2021, 10, 10, 8, 4, 40), Salida = new DateTime(2021, 10, 10, 12, 4, 2), Fecha = new DateTime(2021, 10, 10), };
            Biometrico E2dia11 = new Biometrico() { Entrada = new DateTime(2021, 10, 11, 8, 0, 0), Salida = new DateTime(2021, 10, 11, 12, 4, 41), Fecha = new DateTime(2021, 10, 11), };
            Biometrico E2dia12 = new Biometrico() { Entrada = new DateTime(2021, 10, 12, 8, 5, 36), Salida = new DateTime(2021, 10, 12, 12, 0, 1), Fecha = new DateTime(2021, 10, 12), };
            Biometrico E2dia13 = new Biometrico() { Entrada = new DateTime(2021, 10, 13, 8, 0, 25), Salida = new DateTime(2021, 10, 13, 12, 4, 10), Fecha = new DateTime(2021, 10, 13), };
            Biometrico E2dia14 = new Biometrico() { Entrada = new DateTime(2021, 10, 14, 8, 0, 23), Salida = new DateTime(2021, 10, 14, 12, 2, 54), Fecha = new DateTime(2021, 10, 14), };
            Biometrico E2dia15 = new Biometrico() { Entrada = new DateTime(2021, 10, 15, 8, 6, 38), Salida = new DateTime(2021, 10, 15, 12, 5, 9), Fecha = new DateTime(2021, 10, 15), };
            Biometrico E2dia16 = new Biometrico() { Entrada = new DateTime(2021, 10, 16, 8, 7, 20), Salida = new DateTime(2021, 10, 16, 12, 4, 18), Fecha = new DateTime(2021, 10, 16), };
            Biometrico E2dia17 = new Biometrico() { Entrada = new DateTime(2021, 10, 17, 8, 5, 49), Salida = new DateTime(2021, 10, 17, 12, 4, 25), Fecha = new DateTime(2021, 10, 17), };
            Biometrico E2dia18 = new Biometrico() { Entrada = new DateTime(2021, 10, 18, 8, 0, 25), Salida = new DateTime(2021, 10, 18, 12, 5, 47), Fecha = new DateTime(2021, 10, 18), };
            Biometrico E2dia19 = new Biometrico() { Entrada = new DateTime(2021, 10, 19, 8, 6, 12), Salida = new DateTime(2021, 10, 19, 12, 0, 42), Fecha = new DateTime(2021, 10, 19), };
            Biometrico E2dia20 = new Biometrico() { Entrada = new DateTime(2021, 10, 20, 8, 1, 17), Salida = new DateTime(2021, 10, 20, 12, 0, 7), Fecha = new DateTime(2021, 10, 20), };
            Biometrico E2dia21 = new Biometrico() { Entrada = new DateTime(2021, 10, 21, 8, 4, 24), Salida = new DateTime(2021, 10, 21, 12, 1, 9), Fecha = new DateTime(2021, 10, 21), };
            Biometrico E2dia22 = new Biometrico() { Entrada = new DateTime(2021, 10, 22, 8, 2, 29), Salida = new DateTime(2021, 10, 22, 12, 0, 30), Fecha = new DateTime(2021, 10, 22), };
            Biometrico E2dia23 = new Biometrico() { Entrada = new DateTime(2021, 10, 23, 8, 4, 29), Salida = new DateTime(2021, 10, 23, 12, 2, 12), Fecha = new DateTime(2021, 10, 23), };
            Biometrico E2dia24 = new Biometrico() { Entrada = new DateTime(2021, 10, 24, 8, 2, 42), Salida = new DateTime(2021, 10, 24, 12, 1, 43), Fecha = new DateTime(2021, 10, 24), };
            Biometrico E2dia25 = new Biometrico() { Entrada = new DateTime(2021, 10, 25, 8, 1, 57), Salida = new DateTime(2021, 10, 25, 12, 2, 4), Fecha = new DateTime(2021, 10, 25), };
            Biometrico E2dia26 = new Biometrico() { Entrada = new DateTime(2021, 10, 26, 8, 1, 3), Salida = new DateTime(2021, 10, 26, 12, 4, 28), Fecha = new DateTime(2021, 10, 26), };
            Biometrico E2dia27 = new Biometrico() { Entrada = new DateTime(2021, 10, 27, 8, 7, 58), Salida = new DateTime(2021, 10, 27, 12, 5, 52), Fecha = new DateTime(2021, 10, 27), };
            Biometrico E2dia28 = new Biometrico() { Entrada = new DateTime(2021, 10, 28, 8, 4, 9), Salida = new DateTime(2021, 10, 28, 12, 1, 38), Fecha = new DateTime(2021, 10, 28), };
            Biometrico E2dia29 = new Biometrico() { Entrada = new DateTime(2021, 10, 29, 8, 4, 5), Salida = new DateTime(2021, 10, 29, 12, 1, 27), Fecha = new DateTime(2021, 10, 29), };
            Biometrico E2dia30 = new Biometrico() { Entrada = new DateTime(2021, 10, 30, 8, 5, 51), Salida = new DateTime(2021, 10, 30, 12, 2, 9), Fecha = new DateTime(2021, 10, 30), };
            Biometrico E2dia31 = new Biometrico() { Entrada = new DateTime(2021, 10, 31, 8, 1, 41), Salida = new DateTime(2021, 10, 31, 12, 3, 33), Fecha = new DateTime(2021, 10, 31), };
            Biometrico E2dia32 = new Biometrico() { Entrada = new DateTime(2021, 11, 1, 8, 4, 21), Salida = new DateTime(2021, 11, 1, 12, 1, 11), Fecha = new DateTime(2021, 11, 1), };
            Biometrico E2dia33 = new Biometrico() { Entrada = new DateTime(2021, 11, 2, 8, 7, 1), Salida = new DateTime(2021, 11, 2, 12, 5, 7), Fecha = new DateTime(2021, 11, 2), };
            Biometrico E2dia34 = new Biometrico() { Entrada = new DateTime(2021, 11, 3, 8, 1, 2), Salida = new DateTime(2021, 11, 3, 12, 5, 46), Fecha = new DateTime(2021, 11, 3), };
            Biometrico E2dia35 = new Biometrico() { Entrada = new DateTime(2021, 11, 4, 8, 0, 39), Salida = new DateTime(2021, 11, 4, 12, 0, 25), Fecha = new DateTime(2021, 11, 4), };
            Biometrico E2dia36 = new Biometrico() { Entrada = new DateTime(2021, 11, 5, 8, 7, 37), Salida = new DateTime(2021, 11, 5, 12, 3, 4), Fecha = new DateTime(2021, 11, 5), };
            Biometrico E2dia37 = new Biometrico() { Entrada = new DateTime(2021, 11, 6, 8, 0, 49), Salida = new DateTime(2021, 11, 6, 12, 4, 49), Fecha = new DateTime(2021, 11, 6), };
            Biometrico E2dia38 = new Biometrico() { Entrada = new DateTime(2021, 11, 7, 8, 3, 53), Salida = new DateTime(2021, 11, 7, 12, 0, 20), Fecha = new DateTime(2021, 11, 7), };
            Biometrico E2dia39 = new Biometrico() { Entrada = new DateTime(2021, 11, 8, 8, 1, 57), Salida = new DateTime(2021, 11, 8, 12, 1, 10), Fecha = new DateTime(2021, 11, 8), };
            Biometrico E2dia40 = new Biometrico() { Entrada = new DateTime(2021, 11, 9, 8, 3, 35), Salida = new DateTime(2021, 11, 9, 12, 0, 30), Fecha = new DateTime(2021, 11, 9), };
            Biometrico E2dia41 = new Biometrico() { Entrada = new DateTime(2021, 11, 10, 8, 2, 42), Salida = new DateTime(2021, 11, 10, 12, 4, 16), Fecha = new DateTime(2021, 11, 10), };
            Biometrico E2dia42 = new Biometrico() { Entrada = new DateTime(2021, 11, 11, 8, 5, 23), Salida = new DateTime(2021, 11, 11, 12, 5, 26), Fecha = new DateTime(2021, 11, 11), };
            Biometrico E2dia43 = new Biometrico() { Entrada = new DateTime(2021, 11, 12, 8, 4, 52), Salida = new DateTime(2021, 11, 12, 12, 1, 42), Fecha = new DateTime(2021, 11, 12), };
            Biometrico E2dia44 = new Biometrico() { Entrada = new DateTime(2021, 11, 13, 8, 5, 21), Salida = new DateTime(2021, 11, 13, 12, 3, 44), Fecha = new DateTime(2021, 11, 13), };
            Biometrico E2dia45 = new Biometrico() { Entrada = new DateTime(2021, 11, 14, 8, 1, 28), Salida = new DateTime(2021, 11, 14, 12, 3, 6), Fecha = new DateTime(2021, 11, 14), };
            Biometrico E2dia46 = new Biometrico() { Entrada = new DateTime(2021, 11, 15, 8, 4, 26), Salida = new DateTime(2021, 11, 15, 12, 1, 53), Fecha = new DateTime(2021, 11, 15), };
            Biometrico E2dia47 = new Biometrico() { Entrada = new DateTime(2021, 11, 16, 8, 1, 37), Salida = new DateTime(2021, 11, 16, 12, 5, 4), Fecha = new DateTime(2021, 11, 16), };
            Biometrico E2dia48 = new Biometrico() { Entrada = new DateTime(2021, 11, 17, 8, 2, 29), Salida = new DateTime(2021, 11, 17, 12, 1, 0), Fecha = new DateTime(2021, 11, 17), };
            Biometrico E2dia49 = new Biometrico() { Entrada = new DateTime(2021, 11, 18, 8, 2, 7), Salida = new DateTime(2021, 11, 18, 12, 3, 40), Fecha = new DateTime(2021, 11, 18), };
            Biometrico E2dia50 = new Biometrico() { Entrada = new DateTime(2021, 11, 19, 8, 5, 17), Salida = new DateTime(2021, 11, 19, 12, 2, 20), Fecha = new DateTime(2021, 11, 19), };
            Biometrico E2dia51 = new Biometrico() { Entrada = new DateTime(2021, 11, 20, 8, 3, 4), Salida = new DateTime(2021, 11, 20, 12, 0, 3), Fecha = new DateTime(2021, 11, 20), };
            Biometrico E2dia52 = new Biometrico() { Entrada = new DateTime(2021, 11, 21, 8, 5, 24), Salida = new DateTime(2021, 11, 21, 12, 4, 58), Fecha = new DateTime(2021, 11, 21), };
            Biometrico E2dia53 = new Biometrico() { Entrada = new DateTime(2021, 11, 22, 8, 3, 48), Salida = new DateTime(2021, 11, 22, 12, 5, 2), Fecha = new DateTime(2021, 11, 22), };
            Biometrico E2dia54 = new Biometrico() { Entrada = new DateTime(2021, 11, 23, 8, 7, 3), Salida = new DateTime(2021, 11, 23, 12, 1, 3), Fecha = new DateTime(2021, 11, 23), };
            Biometrico E2dia55 = new Biometrico() { Entrada = new DateTime(2021, 11, 24, 8, 2, 59), Salida = new DateTime(2021, 11, 24, 12, 3, 3), Fecha = new DateTime(2021, 11, 24), };
            Biometrico E2dia56 = new Biometrico() { Entrada = new DateTime(2021, 11, 25, 8, 1, 8), Salida = new DateTime(2021, 11, 25, 12, 2, 3), Fecha = new DateTime(2021, 11, 25), };
            Biometrico E2dia57 = new Biometrico() { Entrada = new DateTime(2021, 11, 26, 8, 0, 57), Salida = new DateTime(2021, 11, 26, 12, 3, 40), Fecha = new DateTime(2021, 11, 26), };
            Biometrico E2dia58 = new Biometrico() { Entrada = new DateTime(2021, 11, 27, 8, 4, 2), Salida = new DateTime(2021, 11, 27, 12, 0, 8), Fecha = new DateTime(2021, 11, 27), };
            Biometrico E2dia59 = new Biometrico() { Entrada = new DateTime(2021, 11, 28, 8, 3, 42), Salida = new DateTime(2021, 11, 28, 12, 3, 48), Fecha = new DateTime(2021, 11, 28), };
            Biometrico E2dia60 = new Biometrico() { Entrada = new DateTime(2021, 11, 29, 8, 5, 51), Salida = new DateTime(2021, 11, 29, 12, 5, 9), Fecha = new DateTime(2021, 11, 29), };
            Biometrico E2dia61 = new Biometrico() { Entrada = new DateTime(2021, 11, 30, 8, 0, 44), Salida = new DateTime(2021, 11, 30, 12, 0, 24), Fecha = new DateTime(2021, 11, 30), };
            Biometrico E2dia62 = new Biometrico() { Entrada = new DateTime(2021, 12, 1, 8, 0, 17), Salida = new DateTime(2021, 12, 1, 12, 2, 5), Fecha = new DateTime(2021, 12, 1), };
            Biometrico E2dia63 = new Biometrico() { Entrada = new DateTime(2021, 12, 2, 8, 6, 5), Salida = new DateTime(2021, 12, 2, 12, 2, 38), Fecha = new DateTime(2021, 12, 2), };
            Biometrico E2dia64 = new Biometrico() { Entrada = new DateTime(2021, 12, 3, 8, 0, 50), Salida = new DateTime(2021, 12, 3, 12, 4, 31), Fecha = new DateTime(2021, 12, 3), };
            Biometrico E2dia65 = new Biometrico() { Entrada = new DateTime(2021, 12, 4, 8, 5, 6), Salida = new DateTime(2021, 12, 4, 12, 3, 36), Fecha = new DateTime(2021, 12, 4), };
            Biometrico E2dia66 = new Biometrico() { Entrada = new DateTime(2021, 12, 5, 8, 3, 13), Salida = new DateTime(2021, 12, 5, 12, 0, 38), Fecha = new DateTime(2021, 12, 5), };
            Biometrico E2dia67 = new Biometrico() { Entrada = new DateTime(2021, 12, 6, 8, 7, 53), Salida = new DateTime(2021, 12, 6, 12, 5, 1), Fecha = new DateTime(2021, 12, 6), };
            Biometrico E2dia68 = new Biometrico() { Entrada = new DateTime(2021, 12, 7, 8, 3, 35), Salida = new DateTime(2021, 12, 7, 12, 1, 48), Fecha = new DateTime(2021, 12, 7), };
            Biometrico E2dia69 = new Biometrico() { Entrada = new DateTime(2021, 12, 8, 8, 0, 3), Salida = new DateTime(2021, 12, 8, 12, 0, 10), Fecha = new DateTime(2021, 12, 8), };
            Biometrico E2dia70 = new Biometrico() { Entrada = new DateTime(2021, 12, 9, 8, 3, 21), Salida = new DateTime(2021, 12, 9, 12, 1, 28), Fecha = new DateTime(2021, 12, 9), };
            Biometrico E2dia71 = new Biometrico() { Entrada = new DateTime(2021, 12, 10, 8, 6, 18), Salida = new DateTime(2021, 12, 10, 12, 4, 38), Fecha = new DateTime(2021, 12, 10), };
            Biometrico E2dia72 = new Biometrico() { Entrada = new DateTime(2021, 12, 11, 8, 2, 36), Salida = new DateTime(2021, 12, 11, 12, 1, 7), Fecha = new DateTime(2021, 12, 11), };
            Biometrico E2dia73 = new Biometrico() { Entrada = new DateTime(2021, 12, 12, 8, 3, 2), Salida = new DateTime(2021, 12, 12, 12, 1, 23), Fecha = new DateTime(2021, 12, 12), };
            Biometrico E2dia74 = new Biometrico() { Entrada = new DateTime(2021, 12, 13, 8, 5, 20), Salida = new DateTime(2021, 12, 13, 12, 5, 23), Fecha = new DateTime(2021, 12, 13), };
            Biometrico E2dia75 = new Biometrico() { Entrada = new DateTime(2021, 12, 14, 8, 5, 48), Salida = new DateTime(2021, 12, 14, 12, 3, 2), Fecha = new DateTime(2021, 12, 14), };
            Biometrico E2dia76 = new Biometrico() { Entrada = new DateTime(2021, 12, 15, 8, 5, 18), Salida = new DateTime(2021, 12, 15, 12, 3, 59), Fecha = new DateTime(2021, 12, 15), };
            Biometrico E2dia77 = new Biometrico() { Entrada = new DateTime(2021, 12, 16, 8, 5, 14), Salida = new DateTime(2021, 12, 16, 12, 2, 37), Fecha = new DateTime(2021, 12, 16), };
            Biometrico E2dia78 = new Biometrico() { Entrada = new DateTime(2021, 12, 17, 8, 6, 35), Salida = new DateTime(2021, 12, 17, 12, 4, 35), Fecha = new DateTime(2021, 12, 17), };
            //Biometrico E2dia79 = new Biometrico() { Entrada = new DateTime(2021, 12, 18, 8, 5, 1), Salida = new DateTime(2021, 12, 18, 12, 0, 33), Fecha = new DateTime(2021, 12, 18), };
            Biometrico E2dia80 = new Biometrico() { Entrada = new DateTime(2021, 12, 19, 8, 2, 51), Salida = new DateTime(2021, 12, 19, 12, 3, 33), Fecha = new DateTime(2021, 12, 19), };
            Biometrico E2dia81 = new Biometrico() { Entrada = new DateTime(2021, 12, 20, 8, 3, 52), Salida = new DateTime(2021, 12, 20, 12, 1, 46), Fecha = new DateTime(2021, 12, 20), };
            Biometrico E2dia82 = new Biometrico() { Entrada = new DateTime(2021, 12, 21, 8, 5, 4), Salida = new DateTime(2021, 12, 21, 12, 0, 50), Fecha = new DateTime(2021, 12, 21), };
            Biometrico E2dia83 = new Biometrico() { Entrada = new DateTime(2021, 12, 22, 8, 0, 23), Salida = new DateTime(2021, 12, 22, 12, 3, 59), Fecha = new DateTime(2021, 12, 22), };
            Biometrico E2dia84 = new Biometrico() { Entrada = new DateTime(2021, 12, 23, 8, 5, 36), Salida = new DateTime(2021, 12, 23, 12, 2, 45), Fecha = new DateTime(2021, 12, 23), };
            Biometrico E2dia85 = new Biometrico() { Entrada = new DateTime(2021, 12, 24, 8, 1, 50), Salida = new DateTime(2021, 12, 24, 12, 2, 49), Fecha = new DateTime(2021, 12, 24), };
            Biometrico E2dia86 = new Biometrico() { Entrada = new DateTime(2021, 12, 25, 8, 4, 12), Salida = new DateTime(2021, 12, 25, 12, 2, 37), Fecha = new DateTime(2021, 12, 25), };
            Biometrico E2dia87 = new Biometrico() { Entrada = new DateTime(2021, 12, 26, 8, 4, 27), Salida = new DateTime(2021, 12, 26, 12, 1, 8), Fecha = new DateTime(2021, 12, 26), };
            Biometrico E2dia88 = new Biometrico() { Entrada = new DateTime(2021, 12, 27, 8, 4, 40), Salida = new DateTime(2021, 12, 27, 12, 4, 40), Fecha = new DateTime(2021, 12, 27), };
            Biometrico E2dia89 = new Biometrico() { Entrada = new DateTime(2021, 12, 28, 8, 2, 24), Salida = new DateTime(2021, 12, 28, 12, 1, 33), Fecha = new DateTime(2021, 12, 28), };
            Biometrico E2dia90 = new Biometrico() { Entrada = new DateTime(2021, 12, 29, 8, 2, 17), Salida = new DateTime(2021, 12, 29, 12, 3, 48), Fecha = new DateTime(2021, 12, 29), };

            //Ventas

            Venta E2v1 = new Venta() { Fecha = new DateTime(2021, 12, 10), Estado = "Completado" };
            Venta E2v2 = new Venta() { Fecha = new DateTime(2021, 12, 7), Estado = "Completado" };
            Venta E2v3 = new Venta() { Fecha = new DateTime(2021, 10, 13), Estado = "Completado" };
            Venta E2v4 = new Venta() { Fecha = new DateTime(2021, 10, 25), Estado = "Completado" };
            Venta E2v5 = new Venta() { Fecha = new DateTime(2021, 11, 20), Estado = "Completado" };
            Venta E2v6 = new Venta() { Fecha = new DateTime(2021, 11, 10), Estado = "Completado" };
            Venta E2v7 = new Venta() { Fecha = new DateTime(2021, 11, 20), Estado = "Completado" };
            Venta E2v8 = new Venta() { Fecha = new DateTime(2021, 10, 21), Estado = "Completado" };
            Venta E2v9 = new Venta() { Fecha = new DateTime(2021, 10, 18), Estado = "Completado" };
            Venta E2v10 = new Venta() { Fecha = new DateTime(2021, 12, 26), Estado = "Completado" };
            Venta E2v11 = new Venta() { Fecha = new DateTime(2021, 10, 2), Estado = "Completado" };
            Venta E2v12 = new Venta() { Fecha = new DateTime(2021, 12, 9), Estado = "Completado" };
            Venta E2v13 = new Venta() { Fecha = new DateTime(2021, 11, 19), Estado = "Completado" };
            Venta E2v14 = new Venta() { Fecha = new DateTime(2021, 12, 3), Estado = "Completado" };
            Venta E2v15 = new Venta() { Fecha = new DateTime(2021, 10, 26), Estado = "Completado" };
            Venta E2v16 = new Venta() { Fecha = new DateTime(2021, 12, 27), Estado = "Completado" };
            Venta E2v17 = new Venta() { Fecha = new DateTime(2021, 10, 19), Estado = "Completado" };
            Venta E2v18 = new Venta() { Fecha = new DateTime(2021, 11, 23), Estado = "Completado" };
            Venta E2v19 = new Venta() { Fecha = new DateTime(2021, 10, 13), Estado = "Completado" };
            Venta E2v20 = new Venta() { Fecha = new DateTime(2021, 11, 22), Estado = "Completado" };
            Venta E2v21 = new Venta() { Fecha = new DateTime(2021, 12, 27), Estado = "Completado" };
            Venta E2v22 = new Venta() { Fecha = new DateTime(2021, 11, 5), Estado = "Completado" };
            Venta E2v23 = new Venta() { Fecha = new DateTime(2021, 10, 18), Estado = "Completado" };
            Venta E2v24 = new Venta() { Fecha = new DateTime(2021, 11, 10), Estado = "Completado" };
            Venta E2v25 = new Venta() { Fecha = new DateTime(2021, 10, 13), Estado = "Completado" };
            Venta E2v26 = new Venta() { Fecha = new DateTime(2021, 12, 26), Estado = "Completado" };
            Venta E2v27 = new Venta() { Fecha = new DateTime(2021, 11, 26), Estado = "Completado" };
            Venta E2v28 = new Venta() { Fecha = new DateTime(2021, 11, 27), Estado = "Completado" };
            Venta E2v29 = new Venta() { Fecha = new DateTime(2021, 11, 4), Estado = "Completado" };
            Venta E2v30 = new Venta() { Fecha = new DateTime(2021, 11, 18), Estado = "Completado" };


            //Permisos
            Permiso Permiso1E2 = new Permiso()
            {
                Fecha = new DateTime(2021, 12, 18),
                Inicio = new DateTime(2021, 12, 18, 8, 1, 29),
                Fin = new DateTime(2021, 12, 18, 12, 0, 0)
            };

            Empleado Empleado2 = new Empleado()
            {
                Nombre = "Rina Usca",
                Cedula = 1710796127,
                Correo = "rina@gmail.com",
                Celular = 0998894898,
                Biometricos = new List<Biometrico>() { E2dia1,E2dia2,E2dia3,E2dia4,E2dia5,E2dia6,E2dia7,E2dia8,E2dia9,E2dia10,
                                                       E2dia11,E2dia12,E2dia13,E2dia14,E2dia15,E2dia16,E2dia17,E2dia18,E2dia19,E2dia20,
                                                       E2dia21,E2dia22,E2dia23,E2dia24,E2dia25,E2dia26,E2dia27,E2dia28,E2dia29,E2dia30,
                                                       E2dia31,E2dia32,E2dia33,E2dia34,E2dia35,E2dia36,E2dia37,E2dia38,E2dia39,E2dia40,
                                                       E2dia41,E2dia42,E2dia43,E2dia44,E2dia45,E2dia46,E2dia47,E2dia48,E2dia49,E2dia50,
                                                       E2dia51,E2dia52,E2dia53,E2dia54,E2dia55,E2dia56,E2dia57,E2dia58,E2dia59,E2dia60,
                                                       E2dia61,E2dia62,E2dia63,E2dia64,E2dia65,E2dia66,E2dia67,E2dia68,E2dia69,E2dia70,
                                                       E2dia71,E2dia72,E2dia73,E2dia74,E2dia75,E2dia76,E2dia77,E2dia78,E2dia80,
                                                       E2dia81,E2dia82,E2dia83,E2dia84,E2dia85,E2dia86,E2dia87,E2dia88,E2dia89,E2dia90
                },
                Permisos = new List<Permiso>() { Permiso1E2 },
                Ventas = new List<Venta>() { E2v1, E2v2,E2v3,E2v4,E2v5,E2v6,E2v7,E2v8,E2v9,E2v10,
                                             E2v11, E2v12,E2v13,E2v14,E2v15,E2v16,E2v17,E2v18,E2v19,E2v20,
                                             E2v21, E2v22,E2v23,E2v24,E2v25,E2v26,E2v27,E2v28,E2v29,E2v30,
                },
                Implemento = new Implemento()
                {
                    Estado = EstadoImplemento.Excelente,
                    Observacion = "Implementos de trabajo en buen estado"
                },

                Evaluacion = new Evaluacion()
                {
                    Fecha = new DateTime(2022, 01, 05),
                    Calificacion = Calificacion.Buena
                }
            };


            //EMPLEADO 3------------------------------------------------------------------------------------------------------------------------

            Biometrico E3dia1 = new Biometrico() { Entrada = new DateTime(2021, 10, 1, 8, 7, 50), Salida = new DateTime(2021, 10, 1, 12, 4, 40), Fecha = new DateTime(2021, 10, 1), };
            Biometrico E3dia2 = new Biometrico() { Entrada = new DateTime(2021, 10, 2, 8, 7, 0), Salida = new DateTime(2021, 10, 2, 12, 2, 0), Fecha = new DateTime(2021, 10, 2), };
            Biometrico E3dia3 = new Biometrico() { Entrada = new DateTime(2021, 10, 3, 8, 5, 56), Salida = new DateTime(2021, 10, 3, 12, 0, 11), Fecha = new DateTime(2021, 10, 3), };
            Biometrico E3dia4 = new Biometrico() { Entrada = new DateTime(2021, 10, 4, 8, 7, 47), Salida = new DateTime(2021, 10, 4, 12, 3, 47), Fecha = new DateTime(2021, 10, 4), };
            Biometrico E3dia5 = new Biometrico() { Entrada = new DateTime(2021, 10, 5, 8, 7, 27), Salida = new DateTime(2021, 10, 5, 12, 2, 51), Fecha = new DateTime(2021, 10, 5), };
            Biometrico E3dia6 = new Biometrico() { Entrada = new DateTime(2021, 10, 6, 8, 0, 21), Salida = new DateTime(2021, 10, 6, 12, 1, 39), Fecha = new DateTime(2021, 10, 6), };
            Biometrico E3dia7 = new Biometrico() { Entrada = new DateTime(2021, 10, 7, 8, 4, 43), Salida = new DateTime(2021, 10, 7, 12, 0, 12), Fecha = new DateTime(2021, 10, 7), };
            Biometrico E3dia8 = new Biometrico() { Entrada = new DateTime(2021, 10, 8, 8, 5, 25), Salida = new DateTime(2021, 10, 8, 12, 5, 47), Fecha = new DateTime(2021, 10, 8), };
            Biometrico E3dia9 = new Biometrico() { Entrada = new DateTime(2021, 10, 9, 8, 6, 14), Salida = new DateTime(2021, 10, 9, 12, 0, 38), Fecha = new DateTime(2021, 10, 9), };
            Biometrico E3dia10 = new Biometrico() { Entrada = new DateTime(2021, 10, 10, 8, 5, 59), Salida = new DateTime(2021, 10, 10, 12, 2, 19), Fecha = new DateTime(2021, 10, 10), };
            Biometrico E3dia11 = new Biometrico() { Entrada = new DateTime(2021, 10, 11, 8, 5, 55), Salida = new DateTime(2021, 10, 11, 12, 3, 27), Fecha = new DateTime(2021, 10, 11), };
            Biometrico E3dia12 = new Biometrico() { Entrada = new DateTime(2021, 10, 12, 8, 2, 7), Salida = new DateTime(2021, 10, 12, 12, 5, 37), Fecha = new DateTime(2021, 10, 12), };
            Biometrico E3dia13 = new Biometrico() { Entrada = new DateTime(2021, 10, 13, 8, 1, 13), Salida = new DateTime(2021, 10, 13, 12, 2, 58), Fecha = new DateTime(2021, 10, 13), };
            Biometrico E3dia14 = new Biometrico() { Entrada = new DateTime(2021, 10, 14, 8, 1, 53), Salida = new DateTime(2021, 10, 14, 12, 4, 39), Fecha = new DateTime(2021, 10, 14), };
            Biometrico E3dia15 = new Biometrico() { Entrada = new DateTime(2021, 10, 15, 8, 3, 15), Salida = new DateTime(2021, 10, 15, 12, 4, 27), Fecha = new DateTime(2021, 10, 15), };
            Biometrico E3dia16 = new Biometrico() { Entrada = new DateTime(2021, 10, 16, 8, 7, 59), Salida = new DateTime(2021, 10, 16, 12, 4, 25), Fecha = new DateTime(2021, 10, 16), };
            Biometrico E3dia17 = new Biometrico() { Entrada = new DateTime(2021, 10, 17, 8, 6, 57), Salida = new DateTime(2021, 10, 17, 12, 5, 18), Fecha = new DateTime(2021, 10, 17), };
            Biometrico E3dia18 = new Biometrico() { Entrada = new DateTime(2021, 10, 18, 8, 2, 14), Salida = new DateTime(2021, 10, 18, 12, 2, 19), Fecha = new DateTime(2021, 10, 18), };
            Biometrico E3dia19 = new Biometrico() { Entrada = new DateTime(2021, 10, 19, 8, 4, 56), Salida = new DateTime(2021, 10, 19, 12, 2, 8), Fecha = new DateTime(2021, 10, 19), };
            Biometrico E3dia20 = new Biometrico() { Entrada = new DateTime(2021, 10, 20, 8, 0, 53), Salida = new DateTime(2021, 10, 20, 12, 0, 43), Fecha = new DateTime(2021, 10, 20), };
            Biometrico E3dia21 = new Biometrico() { Entrada = new DateTime(2021, 10, 21, 8, 1, 50), Salida = new DateTime(2021, 10, 21, 12, 0, 3), Fecha = new DateTime(2021, 10, 21), };
            Biometrico E3dia22 = new Biometrico() { Entrada = new DateTime(2021, 10, 22, 8, 3, 1), Salida = new DateTime(2021, 10, 22, 12, 1, 57), Fecha = new DateTime(2021, 10, 22), };
            Biometrico E3dia23 = new Biometrico() { Entrada = new DateTime(2021, 10, 23, 8, 2, 17), Salida = new DateTime(2021, 10, 23, 12, 0, 28), Fecha = new DateTime(2021, 10, 23), };
            Biometrico E3dia24 = new Biometrico() { Entrada = new DateTime(2021, 10, 24, 8, 3, 26), Salida = new DateTime(2021, 10, 24, 12, 3, 35), Fecha = new DateTime(2021, 10, 24), };
            Biometrico E3dia25 = new Biometrico() { Entrada = new DateTime(2021, 10, 25, 8, 2, 23), Salida = new DateTime(2021, 10, 25, 12, 1, 23), Fecha = new DateTime(2021, 10, 25), };
            Biometrico E3dia26 = new Biometrico() { Entrada = new DateTime(2021, 10, 26, 8, 6, 50), Salida = new DateTime(2021, 10, 26, 12, 0, 25), Fecha = new DateTime(2021, 10, 26), };
            Biometrico E3dia27 = new Biometrico() { Entrada = new DateTime(2021, 10, 27, 8, 4, 35), Salida = new DateTime(2021, 10, 27, 12, 3, 18), Fecha = new DateTime(2021, 10, 27), };
            Biometrico E3dia28 = new Biometrico() { Entrada = new DateTime(2021, 10, 28, 8, 1, 8), Salida = new DateTime(2021, 10, 28, 12, 5, 18), Fecha = new DateTime(2021, 10, 28), };
            Biometrico E3dia29 = new Biometrico() { Entrada = new DateTime(2021, 10, 29, 8, 5, 26), Salida = new DateTime(2021, 10, 29, 12, 1, 34), Fecha = new DateTime(2021, 10, 29), };
            Biometrico E3dia30 = new Biometrico() { Entrada = new DateTime(2021, 10, 30, 8, 5, 12), Salida = new DateTime(2021, 10, 30, 12, 0, 25), Fecha = new DateTime(2021, 10, 30), };
            Biometrico E3dia31 = new Biometrico() { Entrada = new DateTime(2021, 10, 31, 8, 7, 43), Salida = new DateTime(2021, 10, 31, 12, 5, 59), Fecha = new DateTime(2021, 10, 31), };
            Biometrico E3dia32 = new Biometrico() { Entrada = new DateTime(2021, 11, 1, 8, 0, 33), Salida = new DateTime(2021, 11, 1, 12, 2, 12), Fecha = new DateTime(2021, 11, 1), };
            Biometrico E3dia33 = new Biometrico() { Entrada = new DateTime(2021, 11, 2, 8, 6, 23), Salida = new DateTime(2021, 11, 2, 12, 0, 2), Fecha = new DateTime(2021, 11, 2), };
            Biometrico E3dia34 = new Biometrico() { Entrada = new DateTime(2021, 11, 3, 8, 2, 11), Salida = new DateTime(2021, 11, 3, 12, 0, 20), Fecha = new DateTime(2021, 11, 3), };
            Biometrico E3dia35 = new Biometrico() { Entrada = new DateTime(2021, 11, 4, 8, 1, 46), Salida = new DateTime(2021, 11, 4, 12, 2, 48), Fecha = new DateTime(2021, 11, 4), };
            Biometrico E3dia36 = new Biometrico() { Entrada = new DateTime(2021, 11, 5, 8, 5, 46), Salida = new DateTime(2021, 11, 5, 12, 0, 53), Fecha = new DateTime(2021, 11, 5), };
            Biometrico E3dia37 = new Biometrico() { Entrada = new DateTime(2021, 11, 6, 8, 4, 44), Salida = new DateTime(2021, 11, 6, 12, 2, 34), Fecha = new DateTime(2021, 11, 6), };
            Biometrico E3dia38 = new Biometrico() { Entrada = new DateTime(2021, 11, 7, 8, 5, 23), Salida = new DateTime(2021, 11, 7, 12, 3, 55), Fecha = new DateTime(2021, 11, 7), };
            Biometrico E3dia39 = new Biometrico() { Entrada = new DateTime(2021, 11, 8, 8, 1, 17), Salida = new DateTime(2021, 11, 8, 12, 0, 36), Fecha = new DateTime(2021, 11, 8), };
            Biometrico E3dia40 = new Biometrico() { Entrada = new DateTime(2021, 11, 9, 8, 3, 30), Salida = new DateTime(2021, 11, 9, 12, 2, 45), Fecha = new DateTime(2021, 11, 9), };
            Biometrico E3dia41 = new Biometrico() { Entrada = new DateTime(2021, 11, 10, 8, 4, 0), Salida = new DateTime(2021, 11, 10, 12, 4, 3), Fecha = new DateTime(2021, 11, 10), };
            Biometrico E3dia42 = new Biometrico() { Entrada = new DateTime(2021, 11, 11, 8, 0, 49), Salida = new DateTime(2021, 11, 11, 12, 1, 4), Fecha = new DateTime(2021, 11, 11), };
            Biometrico E3dia43 = new Biometrico() { Entrada = new DateTime(2021, 11, 12, 8, 6, 28), Salida = new DateTime(2021, 11, 12, 12, 4, 33), Fecha = new DateTime(2021, 11, 12), };
            Biometrico E3dia44 = new Biometrico() { Entrada = new DateTime(2021, 11, 13, 8, 4, 11), Salida = new DateTime(2021, 11, 13, 12, 4, 0), Fecha = new DateTime(2021, 11, 13), };
            Biometrico E3dia45 = new Biometrico() { Entrada = new DateTime(2021, 11, 14, 8, 6, 46), Salida = new DateTime(2021, 11, 14, 12, 2, 30), Fecha = new DateTime(2021, 11, 14), };
            Biometrico E3dia46 = new Biometrico() { Entrada = new DateTime(2021, 11, 15, 8, 0, 51), Salida = new DateTime(2021, 11, 15, 12, 0, 46), Fecha = new DateTime(2021, 11, 15), };
            Biometrico E3dia47 = new Biometrico() { Entrada = new DateTime(2021, 11, 16, 8, 2, 27), Salida = new DateTime(2021, 11, 16, 12, 0, 45), Fecha = new DateTime(2021, 11, 16), };
            Biometrico E3dia48 = new Biometrico() { Entrada = new DateTime(2021, 11, 17, 8, 6, 9), Salida = new DateTime(2021, 11, 17, 12, 3, 34), Fecha = new DateTime(2021, 11, 17), };
            Biometrico E3dia49 = new Biometrico() { Entrada = new DateTime(2021, 11, 18, 8, 0, 8), Salida = new DateTime(2021, 11, 18, 12, 4, 37), Fecha = new DateTime(2021, 11, 18), };
            Biometrico E3dia50 = new Biometrico() { Entrada = new DateTime(2021, 11, 19, 8, 7, 31), Salida = new DateTime(2021, 11, 19, 12, 1, 20), Fecha = new DateTime(2021, 11, 19), };
            Biometrico E3dia51 = new Biometrico() { Entrada = new DateTime(2021, 11, 20, 8, 6, 22), Salida = new DateTime(2021, 11, 20, 12, 3, 46), Fecha = new DateTime(2021, 11, 20), };
            Biometrico E3dia52 = new Biometrico() { Entrada = new DateTime(2021, 11, 21, 8, 3, 19), Salida = new DateTime(2021, 11, 21, 12, 1, 8), Fecha = new DateTime(2021, 11, 21), };
            Biometrico E3dia53 = new Biometrico() { Entrada = new DateTime(2021, 11, 22, 8, 6, 56), Salida = new DateTime(2021, 11, 22, 12, 2, 18), Fecha = new DateTime(2021, 11, 22), };
            Biometrico E3dia54 = new Biometrico() { Entrada = new DateTime(2021, 11, 23, 8, 3, 17), Salida = new DateTime(2021, 11, 23, 12, 0, 50), Fecha = new DateTime(2021, 11, 23), };
            Biometrico E3dia55 = new Biometrico() { Entrada = new DateTime(2021, 11, 24, 8, 6, 41), Salida = new DateTime(2021, 11, 24, 12, 4, 5), Fecha = new DateTime(2021, 11, 24), };
            Biometrico E3dia56 = new Biometrico() { Entrada = new DateTime(2021, 11, 25, 8, 3, 3), Salida = new DateTime(2021, 11, 25, 12, 3, 27), Fecha = new DateTime(2021, 11, 25), };
            Biometrico E3dia57 = new Biometrico() { Entrada = new DateTime(2021, 11, 26, 8, 2, 25), Salida = new DateTime(2021, 11, 26, 12, 5, 0), Fecha = new DateTime(2021, 11, 26), };
            Biometrico E3dia58 = new Biometrico() { Entrada = new DateTime(2021, 11, 27, 8, 3, 13), Salida = new DateTime(2021, 11, 27, 12, 3, 15), Fecha = new DateTime(2021, 11, 27), };
            Biometrico E3dia59 = new Biometrico() { Entrada = new DateTime(2021, 11, 28, 8, 5, 56), Salida = new DateTime(2021, 11, 28, 12, 0, 12), Fecha = new DateTime(2021, 11, 28), };
            Biometrico E3dia60 = new Biometrico() { Entrada = new DateTime(2021, 11, 29, 8, 4, 31), Salida = new DateTime(2021, 11, 29, 12, 0, 3), Fecha = new DateTime(2021, 11, 29), };
            Biometrico E3dia61 = new Biometrico() { Entrada = new DateTime(2021, 11, 30, 8, 0, 32), Salida = new DateTime(2021, 11, 30, 12, 3, 36), Fecha = new DateTime(2021, 11, 30), };
            Biometrico E3dia62 = new Biometrico() { Entrada = new DateTime(2021, 12, 1, 8, 6, 6), Salida = new DateTime(2021, 12, 1, 12, 5, 19), Fecha = new DateTime(2021, 12, 1), };
            Biometrico E3dia63 = new Biometrico() { Entrada = new DateTime(2021, 12, 2, 8, 5, 4), Salida = new DateTime(2021, 12, 2, 12, 1, 54), Fecha = new DateTime(2021, 12, 2), };
            Biometrico E3dia64 = new Biometrico() { Entrada = new DateTime(2021, 12, 3, 8, 4, 38), Salida = new DateTime(2021, 12, 3, 12, 1, 32), Fecha = new DateTime(2021, 12, 3), };
            Biometrico E3dia65 = new Biometrico() { Entrada = new DateTime(2021, 12, 4, 8, 5, 36), Salida = new DateTime(2021, 12, 4, 12, 0, 26), Fecha = new DateTime(2021, 12, 4), };
            Biometrico E3dia66 = new Biometrico() { Entrada = new DateTime(2021, 12, 5, 8, 4, 40), Salida = new DateTime(2021, 12, 5, 12, 0, 33), Fecha = new DateTime(2021, 12, 5), };
            Biometrico E3dia67 = new Biometrico() { Entrada = new DateTime(2021, 12, 6, 8, 7, 30), Salida = new DateTime(2021, 12, 6, 12, 3, 24), Fecha = new DateTime(2021, 12, 6), };
            Biometrico E3dia68 = new Biometrico() { Entrada = new DateTime(2021, 12, 7, 8, 2, 2), Salida = new DateTime(2021, 12, 7, 12, 0, 14), Fecha = new DateTime(2021, 12, 7), };
            Biometrico E3dia69 = new Biometrico() { Entrada = new DateTime(2021, 12, 8, 8, 5, 47), Salida = new DateTime(2021, 12, 8, 12, 5, 41), Fecha = new DateTime(2021, 12, 8), };
            Biometrico E3dia70 = new Biometrico() { Entrada = new DateTime(2021, 12, 9, 8, 7, 22), Salida = new DateTime(2021, 12, 9, 12, 3, 37), Fecha = new DateTime(2021, 12, 9), };
            Biometrico E3dia71 = new Biometrico() { Entrada = new DateTime(2021, 12, 10, 8, 6, 33), Salida = new DateTime(2021, 12, 10, 12, 5, 57), Fecha = new DateTime(2021, 12, 10), };
            Biometrico E3dia72 = new Biometrico() { Entrada = new DateTime(2021, 12, 11, 8, 0, 40), Salida = new DateTime(2021, 12, 11, 12, 4, 13), Fecha = new DateTime(2021, 12, 11), };
            Biometrico E3dia73 = new Biometrico() { Entrada = new DateTime(2021, 12, 12, 8, 4, 55), Salida = new DateTime(2021, 12, 12, 12, 2, 18), Fecha = new DateTime(2021, 12, 12), };
            Biometrico E3dia74 = new Biometrico() { Entrada = new DateTime(2021, 12, 13, 8, 1, 55), Salida = new DateTime(2021, 12, 13, 12, 5, 3), Fecha = new DateTime(2021, 12, 13), };
            Biometrico E3dia75 = new Biometrico() { Entrada = new DateTime(2021, 12, 14, 8, 4, 42), Salida = new DateTime(2021, 12, 14, 12, 5, 57), Fecha = new DateTime(2021, 12, 14), };
            Biometrico E3dia76 = new Biometrico() { Entrada = new DateTime(2021, 12, 15, 8, 6, 35), Salida = new DateTime(2021, 12, 15, 12, 5, 29), Fecha = new DateTime(2021, 12, 15), };
            Biometrico E3dia77 = new Biometrico() { Entrada = new DateTime(2021, 12, 16, 8, 1, 43), Salida = new DateTime(2021, 12, 16, 12, 0, 8), Fecha = new DateTime(2021, 12, 16), };
            Biometrico E3dia78 = new Biometrico() { Entrada = new DateTime(2021, 12, 17, 8, 6, 50), Salida = new DateTime(2021, 12, 17, 12, 0, 9), Fecha = new DateTime(2021, 12, 17), };
            Biometrico E3dia79 = new Biometrico() { Entrada = new DateTime(2021, 12, 18, 8, 7, 23), Salida = new DateTime(2021, 12, 18, 12, 3, 15), Fecha = new DateTime(2021, 12, 18), };
            //Biometrico E3dia80 = new Biometrico() { Entrada = new DateTime(2021, 12, 19, 8, 0, 33), Salida = new DateTime(2021, 12, 19, 12, 0, 23), Fecha = new DateTime(2021, 12, 19), };
            Biometrico E3dia81 = new Biometrico() { Entrada = new DateTime(2021, 12, 20, 8, 7, 12), Salida = new DateTime(2021, 12, 20, 12, 4, 54), Fecha = new DateTime(2021, 12, 20), };
            Biometrico E3dia82 = new Biometrico() { Entrada = new DateTime(2021, 12, 21, 8, 6, 25), Salida = new DateTime(2021, 12, 21, 12, 4, 12), Fecha = new DateTime(2021, 12, 21), };
            Biometrico E3dia83 = new Biometrico() { Entrada = new DateTime(2021, 12, 22, 8, 0, 11), Salida = new DateTime(2021, 12, 22, 12, 0, 25), Fecha = new DateTime(2021, 12, 22), };
            Biometrico E3dia84 = new Biometrico() { Entrada = new DateTime(2021, 12, 23, 8, 1, 9), Salida = new DateTime(2021, 12, 23, 12, 3, 42), Fecha = new DateTime(2021, 12, 23), };
            Biometrico E3dia85 = new Biometrico() { Entrada = new DateTime(2021, 12, 24, 8, 0, 33), Salida = new DateTime(2021, 12, 24, 12, 0, 46), Fecha = new DateTime(2021, 12, 24), };
            Biometrico E3dia86 = new Biometrico() { Entrada = new DateTime(2021, 12, 25, 8, 2, 13), Salida = new DateTime(2021, 12, 25, 12, 0, 33), Fecha = new DateTime(2021, 12, 25), };
            Biometrico E3dia87 = new Biometrico() { Entrada = new DateTime(2021, 12, 26, 8, 7, 12), Salida = new DateTime(2021, 12, 26, 12, 1, 26), Fecha = new DateTime(2021, 12, 26), };
            Biometrico E3dia88 = new Biometrico() { Entrada = new DateTime(2021, 12, 27, 8, 6, 7), Salida = new DateTime(2021, 12, 27, 12, 3, 24), Fecha = new DateTime(2021, 12, 27), };
            Biometrico E3dia89 = new Biometrico() { Entrada = new DateTime(2021, 12, 28, 8, 1, 29), Salida = new DateTime(2021, 12, 28, 12, 0, 58), Fecha = new DateTime(2021, 12, 28), };
            Biometrico E3dia90 = new Biometrico() { Entrada = new DateTime(2021, 12, 29, 8, 7, 21), Salida = new DateTime(2021, 12, 29, 12, 0, 30), Fecha = new DateTime(2021, 12, 29), };

            //VENTAS
            Venta E3v1 = new Venta() { Fecha = new DateTime(2021, 11, 25), Estado = "Completado" };
            Venta E3v2 = new Venta() { Fecha = new DateTime(2021, 10, 1), Estado = "Completado" };
            Venta E3v3 = new Venta() { Fecha = new DateTime(2021, 11, 14), Estado = "Completado" };
            Venta E3v4 = new Venta() { Fecha = new DateTime(2021, 10, 11), Estado = "Completado" };
            Venta E3v5 = new Venta() { Fecha = new DateTime(2021, 11, 28), Estado = "Completado" };
            Venta E3v6 = new Venta() { Fecha = new DateTime(2021, 10, 30), Estado = "Completado" };
            Venta E3v7 = new Venta() { Fecha = new DateTime(2021, 12, 24), Estado = "Completado" };
            Venta E3v8 = new Venta() { Fecha = new DateTime(2021, 12, 10), Estado = "Completado" };
            Venta E3v9 = new Venta() { Fecha = new DateTime(2021, 12, 7), Estado = "Completado" };
            Venta E3v10 = new Venta() { Fecha = new DateTime(2021, 11, 20), Estado = "Completado" };
            Venta E3v11 = new Venta() { Fecha = new DateTime(2021, 10, 12), Estado = "Completado" };
            Venta E3v12 = new Venta() { Fecha = new DateTime(2021, 10, 22), Estado = "Completado" };
            Venta E3v13 = new Venta() { Fecha = new DateTime(2021, 11, 24), Estado = "Completado" };
            Venta E3v14 = new Venta() { Fecha = new DateTime(2021, 11, 30), Estado = "Completado" };
            Venta E3v15 = new Venta() { Fecha = new DateTime(2021, 11, 17), Estado = "Completado" };
            Venta E3v16 = new Venta() { Fecha = new DateTime(2021, 12, 23), Estado = "Completado" };
            Venta E3v17 = new Venta() { Fecha = new DateTime(2021, 12, 30), Estado = "Completado" };
            Venta E3v18 = new Venta() { Fecha = new DateTime(2021, 12, 17), Estado = "Completado" };
            Venta E3v19 = new Venta() { Fecha = new DateTime(2021, 11, 9), Estado = "Completado" };
            Venta E3v20 = new Venta() { Fecha = new DateTime(2021, 12, 13), Estado = "Completado" };
            Venta E3v21 = new Venta() { Fecha = new DateTime(2021, 11, 3), Estado = "Completado" };
            Venta E3v22 = new Venta() { Fecha = new DateTime(2021, 12, 21), Estado = "Completado" };
            Venta E3v23 = new Venta() { Fecha = new DateTime(2021, 10, 16), Estado = "Completado" };
            Venta E3v24 = new Venta() { Fecha = new DateTime(2021, 10, 13), Estado = "Completado" };
            Venta E3v25 = new Venta() { Fecha = new DateTime(2021, 11, 24), Estado = "Completado" };
            Venta E3v26 = new Venta() { Fecha = new DateTime(2021, 11, 13), Estado = "Completado" };
            Venta E3v27 = new Venta() { Fecha = new DateTime(2021, 12, 23), Estado = "Completado" };
            Venta E3v28 = new Venta() { Fecha = new DateTime(2021, 12, 26), Estado = "Completado" };
            Venta E3v29 = new Venta() { Fecha = new DateTime(2021, 10, 9), Estado = "Completado" };
            Venta E3v30 = new Venta() { Fecha = new DateTime(2021, 11, 10), Estado = "Completado" };


            Empleado Empleado3 = new Empleado()
            {
                Nombre = "Jose Salazar",
                Cedula = 1700546165,
                Correo = "jose17@gmail.com",
                Celular = 0984906571,
                Biometricos = new List<Biometrico>() { E3dia1,E3dia2,E3dia3,E3dia4,E3dia5,E3dia6,E3dia7,E3dia8,E3dia9,E3dia10,
                                                        E3dia11,E3dia12,E3dia13,E3dia14,E3dia15,E3dia16,E3dia17,E3dia18,E3dia19,E3dia20,
                                                        E3dia21,E3dia22,E3dia23,E3dia24,E3dia25,E3dia26,E3dia27,E3dia28,E3dia29,E3dia30,
                                                        E3dia31,E3dia32,E3dia33,E3dia34,E3dia35,E3dia36,E3dia37,E3dia38,E3dia39,E3dia40,
                                                        E3dia41,E3dia42,E3dia43,E3dia44,E3dia45,E3dia46,E3dia47,E3dia48,E3dia49,E3dia50,
                                                        E3dia51,E3dia52,E3dia53,E3dia54,E3dia55,E3dia56,E3dia57,E3dia58,E3dia59,E3dia60,
                                                        E3dia61,E3dia62,E3dia63,E3dia64,E3dia65,E3dia66,E3dia67,E3dia68,E3dia69,E3dia70,
                                                        E3dia71,E3dia72,E3dia73,E3dia74,E3dia75,E3dia76,E3dia77,E3dia78,E3dia79,
                                                        E3dia81,E3dia82,E3dia83,E3dia84,E3dia85,E3dia86,E3dia87,E3dia88,E3dia89,E3dia90
                },
                Permisos = new List<Permiso>() { },
                Ventas = new List<Venta>() { E3v1, E3v2,E3v3,E3v4,E3v5,E3v6,E3v7,E3v8,E3v9,E3v10,
                                             E3v11, E3v12,E3v13,E3v14,E3v15,E3v16,E3v17,E3v18,E3v19,E3v20,
                                             E3v21, E3v22,E3v23,E3v24,E3v25,E3v26,E3v27,E3v28,E3v29,E3v30,
                },
                Implemento = new Implemento()
                {
                    Estado = EstadoImplemento.Excelente,
                    Observacion = "Implementos de trabajo en buen estado"
                },

                Evaluacion = new Evaluacion()
                {
                    Fecha = new DateTime(2022, 01, 05),
                    Calificacion = Calificacion.Buena
                }
            };


            //EMPLEADO 4---------------------------------------------------------------------------------------------------
            Biometrico E4dia1 = new Biometrico() { Entrada = new DateTime(2021, 10, 1, 8, 0, 34), Salida = new DateTime(2021, 10, 1, 12, 3, 22), Fecha = new DateTime(2021, 10, 1), };
            Biometrico E4dia2 = new Biometrico() { Entrada = new DateTime(2021, 10, 2, 8, 2, 15), Salida = new DateTime(2021, 10, 2, 12, 0, 16), Fecha = new DateTime(2021, 10, 2), };
            Biometrico E4dia3 = new Biometrico() { Entrada = new DateTime(2021, 10, 3, 8, 7, 24), Salida = new DateTime(2021, 10, 3, 12, 4, 13), Fecha = new DateTime(2021, 10, 3), };
            Biometrico E4dia4 = new Biometrico() { Entrada = new DateTime(2021, 10, 4, 8, 1, 9), Salida = new DateTime(2021, 10, 4, 12, 3, 19), Fecha = new DateTime(2021, 10, 4), };
            Biometrico E4dia5 = new Biometrico() { Entrada = new DateTime(2021, 10, 5, 8, 5, 56), Salida = new DateTime(2021, 10, 5, 12, 2, 19), Fecha = new DateTime(2021, 10, 5), };
            Biometrico E4dia6 = new Biometrico() { Entrada = new DateTime(2021, 10, 6, 8, 3, 10), Salida = new DateTime(2021, 10, 6, 12, 3, 16), Fecha = new DateTime(2021, 10, 6), };
            Biometrico E4dia7 = new Biometrico() { Entrada = new DateTime(2021, 10, 7, 8, 4, 59), Salida = new DateTime(2021, 10, 7, 12, 0, 58), Fecha = new DateTime(2021, 10, 7), };
            Biometrico E4dia8 = new Biometrico() { Entrada = new DateTime(2021, 10, 8, 8, 3, 23), Salida = new DateTime(2021, 10, 8, 12, 2, 56), Fecha = new DateTime(2021, 10, 8), };
            Biometrico E4dia9 = new Biometrico() { Entrada = new DateTime(2021, 10, 9, 8, 5, 58), Salida = new DateTime(2021, 10, 9, 12, 1, 53), Fecha = new DateTime(2021, 10, 9), };
            Biometrico E4dia10 = new Biometrico() { Entrada = new DateTime(2021, 10, 10, 8, 6, 3), Salida = new DateTime(2021, 10, 10, 12, 5, 55), Fecha = new DateTime(2021, 10, 10), };
            Biometrico E4dia11 = new Biometrico() { Entrada = new DateTime(2021, 10, 11, 8, 7, 13), Salida = new DateTime(2021, 10, 11, 12, 5, 11), Fecha = new DateTime(2021, 10, 11), };
            Biometrico E4dia12 = new Biometrico() { Entrada = new DateTime(2021, 10, 12, 8, 0, 31), Salida = new DateTime(2021, 10, 12, 12, 0, 37), Fecha = new DateTime(2021, 10, 12), };
            Biometrico E4dia13 = new Biometrico() { Entrada = new DateTime(2021, 10, 13, 8, 6, 33), Salida = new DateTime(2021, 10, 13, 12, 1, 45), Fecha = new DateTime(2021, 10, 13), };
            Biometrico E4dia14 = new Biometrico() { Entrada = new DateTime(2021, 10, 14, 8, 4, 47), Salida = new DateTime(2021, 10, 14, 12, 3, 29), Fecha = new DateTime(2021, 10, 14), };
            Biometrico E4dia15 = new Biometrico() { Entrada = new DateTime(2021, 10, 15, 8, 6, 45), Salida = new DateTime(2021, 10, 15, 12, 0, 46), Fecha = new DateTime(2021, 10, 15), };
            Biometrico E4dia16 = new Biometrico() { Entrada = new DateTime(2021, 10, 16, 8, 0, 10), Salida = new DateTime(2021, 10, 16, 12, 0, 24), Fecha = new DateTime(2021, 10, 16), };
            Biometrico E4dia17 = new Biometrico() { Entrada = new DateTime(2021, 10, 17, 8, 6, 30), Salida = new DateTime(2021, 10, 17, 12, 5, 3), Fecha = new DateTime(2021, 10, 17), };
            Biometrico E4dia18 = new Biometrico() { Entrada = new DateTime(2021, 10, 18, 8, 0, 6), Salida = new DateTime(2021, 10, 18, 12, 3, 21), Fecha = new DateTime(2021, 10, 18), };
            Biometrico E4dia19 = new Biometrico() { Entrada = new DateTime(2021, 10, 19, 8, 7, 54), Salida = new DateTime(2021, 10, 19, 12, 5, 52), Fecha = new DateTime(2021, 10, 19), };
            Biometrico E4dia20 = new Biometrico() { Entrada = new DateTime(2021, 10, 20, 8, 4, 42), Salida = new DateTime(2021, 10, 20, 12, 2, 55), Fecha = new DateTime(2021, 10, 20), };
            Biometrico E4dia21 = new Biometrico() { Entrada = new DateTime(2021, 10, 21, 8, 1, 24), Salida = new DateTime(2021, 10, 21, 12, 5, 43), Fecha = new DateTime(2021, 10, 21), };
            Biometrico E4dia22 = new Biometrico() { Entrada = new DateTime(2021, 10, 22, 8, 5, 48), Salida = new DateTime(2021, 10, 22, 12, 1, 6), Fecha = new DateTime(2021, 10, 22), };
            Biometrico E4dia23 = new Biometrico() { Entrada = new DateTime(2021, 10, 23, 8, 6, 1), Salida = new DateTime(2021, 10, 23, 12, 0, 43), Fecha = new DateTime(2021, 10, 23), };
            Biometrico E4dia24 = new Biometrico() { Entrada = new DateTime(2021, 10, 24, 8, 0, 22), Salida = new DateTime(2021, 10, 24, 12, 3, 59), Fecha = new DateTime(2021, 10, 24), };
            Biometrico E4dia25 = new Biometrico() { Entrada = new DateTime(2021, 10, 25, 8, 2, 7), Salida = new DateTime(2021, 10, 25, 12, 1, 12), Fecha = new DateTime(2021, 10, 25), };
            Biometrico E4dia26 = new Biometrico() { Entrada = new DateTime(2021, 10, 26, 8, 4, 0), Salida = new DateTime(2021, 10, 26, 12, 0, 22), Fecha = new DateTime(2021, 10, 26), };
            Biometrico E4dia27 = new Biometrico() { Entrada = new DateTime(2021, 10, 27, 8, 7, 11), Salida = new DateTime(2021, 10, 27, 12, 1, 32), Fecha = new DateTime(2021, 10, 27), };
            Biometrico E4dia28 = new Biometrico() { Entrada = new DateTime(2021, 10, 28, 8, 1, 10), Salida = new DateTime(2021, 10, 28, 12, 5, 24), Fecha = new DateTime(2021, 10, 28), };
            Biometrico E4dia29 = new Biometrico() { Entrada = new DateTime(2021, 10, 29, 8, 0, 48), Salida = new DateTime(2021, 10, 29, 12, 5, 37), Fecha = new DateTime(2021, 10, 29), };
            Biometrico E4dia30 = new Biometrico() { Entrada = new DateTime(2021, 10, 30, 8, 3, 5), Salida = new DateTime(2021, 10, 30, 12, 2, 27), Fecha = new DateTime(2021, 10, 30), };
            Biometrico E4dia31 = new Biometrico() { Entrada = new DateTime(2021, 10, 31, 8, 5, 44), Salida = new DateTime(2021, 10, 31, 12, 5, 22), Fecha = new DateTime(2021, 10, 31), };
            Biometrico E4dia32 = new Biometrico() { Entrada = new DateTime(2021, 11, 1, 8, 3, 51), Salida = new DateTime(2021, 11, 1, 12, 4, 55), Fecha = new DateTime(2021, 11, 1), };
            Biometrico E4dia33 = new Biometrico() { Entrada = new DateTime(2021, 11, 2, 8, 4, 35), Salida = new DateTime(2021, 11, 2, 12, 2, 18), Fecha = new DateTime(2021, 11, 2), };
            Biometrico E4dia34 = new Biometrico() { Entrada = new DateTime(2021, 11, 3, 8, 6, 1), Salida = new DateTime(2021, 11, 3, 12, 4, 45), Fecha = new DateTime(2021, 11, 3), };
            Biometrico E4dia35 = new Biometrico() { Entrada = new DateTime(2021, 11, 4, 8, 4, 31), Salida = new DateTime(2021, 11, 4, 12, 2, 14), Fecha = new DateTime(2021, 11, 4), };
            Biometrico E4dia36 = new Biometrico() { Entrada = new DateTime(2021, 11, 5, 8, 0, 9), Salida = new DateTime(2021, 11, 5, 12, 2, 51), Fecha = new DateTime(2021, 11, 5), };
            Biometrico E4dia37 = new Biometrico() { Entrada = new DateTime(2021, 11, 6, 8, 0, 41), Salida = new DateTime(2021, 11, 6, 12, 5, 43), Fecha = new DateTime(2021, 11, 6), };
            Biometrico E4dia38 = new Biometrico() { Entrada = new DateTime(2021, 11, 7, 8, 6, 52), Salida = new DateTime(2021, 11, 7, 12, 3, 9), Fecha = new DateTime(2021, 11, 7), };
            Biometrico E4dia39 = new Biometrico() { Entrada = new DateTime(2021, 11, 8, 8, 6, 12), Salida = new DateTime(2021, 11, 8, 12, 2, 8), Fecha = new DateTime(2021, 11, 8), };
            Biometrico E4dia40 = new Biometrico() { Entrada = new DateTime(2021, 11, 9, 8, 4, 28), Salida = new DateTime(2021, 11, 9, 12, 5, 46), Fecha = new DateTime(2021, 11, 9), };
            Biometrico E4dia41 = new Biometrico() { Entrada = new DateTime(2021, 11, 10, 8, 7, 35), Salida = new DateTime(2021, 11, 10, 12, 5, 14), Fecha = new DateTime(2021, 11, 10), };
            Biometrico E4dia42 = new Biometrico() { Entrada = new DateTime(2021, 11, 11, 8, 6, 29), Salida = new DateTime(2021, 11, 11, 12, 1, 59), Fecha = new DateTime(2021, 11, 11), };
            Biometrico E4dia43 = new Biometrico() { Entrada = new DateTime(2021, 11, 12, 8, 5, 59), Salida = new DateTime(2021, 11, 12, 12, 0, 21), Fecha = new DateTime(2021, 11, 12), };
            Biometrico E4dia44 = new Biometrico() { Entrada = new DateTime(2021, 11, 13, 8, 7, 24), Salida = new DateTime(2021, 11, 13, 12, 0, 23), Fecha = new DateTime(2021, 11, 13), };
            Biometrico E4dia45 = new Biometrico() { Entrada = new DateTime(2021, 11, 14, 8, 6, 48), Salida = new DateTime(2021, 11, 14, 12, 1, 38), Fecha = new DateTime(2021, 11, 14), };
            Biometrico E4dia46 = new Biometrico() { Entrada = new DateTime(2021, 11, 15, 8, 6, 33), Salida = new DateTime(2021, 11, 15, 12, 5, 2), Fecha = new DateTime(2021, 11, 15), };
            Biometrico E4dia47 = new Biometrico() { Entrada = new DateTime(2021, 11, 16, 8, 4, 52), Salida = new DateTime(2021, 11, 16, 12, 0, 52), Fecha = new DateTime(2021, 11, 16), };
            Biometrico E4dia48 = new Biometrico() { Entrada = new DateTime(2021, 11, 17, 8, 4, 49), Salida = new DateTime(2021, 11, 17, 12, 3, 1), Fecha = new DateTime(2021, 11, 17), };
            Biometrico E4dia49 = new Biometrico() { Entrada = new DateTime(2021, 11, 18, 8, 0, 2), Salida = new DateTime(2021, 11, 18, 12, 5, 8), Fecha = new DateTime(2021, 11, 18), };
            Biometrico E4dia50 = new Biometrico() { Entrada = new DateTime(2021, 11, 19, 8, 5, 29), Salida = new DateTime(2021, 11, 19, 12, 3, 5), Fecha = new DateTime(2021, 11, 19), };
            Biometrico E4dia51 = new Biometrico() { Entrada = new DateTime(2021, 11, 20, 8, 7, 33), Salida = new DateTime(2021, 11, 20, 12, 2, 38), Fecha = new DateTime(2021, 11, 20), };
            Biometrico E4dia52 = new Biometrico() { Entrada = new DateTime(2021, 11, 21, 8, 3, 59), Salida = new DateTime(2021, 11, 21, 12, 2, 35), Fecha = new DateTime(2021, 11, 21), };
            Biometrico E4dia53 = new Biometrico() { Entrada = new DateTime(2021, 11, 22, 8, 4, 53), Salida = new DateTime(2021, 11, 22, 12, 0, 14), Fecha = new DateTime(2021, 11, 22), };
            Biometrico E4dia54 = new Biometrico() { Entrada = new DateTime(2021, 11, 23, 8, 5, 41), Salida = new DateTime(2021, 11, 23, 12, 1, 33), Fecha = new DateTime(2021, 11, 23), };
            Biometrico E4dia55 = new Biometrico() { Entrada = new DateTime(2021, 11, 24, 8, 6, 32), Salida = new DateTime(2021, 11, 24, 12, 3, 17), Fecha = new DateTime(2021, 11, 24), };
            Biometrico E4dia56 = new Biometrico() { Entrada = new DateTime(2021, 11, 25, 8, 5, 52), Salida = new DateTime(2021, 11, 25, 12, 3, 8), Fecha = new DateTime(2021, 11, 25), };
            Biometrico E4dia57 = new Biometrico() { Entrada = new DateTime(2021, 11, 26, 8, 2, 29), Salida = new DateTime(2021, 11, 26, 12, 2, 20), Fecha = new DateTime(2021, 11, 26), };
            Biometrico E4dia58 = new Biometrico() { Entrada = new DateTime(2021, 11, 27, 8, 2, 19), Salida = new DateTime(2021, 11, 27, 12, 5, 5), Fecha = new DateTime(2021, 11, 27), };
            Biometrico E4dia59 = new Biometrico() { Entrada = new DateTime(2021, 11, 28, 8, 3, 5), Salida = new DateTime(2021, 11, 28, 12, 5, 59), Fecha = new DateTime(2021, 11, 28), };
            Biometrico E4dia60 = new Biometrico() { Entrada = new DateTime(2021, 11, 29, 8, 2, 32), Salida = new DateTime(2021, 11, 29, 12, 2, 0), Fecha = new DateTime(2021, 11, 29), };
            Biometrico E4dia61 = new Biometrico() { Entrada = new DateTime(2021, 11, 30, 8, 3, 38), Salida = new DateTime(2021, 11, 30, 12, 2, 23), Fecha = new DateTime(2021, 11, 30), };
            Biometrico E4dia62 = new Biometrico() { Entrada = new DateTime(2021, 12, 1, 8, 3, 17), Salida = new DateTime(2021, 12, 1, 12, 2, 18), Fecha = new DateTime(2021, 12, 1), };
            Biometrico E4dia63 = new Biometrico() { Entrada = new DateTime(2021, 12, 2, 8, 3, 35), Salida = new DateTime(2021, 12, 2, 12, 5, 54), Fecha = new DateTime(2021, 12, 2), };
            Biometrico E4dia64 = new Biometrico() { Entrada = new DateTime(2021, 12, 3, 8, 0, 19), Salida = new DateTime(2021, 12, 3, 12, 0, 26), Fecha = new DateTime(2021, 12, 3), };
            Biometrico E4dia65 = new Biometrico() { Entrada = new DateTime(2021, 12, 4, 8, 1, 11), Salida = new DateTime(2021, 12, 4, 12, 5, 39), Fecha = new DateTime(2021, 12, 4), };
            Biometrico E4dia66 = new Biometrico() { Entrada = new DateTime(2021, 12, 5, 8, 0, 55), Salida = new DateTime(2021, 12, 5, 12, 2, 42), Fecha = new DateTime(2021, 12, 5), };
            Biometrico E4dia67 = new Biometrico() { Entrada = new DateTime(2021, 12, 6, 8, 6, 11), Salida = new DateTime(2021, 12, 6, 12, 2, 16), Fecha = new DateTime(2021, 12, 6), };
            Biometrico E4dia68 = new Biometrico() { Entrada = new DateTime(2021, 12, 7, 8, 1, 3), Salida = new DateTime(2021, 12, 7, 12, 2, 53), Fecha = new DateTime(2021, 12, 7), };
            Biometrico E4dia69 = new Biometrico() { Entrada = new DateTime(2021, 12, 8, 8, 0, 42), Salida = new DateTime(2021, 12, 8, 12, 4, 59), Fecha = new DateTime(2021, 12, 8), };
            Biometrico E4dia70 = new Biometrico() { Entrada = new DateTime(2021, 12, 9, 8, 6, 15), Salida = new DateTime(2021, 12, 9, 12, 2, 1), Fecha = new DateTime(2021, 12, 9), };
            Biometrico E4dia71 = new Biometrico() { Entrada = new DateTime(2021, 12, 10, 8, 0, 31), Salida = new DateTime(2021, 12, 10, 12, 4, 39), Fecha = new DateTime(2021, 12, 10), };
            Biometrico E4dia72 = new Biometrico() { Entrada = new DateTime(2021, 12, 11, 8, 1, 47), Salida = new DateTime(2021, 12, 11, 12, 3, 50), Fecha = new DateTime(2021, 12, 11), };
            Biometrico E4dia73 = new Biometrico() { Entrada = new DateTime(2021, 12, 12, 8, 3, 2), Salida = new DateTime(2021, 12, 12, 12, 1, 1), Fecha = new DateTime(2021, 12, 12), };
            Biometrico E4dia74 = new Biometrico() { Entrada = new DateTime(2021, 12, 13, 8, 6, 51), Salida = new DateTime(2021, 12, 13, 12, 1, 24), Fecha = new DateTime(2021, 12, 13), };
            Biometrico E4dia75 = new Biometrico() { Entrada = new DateTime(2021, 12, 14, 8, 1, 13), Salida = new DateTime(2021, 12, 14, 12, 0, 0), Fecha = new DateTime(2021, 12, 14), };
            Biometrico E4dia76 = new Biometrico() { Entrada = new DateTime(2021, 12, 15, 8, 6, 52), Salida = new DateTime(2021, 12, 15, 12, 3, 35), Fecha = new DateTime(2021, 12, 15), };
            Biometrico E4dia77 = new Biometrico() { Entrada = new DateTime(2021, 12, 16, 8, 6, 5), Salida = new DateTime(2021, 12, 16, 12, 5, 19), Fecha = new DateTime(2021, 12, 16), };
            Biometrico E4dia78 = new Biometrico() { Entrada = new DateTime(2021, 12, 17, 8, 1, 33), Salida = new DateTime(2021, 12, 17, 12, 5, 34), Fecha = new DateTime(2021, 12, 17), };
            Biometrico E4dia79 = new Biometrico() { Entrada = new DateTime(2021, 12, 18, 8, 4, 25), Salida = new DateTime(2021, 12, 18, 12, 4, 27), Fecha = new DateTime(2021, 12, 18), };
            Biometrico E4dia80 = new Biometrico() { Entrada = new DateTime(2021, 12, 19, 8, 6, 13), Salida = new DateTime(2021, 12, 19, 12, 1, 10), Fecha = new DateTime(2021, 12, 19), };
            Biometrico E4dia81 = new Biometrico() { Entrada = new DateTime(2021, 12, 20, 8, 4, 28), Salida = new DateTime(2021, 12, 20, 12, 5, 31), Fecha = new DateTime(2021, 12, 20), };
            Biometrico E4dia82 = new Biometrico() { Entrada = new DateTime(2021, 12, 21, 8, 1, 58), Salida = new DateTime(2021, 12, 21, 12, 3, 43), Fecha = new DateTime(2021, 12, 21), };
            Biometrico E4dia83 = new Biometrico() { Entrada = new DateTime(2021, 12, 22, 8, 0, 22), Salida = new DateTime(2021, 12, 22, 12, 3, 48), Fecha = new DateTime(2021, 12, 22), };
            Biometrico E4dia84 = new Biometrico() { Entrada = new DateTime(2021, 12, 23, 8, 3, 57), Salida = new DateTime(2021, 12, 23, 12, 0, 44), Fecha = new DateTime(2021, 12, 23), };
            Biometrico E4dia85 = new Biometrico() { Entrada = new DateTime(2021, 12, 24, 8, 1, 14), Salida = new DateTime(2021, 12, 24, 12, 1, 51), Fecha = new DateTime(2021, 12, 24), };
            Biometrico E4dia86 = new Biometrico() { Entrada = new DateTime(2021, 12, 25, 8, 5, 17), Salida = new DateTime(2021, 12, 25, 12, 4, 52), Fecha = new DateTime(2021, 12, 25), };
            Biometrico E4dia87 = new Biometrico() { Entrada = new DateTime(2021, 12, 26, 8, 7, 49), Salida = new DateTime(2021, 12, 26, 12, 4, 56), Fecha = new DateTime(2021, 12, 26), };
            Biometrico E4dia88 = new Biometrico() { Entrada = new DateTime(2021, 12, 27, 8, 6, 54), Salida = new DateTime(2021, 12, 27, 12, 1, 41), Fecha = new DateTime(2021, 12, 27), };
            Biometrico E4dia89 = new Biometrico() { Entrada = new DateTime(2021, 12, 28, 8, 5, 46), Salida = new DateTime(2021, 12, 28, 12, 0, 4), Fecha = new DateTime(2021, 12, 28), };
            Biometrico E4dia90 = new Biometrico() { Entrada = new DateTime(2021, 12, 29, 8, 3, 14), Salida = new DateTime(2021, 12, 29, 12, 3, 52), Fecha = new DateTime(2021, 12, 29), };

            //VENTAS
            Venta E4v1 = new Venta() { Fecha = new DateTime(2021, 12, 15), Estado = "Completado" };
            Venta E4v2 = new Venta() { Fecha = new DateTime(2021, 11, 21), Estado = "Completado" };
            Venta E4v3 = new Venta() { Fecha = new DateTime(2021, 12, 20), Estado = "Completado" };
            Venta E4v4 = new Venta() { Fecha = new DateTime(2021, 10, 29), Estado = "Completado" };
            Venta E4v5 = new Venta() { Fecha = new DateTime(2021, 12, 13), Estado = "Completado" };
            Venta E4v6 = new Venta() { Fecha = new DateTime(2021, 12, 27), Estado = "Completado" };
            Venta E4v7 = new Venta() { Fecha = new DateTime(2021, 10, 28), Estado = "Completado" };
            Venta E4v8 = new Venta() { Fecha = new DateTime(2021, 11, 16), Estado = "Completado" };
            Venta E4v9 = new Venta() { Fecha = new DateTime(2021, 12, 4), Estado = "Completado" };
            Venta E4v10 = new Venta() { Fecha = new DateTime(2021, 12, 28), Estado = "Completado" };
            Venta E4v11 = new Venta() { Fecha = new DateTime(2021, 10, 3), Estado = "Completado" };
            Venta E4v12 = new Venta() { Fecha = new DateTime(2021, 12, 7), Estado = "Completado" };
            Venta E4v13 = new Venta() { Fecha = new DateTime(2021, 10, 22), Estado = "Completado" };
            Venta E4v14 = new Venta() { Fecha = new DateTime(2021, 10, 18), Estado = "Completado" };
            Venta E4v15 = new Venta() { Fecha = new DateTime(2021, 11, 8), Estado = "Completado" };
            Venta E4v16 = new Venta() { Fecha = new DateTime(2021, 10, 24), Estado = "Completado" };
            Venta E4v17 = new Venta() { Fecha = new DateTime(2021, 12, 8), Estado = "Completado" };
            Venta E4v18 = new Venta() { Fecha = new DateTime(2021, 11, 21), Estado = "Completado" };
            Venta E4v19 = new Venta() { Fecha = new DateTime(2021, 12, 29), Estado = "Completado" };
            Venta E4v20 = new Venta() { Fecha = new DateTime(2021, 10, 23), Estado = "Completado" };
            Venta E4v21 = new Venta() { Fecha = new DateTime(2021, 12, 13), Estado = "Completado" };
            Venta E4v22 = new Venta() { Fecha = new DateTime(2021, 11, 10), Estado = "Completado" };
            Venta E4v23 = new Venta() { Fecha = new DateTime(2021, 11, 29), Estado = "Completado" };
            Venta E4v24 = new Venta() { Fecha = new DateTime(2021, 12, 8), Estado = "Completado" };
            Venta E4v25 = new Venta() { Fecha = new DateTime(2021, 11, 6), Estado = "Completado" };
            Venta E4v26 = new Venta() { Fecha = new DateTime(2021, 12, 25), Estado = "Completado" };
            Venta E4v27 = new Venta() { Fecha = new DateTime(2021, 12, 22), Estado = "Completado" };
            Venta E4v28 = new Venta() { Fecha = new DateTime(2021, 10, 27), Estado = "Completado" };
            Venta E4v29 = new Venta() { Fecha = new DateTime(2021, 12, 22), Estado = "Completado" };
            Venta E4v30 = new Venta() { Fecha = new DateTime(2021, 10, 23), Estado = "Completado" };

            Empleado Empleado4 = new Empleado()
            {
                Nombre = "Freddy Villena",
                Cedula = 1756983546,
                Correo = "freddyvill@gmail.com",
                Celular = 0987456530,
                Biometricos = new List<Biometrico>() { E4dia1,E4dia2,E4dia3,E4dia4,E4dia5,E4dia6,E4dia7,E4dia8,E4dia9,E4dia10,
                                                        E4dia11,E4dia12,E4dia13,E4dia14,E4dia15,E4dia16,E4dia17,E4dia18,E4dia19,E4dia20,
                                                        E4dia21,E4dia22,E4dia23,E4dia24,E4dia25,E4dia26,E4dia27,E4dia28,E4dia29,E4dia30,
                                                        E4dia31,E4dia32,E4dia33,E4dia34,E4dia35,E4dia36,E4dia37,E4dia38,E4dia39,E4dia40,
                                                        E4dia41,E4dia42,E4dia43,E4dia44,E4dia45,E4dia46,E4dia47,E4dia48,E4dia49,E4dia50,
                                                        E4dia51,E4dia52,E4dia53,E4dia54,E4dia55,E4dia56,E4dia57,E4dia58,E4dia59,E4dia60,
                                                        E4dia61,E4dia62,E4dia63,E4dia64,E4dia65,E4dia66,E4dia67,E4dia68,E4dia69,E4dia70,
                                                        E4dia71,E4dia72,E4dia73,E4dia74,E4dia75,E4dia76,E4dia77,E4dia78,E4dia79,E4dia80,
                                                        E4dia81,E4dia82,E4dia83,E4dia84,E4dia85,E4dia86,E4dia87,E4dia88,E4dia89,E4dia90
                },
                Permisos = new List<Permiso>() { },
                Ventas = new List<Venta>() { E4v1, E4v2,E4v3,E4v4,E4v5,E4v6,E4v7,E4v8,E4v9,E4v10,
                                             E4v11, E4v12,E4v13,E4v14,E4v15,E4v16,E4v17,E4v18,E4v19,E4v20,
                                             E4v21, E4v22,E4v23,E4v24,E4v25,E4v26,E4v27,E4v28,E4v29,E4v30,
                },
                Implemento = new Implemento()
                {
                    Estado = EstadoImplemento.Excelente,
                    Observacion = "Implementos de trabajo en buen estado"
                },

                Evaluacion = new Evaluacion()
                {
                    Fecha = new DateTime(2022, 01, 05),
                    Calificacion = Calificacion.Excelente
                }
            };


            //LISTA EMPLEADOS

            List<Empleado> listaEmpleados = new List<Empleado>()
            {
                Empleado1,Empleado2,Empleado3,Empleado4
            };


            //Capacitaciones Asistencia

            Capacitacion Capacitacion1 = new Capacitacion()
            {
                Tema = "Inducción",
                Fecha = new DateTime(2021, 10, 5, 13, 1, 29),

            };
            Capacitacion Capacitacion2 = new Capacitacion()
            {
                Tema = "Manejo CRM",
                Fecha = new DateTime(2021, 10, 15, 13, 5, 59),

            };
            Capacitacion Capacitacion3 = new Capacitacion()
            {
                Tema = "Atención a Cliente",
                Fecha = new DateTime(2021, 10, 29, 14, 8, 37),

            };
            Capacitacion Capacitacion4 = new Capacitacion()
            {
                Tema = "Manejo de Sistema GPS",
                Fecha = new DateTime(2021, 11, 15, 14, 3, 49),

            };
            Capacitacion Capacitacion5 = new Capacitacion()
            {
                Tema = "Nuevos Productos",
                Fecha = new DateTime(2021, 11, 29, 13, 21, 59),

            };

            List<Capacitacion> listaCapacitacion = new List<Capacitacion>()
            {
                Capacitacion1,Capacitacion2,Capacitacion3,Capacitacion4,Capacitacion5
            };

            //Asistencias

            CapacitacionAsistencia CapE1As1 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion1,
                Empleado = Empleado1
            };

            CapacitacionAsistencia CapE1As2 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion2,
                Empleado = Empleado1
            };
            CapacitacionAsistencia CapE1As3 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion3,
                Empleado = Empleado1
            };
            CapacitacionAsistencia CapE1As4 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion4,
                Empleado = Empleado1
            };
            CapacitacionAsistencia CapE1As5 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion5,
                Empleado = Empleado1
            };

            //EMPLEADO 2
            CapacitacionAsistencia CapE2As1 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion1,
                Empleado = Empleado2
            };

            CapacitacionAsistencia CapE2As2 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion2,
                Empleado = Empleado2
            };
            CapacitacionAsistencia CapE2As3 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion3,
                Empleado = Empleado2
            };
            CapacitacionAsistencia CapE2As4 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion4,
                Empleado = Empleado2
            };
            CapacitacionAsistencia CapE2As5 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion5,
                Empleado = Empleado2
            };

            //EMPLEADO 3
            CapacitacionAsistencia CapE3As1 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion1,
                Empleado = Empleado3
            };

            CapacitacionAsistencia CapE3As2 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion2,
                Empleado = Empleado3
            };
            CapacitacionAsistencia CapE3As3 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion3,
                Empleado = Empleado3
            };
            CapacitacionAsistencia CapE3As4 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion4,
                Empleado = Empleado3
            };
            CapacitacionAsistencia CapE3As5 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion5,
                Empleado = Empleado3
            };

            //EMPLEADO 4
            CapacitacionAsistencia CapE4As1 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion1,
                Empleado = Empleado4
            };

            CapacitacionAsistencia CapE4As2 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion2,
                Empleado = Empleado4
            };

            /*CapacitacionAsistencia CapE4As3 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion3,
                Empleado = Empleado4
            };
            */

            CapacitacionAsistencia CapE4As4 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion4,
                Empleado = Empleado4
            };
            CapacitacionAsistencia CapE4As5 = new CapacitacionAsistencia()
            {
                Capacitacion = Capacitacion5,
                Empleado = Empleado4
            };


            List<CapacitacionAsistencia> listaCapacitacionAsistencias = new List<CapacitacionAsistencia>()
            {
                CapE1As1,CapE1As2,CapE1As3,CapE1As4,CapE1As5,
                CapE2As1,CapE2As2,CapE2As3,CapE2As4,CapE2As5,
                CapE3As1,CapE3As2,CapE3As3,CapE3As4,CapE3As5,
                CapE4As1,CapE4As2,CapE4As4,CapE4As5,

            };

             Configuracion config = new Configuracion()
            {
                DiasMinimos = 90,
                EmpresaNombre = "Empresa ASAA",
                HorasTotales = 360,
                VentasMinimo = 30
            };
            List<Configuracion> listaConfiguracion = new List<Configuracion>() { config };



            //PeriodoPruebaDB repos = new PeriodoPruebaDB();
            //repos.Empleados.Add(Empleado1);
            //repos.SaveChanges();



            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.AsistenciaCapacitacion, listaCapacitacionAsistencias  },
                { ListasTipo.Empleados, listaEmpleados },
                { ListasTipo.Capacitaciones, listaCapacitacion },
                { ListasTipo.Configuracion, listaConfiguracion }



            };

            return dicListasDatos;
        }
    }
}
