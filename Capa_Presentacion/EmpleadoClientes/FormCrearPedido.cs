using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormCrearPedido : Form
    {
        public FormCrearPedido()
        {
            InitializeComponent();
        }

        private void FormCrearPedido_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //Cargar comboBox de categorías de zonas
            /*using (SqlConnection conn = new SqlConnection(tuCadenaConexion))
            {
                string query = "SELECT DISTINCT Zona FROM Clientes ORDER BY Zona";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxClienteZona.DataSource = dt;
                comboBoxClienteZona.DisplayMember = "Zona";
                comboBoxClienteZona.ValueMember = "Zona";
                comboBoxClienteZona.SelectedIndex = -1; // Para que no haya selección inicial
            }*/
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ir a FormCliente
            FormCliente formCliente = new FormCliente();
            formCliente.Show();

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            //cerrar formulario
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Validar campos en dataGridViewDetallePedido
            if (dataGridViewDetallePedido.Rows.Count == 0)
            {
                MessageBox.Show("El pedido debe tener al menos un producto.");
                return;
            }
            /*foreach (DataGridViewRow row in dataGridViewDetallePedido.Rows)
            {
                if (row.Cells["Cantidad"].Value == null || Convert.ToInt32(row.Cells["Cantidad"].Value) <= 0)
                {
                    MessageBox.Show("La cantidad de cada producto debe ser mayor a cero.");
                    return;
                }
                if (row.Cells["PrecioUnitario"].Value == null || Convert.ToDecimal(row.Cells["PrecioUnitario"].Value) <= 0)
                {
                    MessageBox.Show("El precio unitario de cada producto debe ser mayor a cero.");
                    return;
                }
            }
            //Guardar pedido
            MessageBox.Show("Pedido guardado correctamente.");*/


        }
    }
}
