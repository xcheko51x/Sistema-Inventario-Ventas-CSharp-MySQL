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

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.mostrarUsuarios();
            this.mostrarPermisos(cbPermisos);
            this.mostrarPermisos(cbActPermisos);
            this.mostrarEstados(cbEstados);
            this.mostrarEstados(cbActEstados);
        }

        private void mostrarPermisos(ComboBox cbPermisos)
        {
            List<Permiso> datos = metodosUsuarios.ObtenerPermisos();
            cbPermisos.Items.Add("Selecciona una opción");
            foreach (Permiso dato in datos)
            {
                cbPermisos.Items.Add(dato.toString());
            }
            cbPermisos.SelectedIndex = 0;
        }

        private void mostrarEstados(ComboBox cbEstados)
        {
            List<Estado> datos = metodosUsuarios.ObtenerEstados();
            cbEstados.Items.Add("Selecciona una opción");
            foreach (Estado dato in datos)
            {
                cbEstados.Items.Add(dato.toString());
            }
            cbEstados.SelectedIndex = 0;
        }

        private void mostrarUsuarios()
        {
            metodosUsuarios = new MetodosUsuarios();
            datos = metodosUsuarios.ObtenerUsuarios();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            this.mostrarUsuarios();
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
                MessageBox.Show("SE INSERTO CORRECTAMENTE");
                limpiarCampos();
                this.datos.Reset();
                this.mostrarUsuarios();

            } else
            {
                MessageBox.Show("NO SE PUDO INSERTAR EL REGISTRO");
            }

        }
        
        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbUsuario.Text = "";
            tbContrasena.Text = "";
            cbPermisos.SelectedIndex = 0;
            cbActEstados.SelectedIndex = 0;

        }
    }
}
