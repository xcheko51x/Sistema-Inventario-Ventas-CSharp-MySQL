
namespace SistemaVentas.Vistas
{
    partial class FormProductos
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
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.txtTotalProductos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.gbAddUsuario = new System.Windows.Forms.GroupBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.idProveedor = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbNomProducto = new System.Windows.Forms.TextBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtNomProducto = new System.Windows.Forms.Label();
            this.gbActProducto = new System.Windows.Forms.GroupBox();
            this.tbActPrecio = new System.Windows.Forms.TextBox();
            this.txtActIdProveedor = new System.Windows.Forms.Label();
            this.tbActDescripcion = new System.Windows.Forms.TextBox();
            this.tbActStock = new System.Windows.Forms.TextBox();
            this.tbActNomProducto = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbActIdProducto = new System.Windows.Forms.TextBox();
            this.cbActProveedores = new System.Windows.Forms.ComboBox();
            this.txtActDescripcion = new System.Windows.Forms.Label();
            this.txtActPrecio = new System.Windows.Forms.Label();
            this.txtActIdProducto = new System.Windows.Forms.Label();
            this.txtActStock = new System.Windows.Forms.Label();
            this.txtActNomProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.gbBuscarUsuario.SuspendLayout();
            this.gbAddUsuario.SuspendLayout();
            this.gbActProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.AllowUserToDeleteRows = false;
            this.DGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(355, 58);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.RowHeadersWidth = 51;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(723, 507);
            this.DGVProductos.TabIndex = 0;
            this.DGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellClick);
            // 
            // txtTotalProductos
            // 
            this.txtTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductos.Location = new System.Drawing.Point(934, 568);
            this.txtTotalProductos.Name = "txtTotalProductos";
            this.txtTotalProductos.Size = new System.Drawing.Size(144, 23);
            this.txtTotalProductos.TabIndex = 18;
            this.txtTotalProductos.Text = "label1";
            this.txtTotalProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(242, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarUsuario.Controls.Add(this.btnMostrarProductos);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarProducto);
            this.gbBuscarUsuario.Controls.Add(this.btnBuscarProducto);
            this.gbBuscarUsuario.Controls.Add(this.tbBuscarProducto);
            this.gbBuscarUsuario.Location = new System.Drawing.Point(355, 11);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(725, 41);
            this.gbBuscarUsuario.TabIndex = 20;
            this.gbBuscarUsuario.TabStop = false;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarProductos.Location = new System.Drawing.Point(595, 12);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarProductos.TabIndex = 9;
            this.btnMostrarProductos.Text = "MOSTRAR TODOS";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarProducto.AutoSize = true;
            this.txtBuscarProducto.Location = new System.Drawing.Point(6, 16);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(121, 13);
            this.txtBuscarProducto.TabIndex = 6;
            this.txtBuscarProducto.Text = "BUSCAR PRODUCTO: ";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(514, 11);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarProducto.Location = new System.Drawing.Point(128, 13);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.Size = new System.Drawing.Size(380, 20);
            this.tbBuscarProducto.TabIndex = 7;
            // 
            // gbAddUsuario
            // 
            this.gbAddUsuario.Controls.Add(this.tbPrecio);
            this.gbAddUsuario.Controls.Add(this.idProveedor);
            this.gbAddUsuario.Controls.Add(this.tbDescripcion);
            this.gbAddUsuario.Controls.Add(this.tbStock);
            this.gbAddUsuario.Controls.Add(this.tbNomProducto);
            this.gbAddUsuario.Controls.Add(this.btnAgregar);
            this.gbAddUsuario.Controls.Add(this.tbIdProducto);
            this.gbAddUsuario.Controls.Add(this.cbProveedores);
            this.gbAddUsuario.Controls.Add(this.txtDescripcion);
            this.gbAddUsuario.Controls.Add(this.txtPrecio);
            this.gbAddUsuario.Controls.Add(this.txtIdProducto);
            this.gbAddUsuario.Controls.Add(this.txtStock);
            this.gbAddUsuario.Controls.Add(this.txtNomProducto);
            this.gbAddUsuario.Location = new System.Drawing.Point(10, 11);
            this.gbAddUsuario.Name = "gbAddUsuario";
            this.gbAddUsuario.Size = new System.Drawing.Size(335, 271);
            this.gbAddUsuario.TabIndex = 21;
            this.gbAddUsuario.TabStop = false;
            this.gbAddUsuario.Text = "AGREGAR PRODUCTO";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(115, 101);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(202, 20);
            this.tbPrecio.TabIndex = 22;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSize = true;
            this.idProveedor.Location = new System.Drawing.Point(6, 214);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(92, 13);
            this.idProveedor.TabIndex = 21;
            this.idProveedor.Text = "ID PROVEEDOR:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(115, 129);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(202, 77);
            this.tbDescripcion.TabIndex = 20;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(115, 76);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(202, 20);
            this.tbStock.TabIndex = 12;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbNomProducto
            // 
            this.tbNomProducto.Location = new System.Drawing.Point(115, 51);
            this.tbNomProducto.Name = "tbNomProducto";
            this.tbNomProducto.Size = new System.Drawing.Size(202, 20);
            this.tbNomProducto.TabIndex = 11;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(115, 24);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(202, 20);
            this.tbIdProducto.TabIndex = 10;
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(115, 212);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(202, 21);
            this.cbProveedores.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 132);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(83, 13);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "DESCRIPCION:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(6, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(50, 13);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "PRECIO:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.AutoSize = true;
            this.txtIdProducto.Location = new System.Drawing.Point(6, 27);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(21, 13);
            this.txtIdProducto.TabIndex = 2;
            this.txtIdProducto.Text = "ID:";
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Location = new System.Drawing.Point(6, 79);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(46, 13);
            this.txtStock.TabIndex = 4;
            this.txtStock.Text = "STOCK:";
            this.txtStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.AutoSize = true;
            this.txtNomProducto.Location = new System.Drawing.Point(6, 54);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(71, 13);
            this.txtNomProducto.TabIndex = 3;
            this.txtNomProducto.Text = "PRODUCTO:";
            // 
            // gbActProducto
            // 
            this.gbActProducto.Controls.Add(this.tbActPrecio);
            this.gbActProducto.Controls.Add(this.txtActIdProveedor);
            this.gbActProducto.Controls.Add(this.tbActDescripcion);
            this.gbActProducto.Controls.Add(this.tbActStock);
            this.gbActProducto.Controls.Add(this.tbActNomProducto);
            this.gbActProducto.Controls.Add(this.btnActualizar);
            this.gbActProducto.Controls.Add(this.tbActIdProducto);
            this.gbActProducto.Controls.Add(this.cbActProveedores);
            this.gbActProducto.Controls.Add(this.txtActDescripcion);
            this.gbActProducto.Controls.Add(this.txtActPrecio);
            this.gbActProducto.Controls.Add(this.txtActIdProducto);
            this.gbActProducto.Controls.Add(this.txtActStock);
            this.gbActProducto.Controls.Add(this.txtActNomProducto);
            this.gbActProducto.Location = new System.Drawing.Point(10, 288);
            this.gbActProducto.Name = "gbActProducto";
            this.gbActProducto.Size = new System.Drawing.Size(335, 277);
            this.gbActProducto.TabIndex = 23;
            this.gbActProducto.TabStop = false;
            this.gbActProducto.Text = "EDITAR PRODUCTO";
            // 
            // tbActPrecio
            // 
            this.tbActPrecio.Location = new System.Drawing.Point(115, 101);
            this.tbActPrecio.Name = "tbActPrecio";
            this.tbActPrecio.Size = new System.Drawing.Size(202, 20);
            this.tbActPrecio.TabIndex = 22;
            this.tbActPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // txtActIdProveedor
            // 
            this.txtActIdProveedor.AutoSize = true;
            this.txtActIdProveedor.Location = new System.Drawing.Point(6, 214);
            this.txtActIdProveedor.Name = "txtActIdProveedor";
            this.txtActIdProveedor.Size = new System.Drawing.Size(92, 13);
            this.txtActIdProveedor.TabIndex = 21;
            this.txtActIdProveedor.Text = "ID PROVEEDOR:";
            // 
            // tbActDescripcion
            // 
            this.tbActDescripcion.Location = new System.Drawing.Point(115, 129);
            this.tbActDescripcion.Multiline = true;
            this.tbActDescripcion.Name = "tbActDescripcion";
            this.tbActDescripcion.Size = new System.Drawing.Size(202, 77);
            this.tbActDescripcion.TabIndex = 20;
            // 
            // tbActStock
            // 
            this.tbActStock.Location = new System.Drawing.Point(115, 76);
            this.tbActStock.Name = "tbActStock";
            this.tbActStock.Size = new System.Drawing.Size(202, 20);
            this.tbActStock.TabIndex = 12;
            this.tbActStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbActNomProducto
            // 
            this.tbActNomProducto.Location = new System.Drawing.Point(115, 51);
            this.tbActNomProducto.Name = "tbActNomProducto";
            this.tbActNomProducto.Size = new System.Drawing.Size(202, 20);
            this.tbActNomProducto.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(221, 248);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tbActIdProducto
            // 
            this.tbActIdProducto.Enabled = false;
            this.tbActIdProducto.Location = new System.Drawing.Point(115, 24);
            this.tbActIdProducto.Name = "tbActIdProducto";
            this.tbActIdProducto.Size = new System.Drawing.Size(202, 20);
            this.tbActIdProducto.TabIndex = 10;
            // 
            // cbActProveedores
            // 
            this.cbActProveedores.FormattingEnabled = true;
            this.cbActProveedores.Location = new System.Drawing.Point(115, 212);
            this.cbActProveedores.Name = "cbActProveedores";
            this.cbActProveedores.Size = new System.Drawing.Size(202, 21);
            this.cbActProveedores.TabIndex = 8;
            // 
            // txtActDescripcion
            // 
            this.txtActDescripcion.AutoSize = true;
            this.txtActDescripcion.Location = new System.Drawing.Point(6, 132);
            this.txtActDescripcion.Name = "txtActDescripcion";
            this.txtActDescripcion.Size = new System.Drawing.Size(83, 13);
            this.txtActDescripcion.TabIndex = 7;
            this.txtActDescripcion.Text = "DESCRIPCION:";
            // 
            // txtActPrecio
            // 
            this.txtActPrecio.AutoSize = true;
            this.txtActPrecio.Location = new System.Drawing.Point(6, 107);
            this.txtActPrecio.Name = "txtActPrecio";
            this.txtActPrecio.Size = new System.Drawing.Size(50, 13);
            this.txtActPrecio.TabIndex = 5;
            this.txtActPrecio.Text = "PRECIO:";
            // 
            // txtActIdProducto
            // 
            this.txtActIdProducto.AutoSize = true;
            this.txtActIdProducto.Location = new System.Drawing.Point(6, 27);
            this.txtActIdProducto.Name = "txtActIdProducto";
            this.txtActIdProducto.Size = new System.Drawing.Size(21, 13);
            this.txtActIdProducto.TabIndex = 2;
            this.txtActIdProducto.Text = "ID:";
            // 
            // txtActStock
            // 
            this.txtActStock.AutoSize = true;
            this.txtActStock.Location = new System.Drawing.Point(6, 79);
            this.txtActStock.Name = "txtActStock";
            this.txtActStock.Size = new System.Drawing.Size(46, 13);
            this.txtActStock.TabIndex = 4;
            this.txtActStock.Text = "STOCK:";
            this.txtActStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActNomProducto
            // 
            this.txtActNomProducto.AutoSize = true;
            this.txtActNomProducto.Location = new System.Drawing.Point(6, 54);
            this.txtActNomProducto.Name = "txtActNomProducto";
            this.txtActNomProducto.Size = new System.Drawing.Size(71, 13);
            this.txtActNomProducto.TabIndex = 3;
            this.txtActNomProducto.Text = "PRODUCTO:";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.gbActProducto);
            this.Controls.Add(this.gbAddUsuario);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.txtTotalProductos);
            this.Controls.Add(this.DGVProductos);
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            this.gbAddUsuario.ResumeLayout(false);
            this.gbAddUsuario.PerformLayout();
            this.gbActProducto.ResumeLayout(false);
            this.gbActProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Label txtTotalProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Label txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox tbBuscarProducto;
        private System.Windows.Forms.GroupBox gbAddUsuario;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbNomProducto;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtIdProducto;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label txtNomProducto;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label idProveedor;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.GroupBox gbActProducto;
        private System.Windows.Forms.TextBox tbActPrecio;
        private System.Windows.Forms.Label txtActIdProveedor;
        private System.Windows.Forms.TextBox tbActDescripcion;
        private System.Windows.Forms.TextBox tbActStock;
        private System.Windows.Forms.TextBox tbActNomProducto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tbActIdProducto;
        private System.Windows.Forms.ComboBox cbActProveedores;
        private System.Windows.Forms.Label txtActDescripcion;
        private System.Windows.Forms.Label txtActPrecio;
        private System.Windows.Forms.Label txtActIdProducto;
        private System.Windows.Forms.Label txtActStock;
        private System.Windows.Forms.Label txtActNomProducto;
    }
}