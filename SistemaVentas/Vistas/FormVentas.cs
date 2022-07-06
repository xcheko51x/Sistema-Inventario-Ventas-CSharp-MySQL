using SistemaVentas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas
{
    public partial class FormVentas : Form
    {
        MetodosProductos metodosProductos;
        MetodosVentas metodosVentas;
        List<Venta> listaVenta = new List<Venta>();
        Producto producto;
        Venta productosVenta;
        public int idUsuario;
        string fecha;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            FormatoDGVListaVentas();
            txtVentaTotal.Text = "Total Venta: $"+0;
            timer1.Enabled = true;
        }

        public void ObtenerProducto(string codigo)
        {
            metodosProductos = new MetodosProductos();
            producto = metodosProductos.BuscarProductoVenta(codigo);

            if (producto == null)
            {
                MessageBox.Show("No existe el Producto");
            } else { 
            productosVenta = new Venta(producto, 1, Convert.ToDouble(producto.precio));

                if (listaVenta.Count() == 0)
                {
                    listaVenta.Add(productosVenta);
                    listaVenta.ElementAt(0).producto.stock = "" + (Convert.ToInt32(listaVenta.ElementAt(0).producto.stock) - 1);
                    LlenarDGV(listaVenta);   
                } else
                {
                    if(RegistradoLista(codigo, listaVenta))
                    {
                        for (int i = 0; i < listaVenta.Count(); i++)
                        {
                            if (listaVenta.ElementAt(i).producto.idProducto.Equals(codigo))
                            {
                                if (Convert.ToInt32(listaVenta.ElementAt(i).producto.stock) == 0)
                                {
                                    MessageBox.Show("Ya no hay stock");
                                }
                                else
                                {
                                    listaVenta.ElementAt(i).producto.stock = "" + (Convert.ToInt32(listaVenta.ElementAt(i).producto.stock) - 1);
                                    listaVenta.ElementAt(i).cantidad = listaVenta.ElementAt(i).cantidad + 1;
                                    listaVenta.ElementAt(i).costo = listaVenta.ElementAt(i).costo + Convert.ToDouble(listaVenta.ElementAt(i).producto.precio);
                                    DGVListaVentas.Refresh();
                                    LlenarDGV(listaVenta);
                                    i = listaVenta.Count();
                                }
                            }
                        }
                    } else
                    {
                        listaVenta.Add(productosVenta);
                        listaVenta.ElementAt(listaVenta.Count()-1).producto.stock = "" + (Convert.ToInt32(listaVenta.ElementAt(listaVenta.Count()-1).producto.stock) - 1);
                        LlenarDGV(listaVenta);
                    }
                }
            }

            ObtenerTotal(listaVenta);
        }

        public void ObtenerTotal(List<Venta> listaVenta)
        {
            double total = 0.0;
            for (int i = 0; i < listaVenta.Count(); i++)
            {
                total = total + listaVenta.ElementAt(i).costo;
            }

            txtVentaTotal.Text = "Total Venta: $"+total;
        }

        public Boolean RegistradoLista(string codigo, List<Venta> listaVenta)
        {
            Boolean existe = false;
            for (int i = 0; i < listaVenta.Count(); i++)
            {
                if (listaVenta.ElementAt(i).producto.idProducto.Equals(codigo))
                {
                    existe = true;
                    i = listaVenta.Count();
                }
            }

            return existe;
        }

        public void LlenarDGV(List<Venta> listaVenta)
        {
            DGVListaVentas.Rows.Clear();
            for (int i = 0; i < listaVenta.Count(); i++)
            {
                DGVListaVentas.Rows.Add(
                listaVenta.ElementAt(i).producto.idProducto,
                listaVenta.ElementAt(i).producto.nomProducto,
                listaVenta.ElementAt(i).producto.stock,
                listaVenta.ElementAt(i).producto.precio,
                listaVenta.ElementAt(i).producto.descripcion,
                listaVenta.ElementAt(i).cantidad,
                listaVenta.ElementAt(i).costo
                );
            }
        }

        public void FormatoDGVListaVentas()
        {
            DGVListaVentas.Columns.Clear();
            DGVListaVentas.Columns.Add("idProducto", "ID");
            DGVListaVentas.Columns.Add("producto", "PRODUCTO");
            DGVListaVentas.Columns.Add("stock", "STOCK");
            DGVListaVentas.Columns.Add("precio", "PRECIO");
            DGVListaVentas.Columns.Add("descripcion", "DESCRIPCION");
            DGVListaVentas.Columns.Add("cantidad", "CANTIDAD");
            DGVListaVentas.Columns.Add("costo", "COSTO");
            
            DGVListaVentas.Columns["idProducto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["producto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["stock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListaVentas.Columns["costo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        protected void TBCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Contains("\n"))
            {
                ObtenerProducto(tbCodigo.Text.Trim());
                tbCodigo.Text = "";
                
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVListaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                
            }
            else
            {
                txtIdProducto.Text = DGVListaVentas.Rows[e.RowIndex].Cells["idProducto"].Value.ToString().Trim();
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Equals("Selecciona un producto"))
            {
                MessageBox.Show("SELECCIONA UN PRODUCTO DE LA LISTA");
            } else
            {
                for (int i = 0; i < listaVenta.Count; i++)
                {
                    if (listaVenta.ElementAt(i).producto.idProducto.Equals(txtIdProducto.Text.Trim()))
                    {
                        if (Convert.ToInt32(listaVenta.ElementAt(i).producto.stock) == 0)
                        {
                            MessageBox.Show("Ya no hay stock");
                        }
                        else
                        {
                            listaVenta.ElementAt(i).producto.stock = "" + (Convert.ToInt32(listaVenta.ElementAt(i).producto.stock) - 1);
                            listaVenta.ElementAt(i).cantidad = listaVenta.ElementAt(i).cantidad + 1;
                            listaVenta.ElementAt(i).costo = listaVenta.ElementAt(i).costo + Convert.ToDouble(listaVenta.ElementAt(i).producto.precio);
                            DGVListaVentas.Refresh();
                            LlenarDGV(listaVenta);
                            i = listaVenta.Count();
                        }
                    }
                }

                ObtenerTotal(listaVenta);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Equals("Selecciona un producto"))
            {
                MessageBox.Show("SELECCIONA UN PRODUCTO DE LA LISTA");
            }
            else
            {
                for (int i = 0; i < listaVenta.Count; i++)
                {
                    if (listaVenta.ElementAt(i).producto.idProducto.Equals(txtIdProducto.Text.Trim()))
                    {
                        if (Convert.ToInt32(listaVenta.ElementAt(i).cantidad) == 0)
                        {
                            MessageBox.Show("Se eliminara el producto de la lista");
                            txtIdProducto.Text = "Selecciona un producto";
                            listaVenta.RemoveAt(i);
                            DGVListaVentas.Refresh();
                            LlenarDGV(listaVenta);
                        }
                        else
                        {
                            listaVenta.ElementAt(i).producto.stock = "" + (Convert.ToInt32(listaVenta.ElementAt(i).producto.stock) + 1);
                            listaVenta.ElementAt(i).cantidad = listaVenta.ElementAt(i).cantidad - 1;
                            listaVenta.ElementAt(i).costo = listaVenta.ElementAt(i).costo - Convert.ToDouble(listaVenta.ElementAt(i).producto.precio);
                            DGVListaVentas.Refresh();
                            LlenarDGV(listaVenta);
                            i = listaVenta.Count();
                        }
                    }
                }

                ObtenerTotal(listaVenta);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Equals("Selecciona un producto"))
            {
                MessageBox.Show("SELECCIONA UN PRODUCTO DE LA LISTA");
            }
            else
            {
                for (int i = 0; i < listaVenta.Count; i++)
                {
                    if (listaVenta.ElementAt(i).producto.idProducto.Equals(txtIdProducto.Text.Trim()))
                    {
                        MessageBox.Show("Se eliminara el producto de la lista");
                        txtIdProducto.Text = "Selecciona un producto";
                        listaVenta.RemoveAt(i);
                        DGVListaVentas.Refresh();
                        LlenarDGV(listaVenta);
                        i = listaVenta.Count();
                    }
                }
                ObtenerTotal(listaVenta);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaVenta.Clear();
            DGVListaVentas.Rows.Clear();
            ObtenerTotal(listaVenta);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            fecha = DateTime.Now.ToString();
            string[] cadena = txtVentaTotal.Text.Split('$');
            double ventaTotal = Convert.ToDouble(cadena[1]);
            string resultado = "";

            if (ventaTotal == 0)
            {
                MessageBox.Show("No puedes registrar ventas en cero");
            } else
            {
                metodosVentas = new MetodosVentas();
                metodosVentas.ActualizaStock(listaVenta);
                resultado = metodosVentas.AgregarVenta(Convert.ToDateTime(fecha), Convert.ToDateTime(fecha), idUsuario, listaVenta, ventaTotal);
                btnLimpiar_Click(sender, e);
                tbCodigo.Focus();
            }

            MessageBox.Show(resultado);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
