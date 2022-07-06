
namespace SistemaVentas
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuProveedores,
            this.menuProductos,
            this.menuVentas,
            this.menuReportes,
            this.menuLogout,
            this.menuSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(84, 20);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(73, 20);
            this.menuProductos.Text = "Productos";
            this.menuProductos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(53, 20);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(88, 20);
            this.menuLogout.Text = "Cerrar Sesión";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(41, 20);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // sslUsuario
            // 
            this.sslUsuario.Name = "sslUsuario";
            this.sslUsuario.Size = new System.Drawing.Size(63, 17);
            this.sslUsuario.Text = "xcheko51x";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "SIV - Sistema Inventarios y Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripStatusLabel sslUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
    }
}



