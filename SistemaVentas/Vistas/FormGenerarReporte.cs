using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaVentas.Clases;

namespace SistemaVentas.Vistas
{
    public partial class FormGenerarReporte : Form
    {
        public List<Producto> listaProductosVendidos;
        public FormGenerarReporte()
        {
            InitializeComponent();
        }

        private void FormGenerarReporte_Load(object sender, EventArgs e)
        {
            this.rvReporte.RefreshReport();
            CargarReporte();
            
        }

        public void CargarReporte()
        {
            this.rvReporte.LocalReport.ReportEmbeddedResource = "SistemaVentas.InformeVentas.rdlc";
            ReportDataSource rds = new ReportDataSource("Producto", listaProductosVendidos);
            this.rvReporte.LocalReport.DataSources.Clear();
            this.rvReporte.LocalReport.DataSources.Add(rds);
            this.rvReporte.RefreshReport();
        }
    }
}
