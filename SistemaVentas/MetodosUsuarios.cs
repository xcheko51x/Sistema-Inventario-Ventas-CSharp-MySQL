using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas
{
    public class MetodosUsuarios
    {

        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerUsuarios()
        {
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerUsuarios", sqlConexion);
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

        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerPermisos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaPermisos.Add(
                        new Permiso(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                            )
                        );
                }

                return listaPermisos;
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

        public List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();

            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerEstados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaEstados.Add(
                        new Estado(
                            resultado.GetInt32(0),
                            resultado.GetInt32(1),
                            resultado.GetString(2)
                            )
                        );
                }

                return listaEstados;
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

        public string ValidarUsuario(Usuario usuario)
        {
            string resultado = null;

            if (usuario.nomUsuario.Equals("") || usuario.usuario.Equals("") || usuario.contrasena.Equals("") || usuario.idPermiso == 0 || usuario.idEstado == 0)
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            } else
            {
                resultado = AgregarUsuario(usuario);
            }

            return resultado;
        }

        public string AgregarUsuario(Usuario nuevoUsuario)
        {
            string respuesta = "";
            try
            {
                sqlConexion = new Conexion().obtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nomUsuario", MySqlDbType.VarChar).Value = nuevoUsuario.nomUsuario;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = nuevoUsuario.usuario;
                comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = nuevoUsuario.contrasena;
                comando.Parameters.Add("@idPermiso", MySqlDbType.Int32).Value = nuevoUsuario.idPermiso;
                comando.Parameters.Add("@idEstado", MySqlDbType.Int32).Value = nuevoUsuario.idEstado;
                sqlConexion.Open();
                if(comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                } else
                {
                    respuesta = "ERROR";
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
    }
}
