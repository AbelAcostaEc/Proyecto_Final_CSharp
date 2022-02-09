using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using System;
using System.Linq;
using Xunit;

namespace TestOp
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,4)]
        [InlineData(2,4)]
        [InlineData(3,4)]
        [InlineData(4,4)]
        [InlineData(5,4)]
        [InlineData(95,3)]
        [InlineData(96,4)]
        [InlineData(106,3)]
        [InlineData(109,3)]
        [InlineData(113,4)]
        [InlineData(180,3)]
        [InlineData(181,3)]
        [InlineData(188,3)]
        [InlineData(191,4)]
        [InlineData(192,4)]
        [InlineData(269,4)]
        [InlineData(270,4)]
        [InlineData(271,4)]
        [InlineData(272,4)]
        [InlineData(273,4)]
        public void ValidacionHoras(int biometricoId, int resEsperado)
        {
            int resCalc;
            string empleado;
            string msg;


            //busca el biometrico dependiendo el id birndado en InlineData
            var db = DBBuilder.GetDB();
            var biometrico = db.Biometricos.Find(biometricoId);

            // mostrar mensaje
            Biometrico bio = db.Biometricos
                .Include(bio => bio.Empleado)
                .Single(bio => bio.BiometricoId == biometricoId);

            //para calcular horas con la operacion que esta en modelo
            var calc = new CalcHoras();

            //mensaje
            empleado = bio.Empleado.Nombre;
            msg = $"{empleado} ";

            //calcular horas con la operacion del modelo
            resCalc = calc.HoraTotal(biometrico);
            // verifciar si coincide resultado esperado con el calculado
            Assert.True(resEsperado == resCalc,
                " Esperado "+ resEsperado + " != " + msg);
        }
    }
}
