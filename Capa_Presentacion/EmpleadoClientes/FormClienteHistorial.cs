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
    public partial class FormClienteHistorial : Form
    {
        public FormClienteHistorial()
        {
            InitializeComponent();
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListarPagos_Click(object sender, EventArgs e)
        {
            //Visualizar dataGridViewDetallePagos
            dataGridViewDetallePagos.Visible = true;
        }

        private void btnListarPedidosPendientes_Click(object sender, EventArgs e)
        {
            //visualizar dataGridViewVerPedidos
            dataGridViewVerPedidos.Visible = true;
            dgvClientes.Visible = false;
            dataGridViewDetallePagos.Visible = false;
        }

        private void btnPedidosEntregados_Click(object sender, EventArgs e)
        {
            //visualizar dataGridViewVerPedidos
            dataGridViewVerPedidos.Visible = true;
            dgvClientes.Visible = false;
            dataGridViewDetallePagos.Visible=false;
        }

        private void btnListarSaldosPendientes_Click(object sender, EventArgs e)
        {
            dataGridViewVerPedidos.Visible = true;
            dataGridViewDetallePagos.Visible = false;
            dgvClientes.Visible=false;
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = true;
            dataGridViewDetallePagos.Visible = false;
            dataGridViewVerPedidos.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar formulario
            this.Close();
        }
    } }
