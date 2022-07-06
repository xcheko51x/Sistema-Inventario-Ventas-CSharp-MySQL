using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaVentas
{
    public class Conexion
    {
        private string db;
        private string servidor;
        private string usuario;
        private string contrasena;
        private string ssl;
        //private static Conexion conn = null;

        public Conexion()
        {
            this.db = "sistemaventas";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contrasena = "";
            this.ssl = "None";
        }

        public MySqlConnection obtenerConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Database=" + db + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + contrasena + "; SSL Mode=" + ssl + ";";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }
}
