using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaMecanico
{
    class ClassConection
    {
       static ClassConection adminDB;
       public MySqlConnectionStringBuilder builder;
       MySqlConnection conexion;

        private ClassConection() {
            getConection();
        }

        public static ClassConection crearAdminDB() 
        {
            if (adminDB == null)
                adminDB = new ClassConection();
            return adminDB;
        }

        public  MySqlConnection getConection()
        {
            builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "bd_mecanico";
            if (conexion == null)
                conexion = new MySqlConnection(builder.ToString());
            return conexion;
        }
    }
}
