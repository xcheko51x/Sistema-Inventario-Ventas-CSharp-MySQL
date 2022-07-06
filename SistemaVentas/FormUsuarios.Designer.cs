
namespace SistemaVentas
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.txtTotalUsuarios = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.gbAddUsuario = new System.Windows.Forms.GroupBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.txtEstados = new System.Windows.Forms.Label();
            this.cbPermisos = new System.Windows.Forms.ComboBox();
            this.txtPermisos = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.Label();
            this.tbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.gbActUsuario = new System.Windows.Forms.GroupBox();
            this.tbActContrasena = new System.Windows.Forms.TextBox();
            this.tbActUsuario = new System.Windows.Forms.TextBox();
            this.tbActNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbActEstados = new System.Windows.Forms.ComboBox();
            this.txtActEstado = new System.Windows.Forms.Label();
            this.cbActPermisos = new System.Windows.Forms.ComboBox();
            this.txtActPermiso = new System.Windows.Forms.Label();
            this.txtActNombre = new System.Windows.Forms.Label();
            this.txtActContrasena = new System.Windows.Forms.Label();
            this.txtActUsuario = new System.Windows.Forms.Label();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.gbAddUsuario.SuspendLayout();
            this.gbBuscarUsuario.SuspendLayout();
            this.gbActUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.AllowUserToDeleteRows = false;
            this.DGVUsuarios.AllowUserToOrderColumns = true;
            this.DGVUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 279);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.Size = new System.Drawing.Size(1066, 286);
            this.DGVUsuarios.TabIndex = 0;
            // 
            // txtTotalUsuarios
            // 
            this.txtTotalUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUsuarios.Location = new System.Drawing.Point(921, 568);
            this.txtTotalUsuarios.Name = "txtTotalUsuarios";
            this.txtTotalUsuarios.Size = new System.Drawing.Size(157, 23);
            this.txtTotalUsuarios.TabIndex = 1;
            this.txtTotalUsuarios.Text = "label1";
            this.txtTotalUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(6, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(57, 13);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "NOMBRE:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(6, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(59, 13);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Location = new System.Drawing.Point(6, 79);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(84, 13);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.Text = "CONTRASEÑA:";
            this.txtContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAddUsuario
            // 
            this.gbAddUsuario.Controls.Add(this.tbContrasena);
            this.gbAddUsuario.Controls.Add(this.tbUsuario);
            this.gbAddUsuario.Controls.Add(this.tbNombre);
            this.gbAddUsuario.Controls.Add(this.btnAgregar);
            this.gbAddUsuario.Controls.Add(this.cbEstados);
            this.gbAddUsuario.Controls.Add(this.txtEstados);
            this.gbAddUsuario.Controls.Add(this.cbPermisos);
            this.gbAddUsuario.Controls.Add(this.txtPermisos);
            this.gbAddUsuario.Controls.Add(this.txtNombre);
            this.gbAddUsuario.Controls.Add(this.txtContrasena);
            this.gbAddUsuario.Controls.Add(this.txtUsuario);
            this.gbAddUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbAddUsuario.Name = "gbAddUsuario";
            this.gbAddUsuario.Size = new System.Drawing.Size(335, 214);
            this.gbAddUsuario.TabIndex = 5;
            this.gbAddUsuario.TabStop = false;
            this.gbAddUsuario.Text = "AGREGAR USUARIO";
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(115, 76);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(202, 20);
            this.tbContrasena.TabIndex = 12;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(115, 51);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(202, 20);
            this.tbUsuario.TabIndex = 11;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(115, 24);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(242, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(115, 134);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(202, 21);
            this.cbEstados.TabIndex = 8;
            // 
            // txtEstados
            // 
            this.txtEstados.AutoSize = true;
            this.txtEstados.Location = new System.Drawing.Point(6, 137);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(54, 13);
            this.txtEstados.TabIndex = 7;
            this.txtEstados.Text = "ESTADO:";
            // 
            // cbPermisos
            // 
            this.cbPermisos.FormattingEnabled = true;
            this.cbPermisos.Location = new System.Drawing.Point(115, 104);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(202, 21);
            this.cbPermisos.TabIndex = 6;
            // 
            // txtPermisos
            // 
            this.txtPermisos.AutoSize = true;
            this.txtPermisos.Location = new System.Drawing.Point(6, 107);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(59, 13);
            this.txtPermisos.TabIndex = 5;
            this.txtPermisos.Text = "PERMISO:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarUsuario.AutoSize = true;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(6, 16);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(109, 13);
            this.txtBuscarUsuario.TabIndex = 6;
            this.txtBuscarUsuario.Text = "BUSCAR USUARIO: ";
            // 
            // tbBuscarUsuario
            // 
            this.tbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarUsuario.Location = new System.Drawing.Point(121, 13);
            this.tbBuscarUsuario.Name = "tbBuscarUsuario";
            this.tbBuscarUsuario.Size = new System.Drawing.Size(728, 20);
            this.tbBuscarUsuario.TabIndex = 7;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(855, 11);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 8;
            this.btnBuscarUsuario.Text = "BUSCAR";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarUsuario.Controls.Add(this.btnMostrarUsuarios);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarUsuario);
            this.gbBuscarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gbBuscarUsuario.Controls.Add(this.tbBuscarUsuario);
            this.gbBuscarUsuario.Location = new System.Drawing.Point(12, 232);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(1066, 41);
            this.gbBuscarUsuario.TabIndex = 9;
            this.gbBuscarUsuario.TabStop = false;
            // 
            // gbActUsuario
            // 
            this.gbActUsuario.Controls.Add(this.tbActContrasena);
            this.gbActUsuario.Controls.Add(this.tbActUsuario);
            this.gbActUsuario.Controls.Add(this.tbActNombre);
            this.gbActUsuario.Controls.Add(this.btnActualizar);
            this.gbActUsuario.Controls.Add(this.cbActEstados);
            this.gbActUsuario.Controls.Add(this.txtActEstado);
            this.gbActUsuario.Controls.Add(this.cbActPermisos);
            this.gbActUsuario.Controls.Add(this.txtActPermiso);
            this.gbActUsuario.Controls.Add(this.txtActNombre);
            this.gbActUsuario.Controls.Add(this.txtActContrasena);
            this.gbActUsuario.Controls.Add(this.txtActUsuario);
            this.gbActUsuario.Location = new System.Drawing.Point(353, 12);
            this.gbActUsuario.Name = "gbActUsuario";
            this.gbActUsuario.Size = new System.Drawing.Size(335, 214);
            this.gbActUsuario.TabIndex = 13;
            this.gbActUsuario.TabStop = false;
            this.gbActUsuario.Text = "EDITAR USUARIO";
            // 
            // tbActContrasena
            // 
            this.tbActContrasena.Location = new System.Drawing.Point(115, 76);
            this.tbActContrasena.Name = "tbActContrasena";
            this.tbActContrasena.Size = new System.Drawing.Size(202, 20);
            this.tbActContrasena.TabIndex = 12;
            // 
            // tbActUsuario
            // 
            this.tbActUsuario.Location = new System.Drawing.Point(115, 51);
            this.tbActUsuario.Name = "tbActUsuario";
            this.tbActUsuario.Size = new System.Drawing.Size(202, 20);
            this.tbActUsuario.TabIndex = 11;
            // 
            // tbActNombre
            // 
            this.tbActNombre.Location = new System.Drawing.Point(115, 24);
            this.tbActNombre.Name = "tbActNombre";
            this.tbActNombre.Size = new System.Drawing.Size(202, 20);
            this.tbActNombre.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(224, 185);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbActEstados
            // 
            this.cbActEstados.FormattingEnabled = true;
            this.cbActEstados.Location = new System.Drawing.Point(115, 134);
            this.cbActEstados.Name = "cbActEstados";
            this.cbActEstados.Size = new System.Drawing.Size(202, 21);
            this.cbActEstados.TabIndex = 8;
            // 
            // txtActEstado
            // 
            this.txtActEstado.AutoSize = true;
            this.txtActEstado.Location = new System.Drawing.Point(6, 137);
            this.txtActEstado.Name = "txtActEstado";
            this.txtActEstado.Size = new System.Drawing.Size(54, 13);
            this.txtActEstado.TabIndex = 7;
            this.txtActEstado.Text = "ESTADO:";
            // 
            // cbActPermisos
            // 
            this.cbActPermisos.FormattingEnabled = true;
            this.cbActPermisos.Location = new System.Drawing.Point(115, 104);
            this.cbActPermisos.Name = "cbActPermisos";
            this.cbActPermisos.Size = new System.Drawing.Size(202, 21);
            this.cbActPermisos.TabIndex = 6;
            // 
            // txtActPermiso
            // 
            this.txtActPermiso.AutoSize = true;
            this.txtActPermiso.Location = new System.Drawing.Point(6, 107);
            this.txtActPermiso.Name = "txtActPermiso";
            this.txtActPermiso.Size = new System.Drawing.Size(59, 13);
            this.txtActPermiso.TabIndex = 5;
            this.txtActPermiso.Text = "PERMISO:";
            // 
            // txtActNombre
            // 
            this.txtActNombre.AutoSize = true;
            this.txtActNombre.Location = new System.Drawing.Point(6, 27);
            this.txtActNombre.Name = "txtActNombre";
            this.txtActNombre.Size = new System.Drawing.Size(57, 13);
            this.txtActNombre.TabIndex = 2;
            this.txtActNombre.Text = "NOMBRE:";
            // 
            // txtActContrasena
            // 
            this.txtActContrasena.AutoSize = true;
            this.txtActContrasena.Location = new System.Drawing.Point(6, 79);
            this.txtActContrasena.Name = "txtActContrasena";
            this.txtActContrasena.Size = new System.Drawing.Size(84, 13);
            this.txtActContrasena.TabIndex = 4;
            this.txtActContrasena.Text = "CONTRASEÑA:";
            this.txtActContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActUsuario
            // 
            this.txtActUsuario.AutoSize = true;
            this.txtActUsuario.Location = new System.Drawing.Point(6, 54);
            this.txtActUsuario.Name = "txtActUsuario";
            this.txtActUsuario.Size = new System.Drawing.Size(59, 13);
            this.txtActUsuario.TabIndex = 3;
            this.txtActUsuario.Text = "USUARIO:";
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(936, 12);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarUsuarios.TabIndex = 9;
            this.btnMostrarUsuarios.Text = "MOSTRAR TODOS";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.gbActUsuario);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.gbAddUsuario);
            this.Controls.Add(this.txtTotalUsuarios);
            this.Controls.Add(this.DGVUsuarios);
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.gbAddUsuario.ResumeLayout(false);
            this.gbAddUsuario.PerformLayout();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            this.gbActUsuario.ResumeLayout(false);
            this.gbActUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.Label txtTotalUsuarios;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.GroupBox gbAddUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label txtEstados;
        private System.Windows.Forms.ComboBox cbPermisos;
        private System.Windows.Forms.Label txtPermisos;
        private System.Windows.Forms.Label txtBuscarUsuario;
        private System.Windows.Forms.TextBox tbBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.GroupBox gbActUsuario;
        private System.Windows.Forms.TextBox tbActContrasena;
        private System.Windows.Forms.TextBox tbActUsuario;
        private System.Windows.Forms.TextBox tbActNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbActEstados;
        private System.Windows.Forms.Label txtActEstado;
        private System.Windows.Forms.ComboBox cbActPermisos;
        private System.Windows.Forms.Label txtActPermiso;
        private System.Windows.Forms.Label txtActNombre;
        private System.Windows.Forms.Label txtActContrasena;
        private System.Windows.Forms.Label txtActUsuario;
        private System.Windows.Forms.Button btnMostrarUsuarios;
    }
}