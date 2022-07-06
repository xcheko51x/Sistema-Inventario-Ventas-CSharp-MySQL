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
    public partial class FormProveedores : Form
    {
        MetodosProveedores metodosProveedores;
        DataTable datos;
        int idProveedor = 0;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }

        public void MostrarProveedores()
        {
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.ObtenerProveedores();
            FormatoTablaProveedores(datos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomProveedor = tbProveedor.Text;
            string numContacto = tbNumero.Text;
            string direccion = tbDireccion.Text;
            string email = tbEmail.Text;

            Proveedor nuevoProveedor = new Proveedor(nomProveedor, numContacto, direccion, email);

            string resultado = metodosProveedores.ValidarProveedor(nuevoProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.AgregarProveedor(nuevoProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            nuevoProveedor = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.BuscarProveedor(tbBuscarProveedor.Text.Trim());
            FormatoTablaProveedores(datos);
            LimpiarCampos();
        }

        private void btnMostrarProveedores_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nomProveedor = tbActProveedor.Text;
            string numContacto = tbActNumero.Text;
            string direccion = tbActDireccion.Text;
            string email = tbActEmail.Text;

            Proveedor actualizarProveedor = new Proveedor(nomProveedor, numContacto, direccion, email);

            string resultado = metodosProveedores.ValidarProveedor(actualizarProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.ActualizarProveedor(idProveedor, actualizarProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            actualizarProveedor = null;
        }

        public void FormatoTablaProveedores(DataTable datos)
        {
            try
            {
                datos.Columns["idProveedor"].ColumnName = "ID";
                datos.Columns["nomProveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["numContacto"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["direccion"].ColumnName = "DIRECCION";
                datos.Columns["email"].ColumnName = "EMAIL";

                DGVProveedores.DataSource = datos;
                DGVProveedores.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["NUMERO CONTACTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["EMAIL"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                txtTotalProveedores.Text = "Total de proveedores: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idProveedor = 0;

            tbProveedor.Text = "";
            tbNumero.Text = "";
            tbDireccion.Text = "";
            tbEmail.Text = "";

            tbActProveedor.Text = "";
            tbActNumero.Text = "";
            tbActDireccion.Text = "";
            tbActEmail.Text = "";

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

        private void DGVProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idProveedor = Convert.ToInt32(DGVProveedores.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                tbActProveedor.Text = DGVProveedores.Rows[e.RowIndex].Cells["PROVEEDOR"].Value.ToString().Trim();
                tbActNumero.Text = DGVProveedores.Rows[e.RowIndex].Cells["NUMERO CONTACTO"].Value.ToString().Trim();
                tbActDireccion.Text = DGVProveedores.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                tbActEmail.Text = DGVProveedores.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString().Trim();
            }
        }

    }
}
