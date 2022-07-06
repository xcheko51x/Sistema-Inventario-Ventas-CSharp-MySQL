
namespace SistemaVentas.Vistas
{
    partial class FormReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.gbFechasReporte = new System.Windows.Forms.GroupBox();
            this.btnObtenerVentas = new System.Windows.Forms.Button();
            this.txtInfoFechas = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFinal = new System.Windows.Forms.Label();
            this.txtFechaInicial = new System.Windows.Forms.Label();
            this.DGVVentasUsuarios = new System.Windows.Forms.DataGridView();
            this.gbVentasUsuarios = new System.Windows.Forms.GroupBox();
            this.gbVentasProductos = new System.Windows.Forms.GroupBox();
            this.DGVVentasProductos = new System.Windows.Forms.DataGridView();
            this.chartVentasUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProductosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.gbFechasReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentasUsuarios)).BeginInit();
            this.gbVentasUsuarios.SuspendLayout();
            this.gbVentasProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentasProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(6, 65);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // gbFechasReporte
            // 
            this.gbFechasReporte.Controls.Add(this.btnObtenerVentas);
            this.gbFechasReporte.Controls.Add(this.txtInfoFechas);
            this.gbFechasReporte.Controls.Add(this.dtpFechaFinal);
            this.gbFechasReporte.Controls.Add(this.txtFechaFinal);
            this.gbFechasReporte.Controls.Add(this.txtFechaInicial);
            this.gbFechasReporte.Controls.Add(this.dtpFechaInicial);
            this.gbFechasReporte.Location = new System.Drawing.Point(12, 12);
            this.gbFechasReporte.Name = "gbFechasReporte";
            this.gbFechasReporte.Size = new System.Drawing.Size(405, 95);
            this.gbFechasReporte.TabIndex = 1;
            this.gbFechasReporte.TabStop = false;
            this.gbFechasReporte.Text = "FECHAS REPORTE";
            // 
            // btnObtenerVentas
            // 
            this.btnObtenerVentas.Location = new System.Drawing.Point(285, 66);
            this.btnObtenerVentas.Name = "btnObtenerVentas";
            this.btnObtenerVentas.Size = new System.Drawing.Size(114, 23);
            this.btnObtenerVentas.TabIndex = 5;
            this.btnObtenerVentas.Text = "OBTENER VENTAS";
            this.btnObtenerVentas.UseVisualStyleBackColor = true;
            this.btnObtenerVentas.Click += new System.EventHandler(this.btnObtenerVentas_Click);
            // 
            // txtInfoFechas
            // 
            this.txtInfoFechas.AutoSize = true;
            this.txtInfoFechas.Location = new System.Drawing.Point(6, 16);
            this.txtInfoFechas.Name = "txtInfoFechas";
            this.txtInfoFechas.Size = new System.Drawing.Size(320, 13);
            this.txtInfoFechas.TabIndex = 4;
            this.txtInfoFechas.Text = "Selecciona la fecha inicial y final para generar el reporte de ventas";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(143, 65);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFinal.TabIndex = 3;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.AutoSize = true;
            this.txtFechaFinal.Location = new System.Drawing.Point(140, 49);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.txtFechaFinal.TabIndex = 2;
            this.txtFechaFinal.Text = "Fecha Final";
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.AutoSize = true;
            this.txtFechaInicial.Location = new System.Drawing.Point(6, 49);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Size = new System.Drawing.Size(67, 13);
            this.txtFechaInicial.TabIndex = 1;
            this.txtFechaInicial.Text = "Fecha Inicial";
            // 
            // DGVVentasUsuarios
            // 
            this.DGVVentasUsuarios.AllowUserToAddRows = false;
            this.DGVVentasUsuarios.AllowUserToDeleteRows = false;
            this.DGVVentasUsuarios.AllowUserToOrderColumns = true;
            this.DGVVentasUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVVentasUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentasUsuarios.Location = new System.Drawing.Point(6, 19);
            this.DGVVentasUsuarios.Name = "DGVVentasUsuarios";
            this.DGVVentasUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVVentasUsuarios.Size = new System.Drawing.Size(514, 213);
            this.DGVVentasUsuarios.TabIndex = 2;
            this.DGVVentasUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListas_CellClick);
            // 
            // gbVentasUsuarios
            // 
            this.gbVentasUsuarios.Controls.Add(this.DGVVentasUsuarios);
            this.gbVentasUsuarios.Location = new System.Drawing.Point(12, 113);
            this.gbVentasUsuarios.Name = "gbVentasUsuarios";
            this.gbVentasUsuarios.Size = new System.Drawing.Size(526, 238);
            this.gbVentasUsuarios.TabIndex = 3;
            this.gbVentasUsuarios.TabStop = false;
            this.gbVentasUsuarios.Text = "VENTAS USUARIOS";
            // 
            // gbVentasProductos
            // 
            this.gbVentasProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbVentasProductos.Controls.Add(this.DGVVentasProductos);
            this.gbVentasProductos.Location = new System.Drawing.Point(12, 357);
            this.gbVentasProductos.Name = "gbVentasProductos";
            this.gbVentasProductos.Size = new System.Drawing.Size(526, 231);
            this.gbVentasProductos.TabIndex = 4;
            this.gbVentasProductos.TabStop = false;
            this.gbVentasProductos.Text = "VENTAS PRODUCTOS";
            // 
            // DGVVentasProductos
            // 
            this.DGVVentasProductos.AllowUserToAddRows = false;
            this.DGVVentasProductos.AllowUserToDeleteRows = false;
            this.DGVVentasProductos.AllowUserToOrderColumns = true;
            this.DGVVentasProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVVentasProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentasProductos.Location = new System.Drawing.Point(6, 19);
            this.DGVVentasProductos.Name = "DGVVentasProductos";
            this.DGVVentasProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVVentasProductos.Size = new System.Drawing.Size(514, 206);
            this.DGVVentasProductos.TabIndex = 0;
            this.DGVVentasProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListas_CellClick);
            // 
            // chartVentasUsuarios
            // 
            this.chartVentasUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartVentasUsuarios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentasUsuarios.Legends.Add(legend1);
            this.chartVentasUsuarios.Location = new System.Drawing.Point(544, 113);
            this.chartVentasUsuarios.Name = "chartVentasUsuarios";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVentasUsuarios.Series.Add(series1);
            this.chartVentasUsuarios.Size = new System.Drawing.Size(534, 238);
            this.chartVentasUsuarios.TabIndex = 5;
            this.chartVentasUsuarios.Text = "chart1";
            // 
            // chartProductosVendidos
            // 
            this.chartProductosVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartProductosVendidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProductosVendidos.Legends.Add(legend2);
            this.chartProductosVendidos.Location = new System.Drawing.Point(544, 357);
            this.chartProductosVendidos.Name = "chartProductosVendidos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProductosVendidos.Series.Add(series2);
            this.chartProductosVendidos.Size = new System.Drawing.Size(534, 231);
            this.chartProductosVendidos.TabIndex = 6;
            this.chartProductosVendidos.Text = "chart1";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(1003, 12);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(75, 47);
            this.btnGenerarReporte.TabIndex = 7;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.chartProductosVendidos);
            this.Controls.Add(this.chartVentasUsuarios);
            this.Controls.Add(this.gbVentasProductos);
            this.Controls.Add(this.gbVentasUsuarios);
            this.Controls.Add(this.gbFechasReporte);
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.gbFechasReporte.ResumeLayout(false);
            this.gbFechasReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentasUsuarios)).EndInit();
            this.gbVentasUsuarios.ResumeLayout(false);
            this.gbVentasProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentasProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.GroupBox gbFechasReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label txtFechaFinal;
        private System.Windows.Forms.Label txtFechaInicial;
        private System.Windows.Forms.Button btnObtenerVentas;
        private System.Windows.Forms.Label txtInfoFechas;
        private System.Windows.Forms.DataGridView DGVVentasUsuarios;
        private System.Windows.Forms.GroupBox gbVentasUsuarios;
        private System.Windows.Forms.GroupBox gbVentasProductos;
        private System.Windows.Forms.DataGridView DGVVentasProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasUsuarios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosVendidos;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}