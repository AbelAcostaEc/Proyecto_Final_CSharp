using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Configuration;

namespace AppConsola
{
    public class PeriodoPruebaDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres,Mysql, Memoria }
        static PeriodoPruebaDB db;

        public static PeriodoPruebaDB Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config

            string dbtipo;
            string conn;

            dbtipo= ConfigurationManager.AppSettings[DBTipo];

            if (dbtipo== null)
            {
                dbtipo = "Memoria";
                conn = "PeriodoPrueba_DBMemoria";
            }
            else
            {
                conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;
            }


            //construye la conexion acorde  con el tipo
            DbContextOptions<PeriodoPruebaDB> contextOptions;

            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Mysql):
                    contextOptions = new DbContextOptionsBuilder<PeriodoPruebaDB>()
                        .UseMySQL(conn)
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
