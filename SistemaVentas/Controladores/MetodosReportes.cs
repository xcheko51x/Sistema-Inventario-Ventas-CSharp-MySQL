using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Clases
{
    public class MetodosReportes
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();
        List<Reporte> listaReporte;

        public List<Reporte> ObtenerReporteVentas(string fechaInicial, string fechaFinal)
        {

            listaReporte = new List<Reporte>();
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerVentas", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fechaInicial", MySqlDbType.VarChar).Value = fechaInicial.Trim();
                comando.Parameters.Add("@fechaFinal", MySqlDbType.VarChar).Value = fechaFinal.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    listaReporte.Add(
                        new Reporte(
                            resultado.GetString(0),
                            resultado.GetString(1),
                            resultado.GetString(2),
                            resultado.GetString(3),
                            resultado.GetString(4),
                            resultado.GetString(5)
                            )
                        );
                }

                return listaReporte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }
    }
}
