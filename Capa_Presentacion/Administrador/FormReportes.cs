using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar using de charts
using System.Windows.Forms.DataVisualization.Charting;

namespace ArimaERP.Administrador
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            ConfigurarTabs();
            ConfigurarCharts();
            InitializeComponent();
            ConfigurarCharts();
            ConfigurarGraficoVentasMes((Chart)tabGraficos.TabPages[0].Controls[0]);
            ConfigurarGraficoTopProductos((Chart)tabGraficos.TabPages[1].Controls[0]);
            ConfigurarGraficoComparativa((Chart)tabGraficos.TabPages[2].Controls[0]);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarTabs()
        {
            // Limpiar tabs existentes
            tabGraficos.TabPages.Clear();

            // Crear los 3 tabs
            TabPage tabVentasMes = new TabPage("Ventas del Mes");
            TabPage tabTopProductos = new TabPage("Productos Más Vendidos");
            TabPage tabComparativa = new TabPage("Comparativa Mensual");

            // Agregar al TabControl
            tabGraficos.TabPages.Add(tabVentasMes);
            tabGraficos.TabPages.Add(tabTopProductos);
            tabGraficos.TabPages.Add(tabComparativa);
        }

        private void ConfigurarCharts()
        {
            // TAB 1 - Ventas del Mes (Gráfico de Barras)
            Chart chartVentasMes = new Chart();
            chartVentasMes.Dock = DockStyle.Fill;
            chartVentasMes.BackColor = Color.White;
            tabGraficos.TabPages[0].Controls.Add(chartVentasMes);

            // TAB 2 - Top Productos (Gráfico de Torta)
            Chart chartTopProductos = new Chart();
            chartTopProductos.Dock = DockStyle.Fill;
            chartTopProductos.BackColor = Color.White;
            tabGraficos.TabPages[1].Controls.Add(chartTopProductos);

            // TAB 3 - Comparativa (Gráfico de Líneas)
            Chart chartComparativa = new Chart();
            chartComparativa.Dock = DockStyle.Fill;
            chartComparativa.BackColor = Color.White;
            tabGraficos.TabPages[2].Controls.Add(chartComparativa);
        }


        private void ConfigurarGraficoVentasMes(Chart chart)
        {
            // Crear área del gráfico
            ChartArea area = new ChartArea("VentasArea");
            chart.ChartAreas.Add(area);

            // Crear serie de datos
            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Column; // Barras
            chart.Series.Add(serie);

            // Datos de ejemplo
            serie.Points.AddXY("Semana 1", 15000);
            serie.Points.AddXY("Semana 2", 22000);
            serie.Points.AddXY("Semana 3", 18000);
            serie.Points.AddXY("Semana 4", 25000);
        }

        private void ConfigurarGraficoTopProductos(Chart chart)
        {
            ChartArea area = new ChartArea("ProductosArea");
            chart.ChartAreas.Add(area);

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Pie; // Torta
            chart.Series.Add(serie);

            // Datos de ejemplo
            serie.Points.AddXY("Lácteos", 35);
            serie.Points.AddXY("Bebidas", 25);
            serie.Points.AddXY("Snacks", 20);
            serie.Points.AddXY("Otros", 20);
        }

        private void ConfigurarGraficoComparativa(Chart chart)
        {
            ChartArea area = new ChartArea("ComparativaArea");
            chart.ChartAreas.Add(area);

            Series serieActual = new Series("Mes Actual");
            serieActual.ChartType = SeriesChartType.Line; // Líneas
            Series serieAnterior = new Series("Mes Anterior");
            serieAnterior.ChartType = SeriesChartType.Line;

            chart.Series.Add(serieActual);
            chart.Series.Add(serieAnterior);

            // Datos de ejemplo
            serieActual.Points.AddXY("Sem 1", 15000);
            serieActual.Points.AddXY("Sem 2", 22000);
            serieAnterior.Points.AddXY("Sem 1", 12000);
            serieAnterior.Points.AddXY("Sem 2", 18000);
        }
    }
}
