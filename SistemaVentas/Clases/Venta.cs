using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Clases
{
    public class Venta
    {
        public string idVenta { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public double costo { get; set; }
        public string idProductos { get; set; }
        public string fechaVenta { get; set; }
        public string horaVenta { get; set; }
        public string idVendedor { get; set; }
        public string nomVendedor { get; set; }
        public double totalVenta { get; set; }

        public Venta(Producto producto, int cantidad, double costo)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.costo = costo;
        }

        public Venta(string idVenta, string idUsuario, string nomUsuario, string idProductos, double totalVenta)
        {
            this.idVenta = idVenta;
            this.idVendedor = idUsuario;
            this.nomVendedor = nomUsuario;
            this.idProductos = idProductos;
            this.totalVenta = totalVenta;
        }

    }
}
