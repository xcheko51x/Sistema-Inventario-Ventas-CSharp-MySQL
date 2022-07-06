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

namespace SistemaVentas
{
    public partial class FormUsuarios : Form
    {
        MetodosUsuarios metodosUsuarios;
        DataTable datos;
        int idUsuario = 0;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.MostrarUsuarios();
            this.MostrarPermisos(cbPermisos);
            this.MostrarPermisos(cbActPermisos);
            this.MostrarEstados(cbEstados);
            this.MostrarEstados(cbActEstados);
        }

        private void MostrarPermisos(ComboBox cbPermisos)
        {
            List<Permiso> datos = metodosUsuarios.ObtenerPermisos();
            cbPermisos.Items.Add("Selecciona una opción");
            foreach (Permiso dato in datos)
            {
                cbPermisos.Items.Add(dato.permiso);
            }
            cbPermisos.SelectedIndex = 0;
        }

        private void MostrarEstados(ComboBox cbEstados)
        {
            List<Estado> datos = metodosUsuarios.ObtenerEstados();
            cbEstados.Items.Add("Selecciona una opción");
            foreach (Estado dato in datos)
            {
                cbEstados.Items.Add(dato.estado+1 + "- " + dato.descripcion);
            }
            cbEstados.SelectedIndex = 0;
        }

        public void MostrarUsuarios()
        {
            metodosUsuarios = new MetodosUsuarios();
            datos = metodosUsuarios.ObtenerUsuarios();
            FormatoTablaUsuarios(datos);
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomUsuario = tbNombre.Text;
            string usuario = tbUsuario.Text;
            string contrasena = tbContrasena.Text;
            int idPermiso = cbPermisos.SelectedIndex;
            int idEstado = cbEstados.SelectedIndex;

            Usuario nuevoUsuario = new Usuario(nomUsuario, usuario, contrasena, idPermiso, idEstado);

            string resultado = metodosUsuarios.ValidarUsuario(nuevoUsuario);
            if (resultado.Equals("OK"))
            {
                resultado = metodosUsuarios.AgregarUsuario(nuevoUsuario);
            } 

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
            nuevoUsuario = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nomUsuario = tbActNombre.Text;
            string usuario = tbActUsuario.Text;
            string contrasena = tbActContrasena.Text;
            int idPermiso = cbActPermisos.SelectedIndex;
            int idEstado = cbActEstados.SelectedIndex;

            Usuario actualizarUsuario = new Usuario(nomUsuario, usuario, contrasena, idPermiso, idEstado);

            string resultado = metodosUsuarios.ValidarUsuario(actualizarUsuario);
            if (resultado.Equals("OK"))
            {
                resultado = metodosUsuarios.ActualizarUsuario(idUsuario, actualizarUsuario);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
            actualizarUsuario = null;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

            this.datos.Reset();
            metodosUsuarios = new MetodosUsuarios();
            datos = metodosUsuarios.BuscarUsuario(tbBuscarUsuario.Text.Trim());
            FormatoTablaUsuarios(datos);
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            idUsuario = 0;

            tbNombre.Text = "";
            tbUsuario.Text = "";
            tbContrasena.Text = "";
            tbBuscarUsuario.Text = "";
            cbPermisos.SelectedIndex = 0;
            cbEstados.SelectedIndex = 0;

            tbActNombre.Text = "";
            tbActUsuario.Text = "";
            tbActContrasena.Text = "";
            cbActPermisos.SelectedIndex = 0;
            cbActEstados.SelectedIndex = 0;
        }

        public void FormatoTablaUsuarios(DataTable datos)
        {
            try
            {
                datos.Columns["idUsuario"].ColumnName = "ID";
                datos.Columns["nomUsuario"].ColumnName = "NOMBRE";
                datos.Columns["usuario"].ColumnName = "USUARIO";
                datos.Columns["contrasena"].ColumnName = "CONTRASEÑA";
                datos.Columns["idPermiso"].ColumnName = "PERMISO";
                datos.Columns["idEstado"].ColumnName = "ESTADO";

                DGVUsuarios.DataSource = datos;
                DGVUsuarios.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["NOMBRE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["USUARIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["CONTRASEÑA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["PERMISO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                txtTotalUsuarios.Text = "Total de usuarios: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            } else
            {
                idUsuario = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                tbActNombre.Text = DGVUsuarios.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString().Trim();
                tbActUsuario.Text = DGVUsuarios.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString().Trim();
                tbActContrasena.Text = DGVUsuarios.Rows[e.RowIndex].Cells["CONTRASEÑA"].Value.ToString().Trim();
                cbActPermisos.SelectedIndex = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells["PERMISO"].Value.ToString().Trim());
                cbActEstados.SelectedIndex = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString().Trim());
            }
        }
    }
}
