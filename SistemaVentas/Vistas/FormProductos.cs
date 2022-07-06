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
    public partial class FormProductos : Form
    {
        MetodosProductos metodosProductos;
        DataTable datos;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.MostrarProveedores(cbProveedores);
            this.MostrarProveedores(cbActProveedores);
        }

        public void MostrarProductos()
        {
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.ObtenerProductos();
            FormatoTablaProductos(datos);
        }

        public void FormatoTablaProductos(DataTable datos)
        {
            try
            {
                datos.Columns["idProducto"].ColumnName = "ID";
                datos.Columns["nomProducto"].ColumnName = "PRODUCTO";
                datos.Columns["idProveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["nomProveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["descripcion"].ColumnName = "DESCRIPCION";
                datos.Columns["stock"].ColumnName = "STOCK";
                datos.Columns["precio"].ColumnName = "PRECIO";

                DGVProductos.DataSource = datos;
                DGVProductos.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["DESCRIPCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["STOCK"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRECIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                txtTotalProductos.Text = "Total de productos: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarProveedores(ComboBox cbProveedores)
        {
            List<Proveedor> datos = metodosProductos.ObtenerProveedores();
            cbProveedores.Items.Add("Selecciona una opción");
            foreach (Proveedor dato in datos)
            {
                cbProveedores.Items.Add(dato.idProveedor+","+dato.nomProveedor);
            }
            cbProveedores.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProducto = tbIdProducto.Text.Trim();
            string nomProducto = tbNomProducto.Text.Trim();
            string stock = tbStock.Text.Trim();
            string precio = tbPrecio.Text.Trim();
            string descripcion = tbDescripcion.Text.Trim();

            string cadena = cbProveedores.SelectedItem.ToString();

            if (cbProveedores.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            } else
            {
                string[] valores = cadena.Split(',');
                string idProveedor = valores[0].Trim();

                Producto nuevoProducto = new Producto(idProducto, nomProducto, stock, precio, descripcion, idProveedor);

                string resultado = metodosProductos.ValidarProducto(nuevoProducto);

                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.AgregarProducto(nuevoProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                nuevoProducto = null;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = tbActIdProducto.Text.Trim();
            string nomProducto = tbActNomProducto.Text.Trim();
            string stock = tbActStock.Text.Trim();
            string precio = tbActPrecio.Text.Trim();
            string descripcion = tbActDescripcion.Text.Trim();
            string cadena = cbActProveedores.SelectedItem.ToString();

            if (cbActProveedores.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valores = cadena.Split(',');
                string idProveedor = valores[0].Trim();

                Producto actualizarProducto = new Producto(idProducto, nomProducto, stock, precio, descripcion, idProveedor);
                string resultado = metodosProductos.ValidarProducto(actualizarProducto);
                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.ActualizarProducto(actualizarProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                actualizarProducto = null;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.BuscarProducto(tbBuscarProducto.Text.Trim());
            FormatoTablaProductos(datos);
            LimpiarCampos();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            tbIdProducto.Text = "";
            tbNomProducto.Text = "";
            tbStock.Text = "";
            tbPrecio.Text = "";
            tbDescripcion.Text = "";
            cbProveedores.SelectedIndex = 0;
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

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                tbActIdProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();
                tbActNomProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString().Trim();
                tbActStock.Text = DGVProductos.Rows[e.RowIndex].Cells["STOCK"].Value.ToString().Trim();
                tbActPrecio.Text = DGVProductos.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString().Trim();
                tbActDescripcion.Text = DGVProductos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString().Trim();
                cbActProveedores.SelectedIndex = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells["ID PROVEEDOR"].Value.ToString().Trim());
                
            }
        }
    }
}
