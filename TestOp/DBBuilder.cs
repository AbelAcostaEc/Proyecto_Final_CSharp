using AppConsola;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOp
{
    public sealed class DBBuilder
    {
        private DBBuilder() { }

        private static PeriodoPruebaDB db;

        public static PeriodoPruebaDB GetDB()
        {
            if (db == null)
            {
                Grabar grabar = new Grabar();
                grabar.DatosIni();
                db = PeriodoPruebaDBBuilder.Crear();
            }
            return db;
        }
    }
}
