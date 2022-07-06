using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Clases
{
    public class Reporte
    {
        public string idVenta { get; set; }
        public string fechaVenta { get; set; }
        public string idUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string idProductos { get; set; }
        public string totalVenta { get; set; }

        public Reporte(string idVenta, string fechaVenta, string idUsuario, string idProductos, string totalVenta, string nomUsuario)
        {
            this.idVenta = idVenta;
            this.fechaVenta = fechaVenta;
            this.idUsuario = idUsuario;
            this.idProductos = idProductos;
            this.totalVenta = totalVenta;
            this.nomUsuario = nomUsuario;
        }
    }
}
