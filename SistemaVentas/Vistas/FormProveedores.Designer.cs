
namespace SistemaVentas.Vistas
{
    partial class FormProveedores
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
            this.gbAddProveedor = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbProveedor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.gbActProveedor = new System.Windows.Forms.GroupBox();
            this.tbActEmail = new System.Windows.Forms.TextBox();
            this.tbActDireccion = new System.Windows.Forms.TextBox();
            this.tbActNumero = new System.Windows.Forms.TextBox();
            this.tbActProveedor = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.btnMostrarProveedores = new System.Windows.Forms.Button();
            this.txtBuscarProveedor = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.tbBuscarProveedor = new System.Windows.Forms.TextBox();
            this.DGVProveedores = new System.Windows.Forms.DataGridView();
            this.txtTotalProveedores = new System.Windows.Forms.Label();
            this.gbAddProveedor.SuspendLayout();
            this.gbActProveedor.SuspendLayout();
            this.gbBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddProveedor
            // 
            this.gbAddProveedor.Controls.Add(this.tbEmail);
            this.gbAddProveedor.Controls.Add(this.tbDireccion);
            this.gbAddProveedor.Controls.Add(this.tbNumero);
            this.gbAddProveedor.Controls.Add(this.tbProveedor);
            this.gbAddProveedor.Controls.Add(this.btnAgregar);
            this.gbAddProveedor.Controls.Add(this.txtEmail);
            this.gbAddProveedor.Controls.Add(this.txtProveedor);
            this.gbAddProveedor.Controls.Add(this.txtDireccion);
            this.gbAddProveedor.Controls.Add(this.txtNumero);
            this.gbAddProveedor.Location = new System.Drawing.Point(12, 12);
            this.gbAddProveedor.Name = "gbAddProveedor";
            this.gbAddProveedor.Size = new System.Drawing.Size(335, 214);
            this.gbAddProveedor.TabIndex = 6;
            this.gbAddProveedor.TabStop = false;
            this.gbAddProveedor.Text = "AGREGAR PROVEEDOR";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(115, 159);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(202, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(115, 76);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(202, 77);
            this.tbDireccion.TabIndex = 12;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(115, 51);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(202, 20);
            this.tbNumero.TabIndex = 11;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbProveedor
            // 
            this.tbProveedor.Location = new System.Drawing.Point(115, 24);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Size = new System.Drawing.Size(202, 20);
            this.tbProveedor.TabIndex = 10;
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
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(6, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 13);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "EMAIL:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.AutoSize = true;
            this.txtProveedor.Location = new System.Drawing.Point(6, 27);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(78, 13);
            this.txtProveedor.TabIndex = 2;
            this.txtProveedor.Text = "PROVEEDOR:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.Location = new System.Drawing.Point(6, 79);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(69, 13);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "DIRECCIÓN:";
            this.txtDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumero
            // 
            this.txtNumero.AutoSize = true;
            this.txtNumero.Location = new System.Drawing.Point(6, 54);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(67, 13);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Text = "TELÉFONO:";
            // 
            // gbActProveedor
            // 
            this.gbActProveedor.Controls.Add(this.tbActEmail);
            this.gbActProveedor.Controls.Add(this.tbActDireccion);
            this.gbActProveedor.Controls.Add(this.tbActNumero);
            this.gbActProveedor.Controls.Add(this.tbActProveedor);
            this.gbActProveedor.Controls.Add(this.btnActualizar);
            this.gbActProveedor.Controls.Add(this.label1);
            this.gbActProveedor.Controls.Add(this.label2);
            this.gbActProveedor.Controls.Add(this.label3);
            this.gbActProveedor.Controls.Add(this.label4);
            this.gbActProveedor.Location = new System.Drawing.Point(12, 232);
            this.gbActProveedor.Name = "gbActProveedor";
            this.gbActProveedor.Size = new System.Drawing.Size(335, 214);
            this.gbActProveedor.TabIndex = 14;
            this.gbActProveedor.TabStop = false;
            this.gbActProveedor.Text = "EDITAR PROVEEDOR";
            // 
            // tbActEmail
            // 
            this.tbActEmail.Location = new System.Drawing.Point(115, 159);
            this.tbActEmail.Name = "tbActEmail";
            this.tbActEmail.Size = new System.Drawing.Size(202, 20);
            this.tbActEmail.TabIndex = 13;
            // 
            // tbActDireccion
            // 
            this.tbActDireccion.Location = new System.Drawing.Point(115, 76);
            this.tbActDireccion.Multiline = true;
            this.tbActDireccion.Name = "tbActDireccion";
            this.tbActDireccion.Size = new System.Drawing.Size(202, 77);
            this.tbActDireccion.TabIndex = 12;
            // 
            // tbActNumero
            // 
            this.tbActNumero.Location = new System.Drawing.Point(115, 51);
            this.tbActNumero.Name = "tbActNumero";
            this.tbActNumero.Size = new System.Drawing.Size(202, 20);
            this.tbActNumero.TabIndex = 11;
            this.tbActNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbActProveedor
            // 
            this.tbActProveedor.Location = new System.Drawing.Point(115, 24);
            this.tbActProveedor.Name = "tbActProveedor";
            this.tbActProveedor.Size = new System.Drawing.Size(202, 20);
            this.tbActProveedor.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(231, 185);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMAIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROVEEDOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCIÓN:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELÉFONO:";
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarUsuario.Controls.Add(this.btnMostrarProveedores);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarProveedor);
            this.gbBuscarUsuario.Controls.Add(this.btnBuscarProveedor);
            this.gbBuscarUsuario.Controls.Add(this.tbBuscarProveedor);
            this.gbBuscarUsuario.Location = new System.Drawing.Point(353, 12);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(725, 41);
            this.gbBuscarUsuario.TabIndex = 15;
            this.gbBuscarUsuario.TabStop = false;
            // 
            // btnMostrarProveedores
            // 
            this.btnMostrarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarProveedores.Location = new System.Drawing.Point(595, 12);
            this.btnMostrarProveedores.Name = "btnMostrarProveedores";
            this.btnMostrarProveedores.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarProveedores.TabIndex = 9;
            this.btnMostrarProveedores.Text = "MOSTRAR TODOS";
            this.btnMostrarProveedores.UseVisualStyleBackColor = true;
            this.btnMostrarProveedores.Click += new System.EventHandler(this.btnMostrarProveedores_Click);
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarProveedor.AutoSize = true;
            this.txtBuscarProveedor.Location = new System.Drawing.Point(6, 16);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(128, 13);
            this.txtBuscarProveedor.TabIndex = 6;
            this.txtBuscarProveedor.Text = "BUSCAR PROVEEDOR: ";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(514, 11);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 8;
            this.btnBuscarProveedor.Text = "BUSCAR";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // tbBuscarProveedor
            // 
            this.tbBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarProveedor.Location = new System.Drawing.Point(140, 13);
            this.tbBuscarProveedor.Name = "tbBuscarProveedor";
            this.tbBuscarProveedor.Size = new System.Drawing.Size(368, 20);
            this.tbBuscarProveedor.TabIndex = 7;
            // 
            // DGVProveedores
            // 
            this.DGVProveedores.AllowUserToAddRows = false;
            this.DGVProveedores.AllowUserToDeleteRows = false;
            this.DGVProveedores.AllowUserToOrderColumns = true;
            this.DGVProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProveedores.Location = new System.Drawing.Point(353, 59);
            this.DGVProveedores.Name = "DGVProveedores";
            this.DGVProveedores.ReadOnly = true;
            this.DGVProveedores.RowHeadersWidth = 51;
            this.DGVProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProveedores.Size = new System.Drawing.Size(725, 506);
            this.DGVProveedores.TabIndex = 16;
            this.DGVProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProveedores_CellClick);
            // 
            // txtTotalProveedores
            // 
            this.txtTotalProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProveedores.Location = new System.Drawing.Point(921, 568);
            this.txtTotalProveedores.Name = "txtTotalProveedores";
            this.txtTotalProveedores.Size = new System.Drawing.Size(157, 23);
            this.txtTotalProveedores.TabIndex = 17;
            this.txtTotalProveedores.Text = "label1";
            this.txtTotalProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.txtTotalProveedores);
            this.Controls.Add(this.DGVProveedores);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.gbActProveedor);
            this.Controls.Add(this.gbAddProveedor);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.gbAddProveedor.ResumeLayout(false);
            this.gbAddProveedor.PerformLayout();
            this.gbActProveedor.ResumeLayout(false);
            this.gbActProveedor.PerformLayout();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddProveedor;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtProveedor;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.GroupBox gbActProveedor;
        private System.Windows.Forms.TextBox tbActEmail;
        private System.Windows.Forms.TextBox tbActDireccion;
        private System.Windows.Forms.TextBox tbActNumero;
        private System.Windows.Forms.TextBox tbActProveedor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.Button btnMostrarProveedores;
        private System.Windows.Forms.Label txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox tbBuscarProveedor;
        private System.Windows.Forms.DataGridView DGVProveedores;
        private System.Windows.Forms.Label txtTotalProveedores;
    }
}