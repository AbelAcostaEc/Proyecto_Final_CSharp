using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Configuration;

namespace AppConsola
{
    public class PeriodoPruebaDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria }
        static PeriodoPruebaDB db;

        public static PeriodoPruebaDB Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

            DbContextOptions<PeriodoPruebaDB> contextOptions;

            switch (dbtipo)
            {
                case "SqlServer":
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case "Postgres":
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new PeriodoPruebaDB(contextOptions);

            return db;
        }
    }
}
