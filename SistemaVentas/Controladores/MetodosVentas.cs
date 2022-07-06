using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Clases
{
    public class MetodosVentas
    {
        MySqlConnection sqlConexion = new MySqlConnection();

        public string AgregarVenta(DateTime idVenta, DateTime fechaVenta, int idusuario, List<Venta> listaVenta, double totalVenta)
        {
            string respuesta = "";
            string idProductos = obtenerIdListaProductos(listaVenta);
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarVenta", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idVenta", MySqlDbType.DateTime).Value = idVenta;
                comando.Parameters.Add("@fechaVenta", MySqlDbType.DateTime).Value = fechaVenta;
                comando.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idusuario;
                comando.Parameters.Add("@idProductos", MySqlDbType.MediumText).Value = idProductos;
                comando.Parameters.Add("@total", MySqlDbType.Double).Value = totalVenta;
                
                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "SE INSERTO CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO INSERTAR EL REGISTRO";
                }

                return respuesta;
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

        public void ActualizaStock(List<Venta> listaVenta)
        {
            for (int i = 0; i < listaVenta.Count; i++)
            {
                try
                {
                    sqlConexion = new Conexion().obtenerConexion();
                    MySqlCommand comando = new MySqlCommand("ActualizarStock", sqlConexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = listaVenta.ElementAt(i).producto.idProducto.Trim();
                    comando.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = listaVenta.ElementAt(i).cantidad;

                    sqlConexion.Open();
                    comando.ExecuteNonQuery();
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

        public string obtenerIdListaProductos(List<Venta> listaVenta)
        {
            string identificadores = "";

            for (int i = 0; i < listaVenta.Count; i++)
            {
                if (i == 0)
                {
                    identificadores = listaVenta.ElementAt(i).cantidad + "-" + listaVenta.ElementAt(i).producto.idProducto;
                } 
                else
                {
                    identificadores = identificadores + "," + listaVenta.ElementAt(i).cantidad + "-" + listaVenta.ElementAt(i).producto.idProducto;
                }
            }

            return identificadores;
        }
    }
}
