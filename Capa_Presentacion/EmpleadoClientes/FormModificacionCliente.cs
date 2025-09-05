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
    public partial class FormModificacionCliente : Form
    {
        public FormModificacionCliente()
        {
            InitializeComponent();
        }

        private void tableLayoutPanelModificarCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = txtBuscarDni.Text;
                txtBuscarDni.Clear();
                this.ActiveControl = dataGridView1; // quita el foco del TextBox
                                                    // 4. Seleccionar automáticamente la última fila agregada
                int ultimaFila = dataGridView1.Rows.Count - 1;
                if (ultimaFila >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[ultimaFila].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[ultimaFila].Cells[0];
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                FormEditarCliente formEditarCliente = new FormEditarCliente();
                formEditarCliente.ShowDialog();
               // formEditarCliente.txtBoxNombre.Text = txtBuscarDni.Text;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {

                FormEditarCliente formEditarCliente = new FormEditarCliente();
                formEditarCliente.ShowDialog();
                e.SuppressKeyPress = true; // evita que se edite la celda
            }
        }

        private void FormModificacionCliente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}