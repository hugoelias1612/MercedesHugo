using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormHistorialPreventista : Form
    {
        public FormHistorialPreventista()
        {
            InitializeComponent();
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarPreventista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarPreventista_Click(object sender, EventArgs e)
        {
            //Habilitar el uso del DataGridView
            dataGridViewHistorial.Enabled = true;
            //Habilitar menu contextual
            menuStripHistorialPreventista.Enabled = true;

        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("Nombre", "Nombre");
            dataGridViewHistorial.Columns.Add("Apellido", "Apellido");
            dataGridViewHistorial.Columns.Add("DNI", "DNI");
            dataGridViewHistorial.Columns.Add("Direccion", "Direccion");
            
        }

        private void noConfiablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("Nombre", "Nombre");
            dataGridViewHistorial.Columns.Add("Apellido", "Apellido");
            dataGridViewHistorial.Columns.Add("DNI", "DNI");
            dataGridViewHistorial.Columns.Add("Direccion", "Direccion");
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("ID Pedido", "ID Pedido");
            dataGridViewHistorial.Columns.Add("Detalle", "Detalle");
            dataGridViewHistorial.Columns.Add("Fecha", "Fecha");
            dataGridViewHistorial.Columns.Add("Monto", "Monto");
            dataGridViewHistorial.Columns.Add("Estado", "Estado");
            dataGridViewHistorial.Columns.Add("Cliente", "Cliente");
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("ID Venta", "ID Venta");
            dataGridViewHistorial.Columns.Add("Detalle", "Detalle");
            dataGridViewHistorial.Columns.Add("Fecha", "Fecha");
            dataGridViewHistorial.Columns.Add("Monto", "Monto");
            dataGridViewHistorial.Columns.Add("Cliente", "Cliente");

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("ID Producto", "ID Producto");
            dataGridViewHistorial.Columns.Add("Nombre", "Nombre");
            dataGridViewHistorial.Columns.Add("Descripcion", "Descripcion");
            dataGridViewHistorial.Columns.Add("Precio", "Precio");
            dataGridViewHistorial.Columns.Add("Stock", "Stock");
            dataGridViewHistorial.Columns.Add("Categoria", "Categoria");
            dataGridViewHistorial.Columns.Add("Proveedor", "Proveedor");
            dataGridViewHistorial.Columns.Add("apresentacion", "Presentacion");
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cargar columnas del DataGridView
            dataGridViewHistorial.Columns.Clear();
            dataGridViewHistorial.Columns.Add("ID Pago", "ID Pago");
            dataGridViewHistorial.Columns.Add("Monto", "Monto");
            dataGridViewHistorial.Columns.Add("Fecha", "Fecha");
            dataGridViewHistorial.Columns.Add("Metodo de Pago", "Metodo de Pago");
            dataGridViewHistorial.Columns.Add("Cliente", "Cliente");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }
    }
}
