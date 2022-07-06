
namespace SistemaVentas.Vistas
{
    partial class FormVentas
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
            this.components = new System.ComponentModel.Container();
            this.gbLecturaCodigo = new System.Windows.Forms.GroupBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.DGVListaVentas = new System.Windows.Forms.DataGridView();
            this.txtVentaTotal = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHora = new System.Windows.Forms.Label();
            this.gbLecturaCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVentas)).BeginInit();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLecturaCodigo
            // 
            this.gbLecturaCodigo.Controls.Add(this.tbCodigo);
            this.gbLecturaCodigo.Location = new System.Drawing.Point(12, 12);
            this.gbLecturaCodigo.Name = "gbLecturaCodigo";
            this.gbLecturaCodigo.Size = new System.Drawing.Size(379, 59);
            this.gbLecturaCodigo.TabIndex = 0;
            this.gbLecturaCodigo.TabStop = false;
            this.gbLecturaCodigo.Text = "LEER CODIGO";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.Location = new System.Drawing.Point(6, 19);
            this.tbCodigo.Multiline = true;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(367, 22);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.TextChanged += new System.EventHandler(this.TBCodigo_TextChanged);
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // DGVListaVentas
            // 
            this.DGVListaVentas.AllowUserToAddRows = false;
            this.DGVListaVentas.AllowUserToDeleteRows = false;
            this.DGVListaVentas.AllowUserToOrderColumns = true;
            this.DGVListaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVentas.Location = new System.Drawing.Point(12, 77);
            this.DGVListaVentas.Name = "DGVListaVentas";
            this.DGVListaVentas.ReadOnly = true;
            this.DGVListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListaVentas.Size = new System.Drawing.Size(1066, 471);
            this.DGVListaVentas.TabIndex = 2;
            this.DGVListaVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaVentas_CellClick);
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVentaTotal.AutoSize = true;
            this.txtVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaTotal.Location = new System.Drawing.Point(12, 562);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.Size = new System.Drawing.Size(85, 29);
            this.txtVentaTotal.TabIndex = 3;
            this.txtVentaTotal.Text = "label1";
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(954, 557);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(124, 34);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Controls.Add(this.btnLimpiar);
            this.gbAcciones.Controls.Add(this.btnRestar);
            this.gbAcciones.Controls.Add(this.btnSumar);
            this.gbAcciones.Controls.Add(this.txtIdProducto);
            this.gbAcciones.Location = new System.Drawing.Point(397, 12);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(458, 59);
            this.gbAcciones.TabIndex = 5;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "ACCIONES";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(298, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(379, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(217, 22);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "RESTAR";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(136, 22);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "SUMAR";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdProducto.AutoSize = true;
            this.txtIdProducto.Location = new System.Drawing.Point(6, 27);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(120, 13);
            this.txtIdProducto.TabIndex = 0;
            this.txtIdProducto.Text = "Selecciona un producto";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFecha.Location = new System.Drawing.Point(982, 9);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(57, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.Text = "label1";
            this.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.AutoSize = true;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(988, 32);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(51, 16);
            this.txtHora.TabIndex = 7;
            this.txtHora.Text = "label1";
            this.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtVentaTotal);
            this.Controls.Add(this.DGVListaVentas);
            this.Controls.Add(this.gbLecturaCodigo);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.gbLecturaCodigo.ResumeLayout(false);
            this.gbLecturaCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVentas)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLecturaCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.DataGridView DGVListaVentas;
        private System.Windows.Forms.Label txtVentaTotal;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label txtIdProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtHora;
    }
}