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

namespace SistemaVentas.Vistas
{
    public partial class FormReportes : Form
    {
        MetodosReportes metodosReportes;
        MetodosProductos metodosProductos = new MetodosProductos();
        List<Reporte> listaReporte = new List<Reporte>();
        List<Usuario> listaVentasUsuarios = new List<Usuario>();
        List<Producto> listaProductosVendidos = new List<Producto>();

        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            FormatoTablaVentaUsuarios();
            FormatoTablaVentaProductos();
        }

        public void FormatoTablaVentaUsuarios()
        {

            DGVVentasUsuarios.Columns.Clear();
            DGVVentasUsuarios.Columns.Add("idUsuario", "ID USUARIO");
            DGVVentasUsuarios.Columns.Add("nomUsuario", "VENDEDOR");
            DGVVentasUsuarios.Columns.Add("total", "TOTAL VENDIDO");

            DGVVentasUsuarios.Columns["idUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVVentasUsuarios.Columns["nomUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVVentasUsuarios.Columns["total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void FormatoTablaVentaProductos()
        {

            DGVVentasProductos.Columns.Clear();
            DGVVentasProductos.Columns.Add("idProducto", "ID PRODUCTO");
            DGVVentasProductos.Columns.Add("nomProducto", "PRODUCTO");
            DGVVentasProductos.Columns.Add("cantVendida", "CANTIDAD VENDIDA");

            DGVVentasProductos.Columns["idProducto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVVentasProductos.Columns["nomProducto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVVentasProductos.Columns["cantVendida"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DGVListas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                
            }
        }

        private void btnObtenerVentas_Click(object sender, EventArgs e)
        {
            listaReporte.Clear();
            listaVentasUsuarios.Clear();
            listaProductosVendidos.Clear();

            DGVVentasUsuarios.Rows.Clear();
            DGVVentasProductos.Rows.Clear();

            metodosReportes = new MetodosReportes();
            string cadenaFechaInicial = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string cadenaFechaFinal = dtpFechaFinal.Value.ToString("yyyy-MM-dd");

            listaReporte = metodosReportes.ObtenerReporteVentas(cadenaFechaInicial, cadenaFechaFinal);

            if (listaReporte.Count() == 0)
            {
                MessageBox.Show("No hay ventas registradas entre esas fechas");
            }
            else
            {
                SepararVentasUsuarios();
                SepararProductosVendidos();
            }
        }

        public void SepararVentasUsuarios()
        {
            Boolean existe;
            for (int i = 0; i < listaReporte.Count; i++)
            {
                existe = false;
                int auxCountUsuario = 0;
                if (listaVentasUsuarios.Count == 0 && existe == false)
                {
                    listaVentasUsuarios.Add(
                        new Usuario(
                            Convert.ToInt32(listaReporte.ElementAt(i).idUsuario),
                            listaReporte.ElementAt(i).nomUsuario,
                            Convert.ToDouble(listaReporte.ElementAt(i).totalVenta)
                            )
                        );
                }
                else
                {
                    for (int j = 0; j < listaVentasUsuarios.Count; j++)
                    {
                        if (Convert.ToInt32(listaReporte.ElementAt(i).idUsuario) == listaVentasUsuarios.ElementAt(j).idUsuario)
                        {
                            existe = true;
                            auxCountUsuario = j;
                            j = listaVentasUsuarios.Count;
                        }
                    }

                    if (existe == true)
                    {
                        listaVentasUsuarios.ElementAt(auxCountUsuario).totalVendido = listaVentasUsuarios.ElementAt(auxCountUsuario).totalVendido + Convert.ToDouble(listaReporte.ElementAt(i).totalVenta);
                    }
                    else
                    {
                        listaVentasUsuarios.Add(
                        new Usuario(
                            Convert.ToInt32(listaReporte.ElementAt(i).idUsuario),
                            listaReporte.ElementAt(i).nomUsuario,
                            Convert.ToDouble(listaReporte.ElementAt(i).totalVenta)
                            )
                        );
                    }
                }
            }
            LlenarDGVVentasUsuarios(listaVentasUsuarios);

            MostrarGraficaVentasUsuarios(listaVentasUsuarios);
        }

        public void SepararProductosVendidos()
        {
            char[] delimitadores = { ',', '-' };
            /*string[] cadenaSeparada = listaReporte.ElementAt(1).idProductos.Split(delimitadores);
            MessageBox.Show(cadenaSeparada[0]+" : "+ cadenaSeparada[1]);*/

            for (int i = 0; i < listaReporte.Count; i++)
            {
                string[] cadenaSeparada = listaReporte.ElementAt(i).idProductos.Trim().Split(delimitadores);
                for(int j = 0; j < cadenaSeparada.Length; j = j+2)
                {
                    if (listaProductosVendidos.Count == 0)
                    {
                        listaProductosVendidos.Add(
                        new Producto(
                            cadenaSeparada[j+1],
                            "Nombre Producto",
                            Convert.ToInt32(cadenaSeparada[j])
                            )
                        );
                    }
                    else
                    {
                        for (int k = 0; k < listaProductosVendidos.Count; k++)
                        {
                            if (cadenaSeparada[j+1].Trim().Equals(listaProductosVendidos.ElementAt(k).idProducto.Trim()))
                            {
                                listaProductosVendidos.ElementAt(k).cantidadVendida = listaProductosVendidos.ElementAt(k).cantidadVendida + Convert.ToInt32(cadenaSeparada[j]);
                                k = listaProductosVendidos.Count;
                            } 
                            else
                            {
                                listaProductosVendidos.Add(
                                new Producto(
                                    cadenaSeparada[j + 1],
                                    "Nombre Producto",
                                    Convert.ToInt32(cadenaSeparada[j])
                                    )
                                );
                                k = listaProductosVendidos.Count;
                            }
                        }
                    }
                }
            }
            ObtenerNombreProductos(listaProductosVendidos);
            LlenarDGVProductosVendidos(listaProductosVendidos);
            MostrarGraficaProductosVendidos(listaProductosVendidos);
        }

        public void ObtenerNombreProductos(List<Producto> listaProductosVendidos)
        {
            for (int i = 0; i < listaProductosVendidos.Count; i++)
            {
                listaProductosVendidos.ElementAt(i).nomProducto = metodosProductos.ObtenerNombreProducto(listaProductosVendidos.ElementAt(i).idProducto.Trim());
            }
        }
        
        public void MostrarConsola(List<Producto> listaProductosVendidos)
        {
            for (int i = 0; i < listaProductosVendidos.Count; i++)
            {
                Console.WriteLine(listaProductosVendidos.ElementAt(i).idProducto+" - "+listaProductosVendidos.ElementAt(i).cantidadVendida);
            }
        }

        public void MostrarGraficaVentasUsuarios(List<Usuario> listaVentasUsuarios)
        {
            chartVentasUsuarios.Series["Series1"].Points.Clear();
            chartVentasUsuarios.Series["Series1"].LegendText = " Total vendido por usuario en el periodo " + dtpFechaInicial.Text + " al " + dtpFechaFinal.Text;

            for(int i = 0; i < listaVentasUsuarios.Count; i++)
            {
                chartVentasUsuarios.Series["Series1"].Points.AddXY(listaVentasUsuarios.ElementAt(i).nomUsuario, listaVentasUsuarios.ElementAt(i).totalVendido);
            }
        }

        public void MostrarGraficaProductosVendidos(List<Producto> listaProductosVendidos)
        {
            chartProductosVendidos.Series["Series1"].Points.Clear();
            chartProductosVendidos.Series["Series1"].LegendText = "Total de productos vendidos en el periodo " + dtpFechaInicial.Text + " al " + dtpFechaFinal.Text;

            for (int i = 0; i < listaProductosVendidos.Count; i++)
            {
                chartProductosVendidos.Series["Series1"].Points.AddXY(listaProductosVendidos.ElementAt(i).idProducto, listaProductosVendidos.ElementAt(i).cantidadVendida);
            }
        }

        public void LlenarDGVVentasUsuarios(List<Usuario> listaVentasUsuarios)
        {
            DGVVentasUsuarios.Rows.Clear();
            for (int i = 0; i < listaVentasUsuarios.Count(); i++)
            {
                DGVVentasUsuarios.Rows.Add(
                listaVentasUsuarios.ElementAt(i).idUsuario,
                listaVentasUsuarios.ElementAt(i).nomUsuario,
                listaVentasUsuarios.ElementAt(i).totalVendido
                );
            }
        }

        public void LlenarDGVProductosVendidos(List<Producto> listaProductosVendidos)
        {
            DGVVentasProductos.Rows.Clear();
            for (int i = 0; i < listaProductosVendidos.Count(); i++)
            {
                DGVVentasProductos.Rows.Add(
                listaProductosVendidos.ElementAt(i).idProducto,
                listaProductosVendidos.ElementAt(i).nomProducto,
                listaProductosVendidos.ElementAt(i).cantidadVendida
                );
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            FormGenerarReporte formGenerarReporte = new FormGenerarReporte();
            formGenerarReporte.listaProductosVendidos = listaProductosVendidos;
            formGenerarReporte.Show();
        }
    }
}
