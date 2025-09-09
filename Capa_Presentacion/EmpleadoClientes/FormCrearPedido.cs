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
            /*string valor = txtBuscarCliente.Text.Trim();
            string campo = comboBoxBuscarClienteCategorias.SelectedItem?.ToString();
            string zona = comboBoxClienteZona.SelectedIndex != -1 ? comboBoxClienteZona.SelectedValue.ToString() : null;

            // Validación: si no hay valor ni campo, pero sí zona → buscar solo por zona
            if (string.IsNullOrEmpty(valor) && (string.IsNullOrEmpty(campo) || campo == "Todos") && !string.IsNullOrEmpty(zona))
            {
                string queryZona = "SELECT * FROM Clientes WHERE Zona = @zona";

                using (SqlConnection conn = new SqlConnection(tuCadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(queryZona, conn);
                    cmd.Parameters.AddWithValue("@zona", zona);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvResultados.DataSource = dt;
                }

                return;
            }

            // Validación: si no hay valor y tampoco zona → mostrar mensaje
            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ingrese un valor para buscar o seleccione una zona.");
                return;
            }

            // Construcción dinámica de la consulta
            List<string> condiciones = new List<string>();
            string query = "SELECT * FROM Clientes WHERE ";

            if (campo == "Todos" || string.IsNullOrEmpty(campo))
            {
                condiciones.Add("Nombre LIKE @valor");
                condiciones.Add("CUIT LIKE @valor");
                condiciones.Add("RazonSocial LIKE @valor");
                condiciones.Add("Localidad LIKE @valor");
                query += "(" + string.Join(" OR ", condiciones) + ")";
            }
            else
            {
                query += $"{campo} LIKE @valor";
            }

            // Agregar condición de zona si existe
            if (!string.IsNullOrEmpty(zona))
            {
                query += " AND Zona = @zona";
            }

            using (SqlConnection conn = new SqlConnection(tuCadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                if (!string.IsNullOrEmpty(zona))
                {
                    cmd.Parameters.AddWithValue("@zona", zona);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ir a FormCliente
            FormCliente formCliente = new FormCliente();
            formCliente.Show();

        }
    }
}
