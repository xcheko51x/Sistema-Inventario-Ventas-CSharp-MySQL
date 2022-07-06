using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int idPermiso { get; set; }
        public int idEstado { get; set; }

        public double totalVendido { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, string nomUsuario, string usuario, string contrasena, int idPermiso, int idEstado)
        {
            this.idUsuario = idUsuario;
            this.nomUsuario = nomUsuario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.idPermiso = idPermiso;
            this.idEstado = idEstado;
        }

        public Usuario(string nomUsuario, string usuario, string contrasena, int idPermiso, int idEstado)
        {
            this.nomUsuario = nomUsuario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.idPermiso = idPermiso;
            this.idEstado = idEstado;
        }

        public Usuario(int idUsuario, string nomUsuario, double totalVendido)
        {
            this.idUsuario = idUsuario;
            this.nomUsuario = nomUsuario;
            this.totalVendido = totalVendido;
        }
    }
}
