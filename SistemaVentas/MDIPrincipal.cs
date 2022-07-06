using SistemaVentas.Vistas;
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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public int idUsuario;
        public string nomUsuario;
        public int idEstado;
        public int idPermiso;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            sslUsuario.Text = "Desarrollado por: xcheko51x || " + "ID Usuario: "+ idUsuario + " || Usuario: " + nomUsuario;
            MessageBox.Show("Bienvenido: " + this.nomUsuario, "SIV", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.idPermiso == 1)
            {
                menuUsuarios.Enabled = true;
                menuProveedores.Enabled = true;
                menuProductos.Enabled = true;
                menuVentas.Enabled = true;
                menuReportes.Enabled = true;
                menuLogout.Enabled = true;
                menuSalir.Enabled = true;
            } else if (this.idPermiso == 2)
            {
                menuUsuarios.Enabled = false;
                menuProveedores.Enabled = true;
                menuProductos.Enabled = true;
                menuVentas.Enabled = false;
                menuReportes.Enabled = false;
                menuLogout.Enabled = true;
                menuSalir.Enabled = true;
            } else if (this.idPermiso == 3)
            {
                menuUsuarios.Enabled = false;
                menuProveedores.Enabled = false;
                menuProductos.Enabled = false;
                menuVentas.Enabled = true;
                menuReportes.Enabled = true;
                menuLogout.Enabled = true;
                menuSalir.Enabled = true;
            } else
            {
                menuUsuarios.Enabled = false;
                menuProveedores.Enabled = false;
                menuProductos.Enabled = false;
                menuVentas.Enabled = false;
                menuReportes.Enabled = false;
                menuLogout.Enabled = false;
                menuSalir.Enabled = true;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.idUsuario = idUsuario;
            formVentas.Show();
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();
            formReportes.MdiParent = this;
            formReportes.Show();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Deseas cerrar sesión?", "SIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                this.Dispose();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Deseas salir del SIV?", "SIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
