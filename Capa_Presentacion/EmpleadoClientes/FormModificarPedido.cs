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
    public partial class FormModificarPedido : Form
    {
        public FormModificarPedido()
        {
            InitializeComponent();
        }

        
        private void textBoxNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ingresar solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNumeroPedido, "Ingrese solo números.");
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ingresar solo números decimales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox6, "Ingrese solo números y un punto decimal.");
            }

        }

        private void dataGridViewModificarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                //verificar si se hizo clic en el botón Column8
                if (e.ColumnIndex == dataGridViewModificarPedidos.Columns["Column8"].Index && e.RowIndex >= 0)
                {
                //Pedir confirmación antes de guardar los cambios
                var confirmResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo);
            }
        }

        private void dataGridViewDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Confirmar que desea guardar los cambios
            if (e.ColumnIndex == dataGridViewDetallePedido.Columns["Column11"].Index&& e.RowIndex >= 0)
            {
                //Pedir confirmación antes de guardar los cambios
                var confirmResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo);
            }
            //verificar si se selecciono Cantidad_unidad para editar
            if (e.ColumnIndex == dataGridViewDetallePedido.Columns["Cantidad_unidad"].Index && e.RowIndex >= 0)
            {
                //Hacer la celda editable
                dataGridViewDetallePedido.ReadOnly = false;
            }
            //verificar si se seleccionó Cantidad_Bulto para editar
            if (e.ColumnIndex == dataGridViewDetallePedido.Columns["Cantidad_Bulto"].Index && e.RowIndex >= 0)
            {
                //Hacer la celda editable
                dataGridViewDetallePedido.ReadOnly = false;
            }

        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            //Cerrar formulario
            this.Close();
         }
    }
}
