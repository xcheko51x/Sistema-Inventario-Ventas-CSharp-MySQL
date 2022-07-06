using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Clases
{
    public class Producto
    {
        public string idProducto { get; set; }
        public string nomProducto { get; set; }
        public string stock { get; set; }
        public string precio { get; set; }
        public string descripcion { get; set; }
        public string idProveedor { get; set; }
        public string nomProveedor { get; set; }

        public int cantidadVendida { get; set; }

        public Producto(string idProducto, string nomProducto, string stock, string precio, string descripcion, string idProveedor, string nomProveedor)
        {
            this.idProducto = idProducto;
            this.nomProducto = nomProducto;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.idProveedor = idProveedor;
            this.nomProveedor = nomProveedor;
        }

        public Producto(string idProducto, string nomProducto, string stock, string precio, string descripcion, string idProveedor)
        {
            this.idProducto = idProducto;
            this.nomProducto = nomProducto;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.idProveedor = idProveedor;
        }

        public Producto(string idProducto, string nomProducto,string stock, string precio, string descripcion)
        {
            this.idProducto = idProducto;
            this.nomProducto = nomProducto;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            
        }

        public Producto(string idProducto, string nomProducto, int cantidadVendida)
        {
            this.idProducto = idProducto;
            this.nomProducto = nomProducto;
            this.cantidadVendida = cantidadVendida;
        }
    }
}
