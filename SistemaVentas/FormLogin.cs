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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario;
                MetodosUsuarios metodosUsuarios = new MetodosUsuarios();
                usuario = metodosUsuarios.LoginUsuario(tbUsuario.Text.Trim(), tbContrasena.Text.Trim());

                if (usuario.idUsuario == 0)
                {
                    MessageBox.Show("No se puede acceder, revisa que los datos sean correctos.");
                } else
                {
                    if (usuario.idEstado == 1)
                    {
                        MessageBox.Show("Esta cuenta esta inactiva, contacta al administrador del sistema");
                    } else
                    {
                        MDIPrincipal mdiPrincipal = new MDIPrincipal();
                        mdiPrincipal.idUsuario = usuario.idUsuario;
                        mdiPrincipal.nomUsuario = usuario.nomUsuario;
                        mdiPrincipal.idEstado = usuario.idEstado;
                        mdiPrincipal.idPermiso = usuario.idPermiso;
                        mdiPrincipal.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
