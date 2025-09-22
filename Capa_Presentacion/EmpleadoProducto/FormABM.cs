using ArimaERP.EmpleadoClientes;
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
    public partial class FormABM : Form
    {
        public FormABM()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private enum Vista { Alta, Baja, Modificacion }

        private void MostrarVista(Vista v)
        {
            // Aseguramos que solo 1 vista esté visible
            PAlta.Visible = (v == Vista.Alta);
            PBaja.Visible = (v == Vista.Baja);
            PModificacion.Visible = (v == Vista.Modificacion);

            // Y traemos al frente la vista activa
            switch (v)
            {
                case Vista.Alta: PAlta.BringToFront(); break;
                case Vista.Baja: PBaja.BringToFront(); break;
                case Vista.Modificacion: PModificacion.BringToFront(); break;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Alta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Baja);
        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Modificacion);
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
                FormEditarProducto formEditarProducto = new FormEditarProducto();
                formEditarProducto.ShowDialog();
                // formEditarCliente.txtBoxNombre.Text = txtBuscarDni.Text;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {

                FormEditarProducto formEditarProducto = new FormEditarProducto();
                formEditarProducto.ShowDialog();
                e.SuppressKeyPress = true; // evita que se edite la celda
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros y teclas de control (como retroceso) y no mas de 10 caracteres
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBoxCodigo.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxCodigo, "Máximo 10 caracteres.");
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso) y no mas de 30 caracteres
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNombre.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombre, "Máximo 30 caracteres.");
            }
        }

        private void txtPrecioUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros, un punto y teclas de control (como retroceso) y no mas de 10 caracteres
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un punto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPrecioUnit.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPrecioUnit, "Máximo 10 caracteres.");
            }
        }
    }
}
