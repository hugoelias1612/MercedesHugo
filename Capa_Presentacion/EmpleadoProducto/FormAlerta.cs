using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class FormAlerta : Form
    {
        public FormAlerta()
        {
            InitializeComponent();
        }

        private void FormAlerta_Load(object sender, EventArgs e)
        {
            // Encabezado
            DGResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DGResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DGResultados.ColumnHeadersHeight = 34;
            DGResultados.EnableHeadersVisualStyles = false; // para que respete tus colores
            DGResultados.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGResultados.ColumnHeadersDefaultCellStyle.BackColor;
            DGResultados.ColumnHeadersDefaultCellStyle.SelectionForeColor = DGResultados.ColumnHeadersDefaultCellStyle.ForeColor;



            // Filas
            DGResultados.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            DGResultados.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGResultados.GridColor = Color.FromArgb(210, 220, 235);

            // Ajuste de bordes
            DGResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Estado inicial
            LEstado.Text = "Sin resultados. Ajustá los filtros y presioná Buscar.";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();

            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Familia", typeof(string));
            dt.Columns.Add("Proveedor", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("StockMinimo", typeof(int));
            // Fila de ejemplo
            dt.Rows.Add("Gaseosa Rica 2L", "Bebidas", "SHES", 2100m, 8, 12);
            dt.Rows.Add("Aceite Suave 900", "Alimentos", "Casaborrás", 3400m, 2, 6);
            dt.Rows.Add("Velas Light x10", "Pilas–Enc.–Velas", "PoP", 1300m, 0, 30);

            DGResultados.DataSource = dt;
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            CbFamilia.SelectedIndex = -1;
            CbProveedor.SelectedIndex = -1;
            TNombreContiene.Clear();
            CheckBoxUmbral.Checked = false;
            NStockMax.Value = 10;
            CbOrden.SelectedIndex = 0;

            DGResultados.DataSource = null;
        }
    }
}
