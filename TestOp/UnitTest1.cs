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
        [InlineData(4,4)]
        [InlineData(95,3)]
        [InlineData(3,4)]
        [InlineData(106,3)]
        [InlineData(5,4)]
        [InlineData(6,4)]
        [InlineData(7,4)]
        [InlineData(8,4)]
        [InlineData(9,4)]
        [InlineData(10,4)]
        [InlineData(123,3)]
        [InlineData(200,4)]
        [InlineData(210,3)]
        public void Test1(int bioId, int resEsperado)
        {
            int resCalc;
            string empleado;
            string msg;



            var db = DBBuilder.GetDB();
            var biometrico = db.Biometricos.Find(bioId);

            Biometrico bio = db.Biometricos
                .Include(bio => bio.Empleado)
                .Single(bio => bio.BiometricoId == bioId);

            var calc = new CalcHoras();


            empleado = bio.Empleado.Nombre;
            msg = $"{empleado} ";
            resCalc = calc.HoraTotal(biometrico);
            Assert.True(resEsperado == resCalc,
                " Esperado "+ resEsperado + " != " + msg);
        }
    }
}
