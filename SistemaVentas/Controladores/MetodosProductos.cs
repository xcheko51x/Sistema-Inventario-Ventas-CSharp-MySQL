using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Clases
{
    public class MetodosProductos
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();
        Producto producto;
        string nomProducto;

        public DataTable ObtenerProductos()
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProductos", sqlConexion);
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

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProveedores.Add(
                        new Proveedor(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                            )
                        );
                }

                return listaProveedores;
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

        public string ValidarProducto(Producto producto)
        {
            string resultado = null;

            if (producto.idProducto.Equals("") || producto.nomProducto.Equals("") || producto.stock.Equals("") || producto.precio.Equals("") || producto.descripcion.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }

        public string AgregarProducto(Producto producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idProducto", MySqlDbType.VarChar).Value = producto.idProducto;
                comando.Parameters.Add("@nomProducto", MySqlDbType.VarChar).Value = producto.nomProducto;
                comando.Parameters.Add("@stock", MySqlDbType.Int32).Value = producto.stock;
                comando.Parameters.Add("@precio", MySqlDbType.Double).Value = producto.precio;
                comando.Parameters.Add("@descripcion", MySqlDbType.Text).Value = producto.descripcion;
                comando.Parameters.Add("@idProveedor", MySqlDbType.Int32).Value = producto.idProveedor;
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

        public string ActualizarProducto(Producto producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(producto.idProducto);
                comando.Parameters.Add("@nomProducto", MySqlDbType.VarChar).Value = producto.nomProducto;
                comando.Parameters.Add("@stock", MySqlDbType.Int32).Value = Convert.ToInt32(producto.stock);
                comando.Parameters.Add("@precio", MySqlDbType.Double).Value = Convert.ToDouble(producto.precio);
                comando.Parameters.Add("@descripcion", MySqlDbType.Text).Value = producto.descripcion;
                comando.Parameters.Add("@idProveedor", MySqlDbType.Int32).Value = Convert.ToInt32(producto.idProveedor);

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

        public DataTable BuscarProducto(string producto)
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@producto", MySqlDbType.VarChar).Value = producto.Trim();
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

        public Producto BuscarProductoVenta(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProductoVenta", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {

                    producto = new Producto(
                        resultado.GetString(0),
                        resultado.GetString(1),
                        resultado.GetString(2),
                        resultado.GetString(3),
                        resultado.GetString(4)
                        );
                }

                return producto;
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

        public string ObtenerNombreProducto(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerNombreProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                
                while (resultado.Read())
                {
                    nomProducto = resultado.GetString(0);
                }

                return nomProducto;
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
