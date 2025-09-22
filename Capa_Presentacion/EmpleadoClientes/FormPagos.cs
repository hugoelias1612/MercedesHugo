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
    public partial class FormPagos : Form
    {
        public FormPagos()
        {
            InitializeComponent();
        }

        private void textBoxNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir el ingreso de numeros únicamente

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNumeroPedido, "No se permiten letras ni caracteres especiales.");
            }
            else
            {
                errorProvider1.SetError(textBoxNumeroPedido, ""); // Limpiar el error si la entrada es válida
            }

        }

        private void txtBoxMontoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir el ingreso de numeros y un punto decimal únicamente
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtBoxMontoMaximo, "Solo se permiten números y un punto decimal.");
            }
            else if (e.KeyChar == '.' && txtBoxMontoMaximo.Text.Contains('.'))
            {
                e.Handled = true; // No permitir más de un punto decimal
                errorProvider1.SetError(txtBoxMontoMaximo, "Solo se permite un punto decimal.");
            }
            else
            {
                errorProvider1.SetError(txtBoxMontoMaximo, ""); // Limpiar el error si la entrada es válida
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //cerrar
            this.Close();
        }

        private void dataGridViewModificarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //visualizar tabla de pagos si se selecciona una celda Column8 y visualizar el detalle del pago en el dataGridViewDetallePagos si se selecciona una celda Column9
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewModificarPedidos.Columns["Column8"].Index)
            {
                tableLayoutPanelRegistrarPago.Visible = true;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewModificarPedidos.Columns["Column9"].Index)
            {
                dataGridViewDetallePagos.Visible = true;
            }

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir el ingreso de números y un punto decimal únicamente
            switch (e.KeyChar)
            {
                case '.':
                    if (textBox8.Text.Contains('.'))
                    {
                        e.Handled = true; // No permitir más de un punto decimal
                        errorProvider1.SetError(textBox8, "Solo se permite un punto decimal.");
                    }
                    break;
                case char c when !char.IsControl(c) && !char.IsDigit(c):
                    e.Handled = true; // No permitir letras ni caracteres especiales
                    errorProvider1.SetError(textBox8, "Solo se permiten números y un punto decimal.");
                    break;
                default:
                    errorProvider1.SetError(textBox8, ""); // Limpiar el error si la entrada es válida
                    break;
            }
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            //Es
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            //cargar en lblFechaActual la fecha actual
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            //visualizar el panel panel tableLayoutPanelRegistrarPago
            tableLayoutPanelRegistrarPago.Visible = true;
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            //validar que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                errorProvider1.SetError(textBox8, "El campo Monto es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox8, ""); // Limpiar el error si la entrada es válida
            }
            //cliente valido
            if (string.IsNullOrWhiteSpace(textBoxCliente.Text))
            {
                errorProvider1.SetError(textBoxCliente, "El campo Cliente es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxCliente, ""); // Limpiar el error si la entrada es válida
            }
            //seleccionar metodo de pago
            if (comboBoxMetodoPago.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxMetodoPago, "Debe seleccionar un método de pago.");
                return;
            }
            else
            {
                errorProvider1.SetError(comboBoxMetodoPago, ""); // Limpiar el error si la entrada es válida
            }
            //si todo es valido, registrar el pago
            MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
    }
}
