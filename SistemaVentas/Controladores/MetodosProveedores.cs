using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Clases
{
    public class MetodosProveedores
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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

        public string AgregarProveedor(Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nomProveedor", MySqlDbType.VarChar).Value = proveedor.nomProveedor;
                comando.Parameters.Add("@numContacto", MySqlDbType.VarChar).Value = proveedor.numContacto;
                comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = proveedor.direccion;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = proveedor.email;
                
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

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = nombre.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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

        public string ActualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;
                comando.Parameters.Add("@nomProveedor", MySqlDbType.VarChar).Value = proveedor.nomProveedor;
                comando.Parameters.Add("@numContacto", MySqlDbType.VarChar).Value = proveedor.numContacto;
                comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = proveedor.direccion;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = proveedor.email;
                
                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "SE ACTUALIZO CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO ACTUALIZAR EL REGISTRO";
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

        public string ValidarProveedor(Proveedor proveedor)
        {
            string resultado = null;

            if (proveedor.nomProveedor.Equals("") || proveedor.numContacto.Equals("") || proveedor.direccion.Equals("") || proveedor.email.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }
    }
}
