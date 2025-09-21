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
    public partial class FormCancelarPedido : Form
    {
        public FormCancelarPedido()
        {
            InitializeComponent();
        }

        private void dataGridViewModificarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar si se hizo clic en el botón Column8
            if (e.ColumnIndex == dataGridViewModificarPedidos.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                //Indicar el motivo de la cancelación
                FormMotivoCancelacion formMotivo = new FormMotivoCancelacion();
                if (formMotivo.ShowDialog() == DialogResult.OK)
                {
                    string motivo = formMotivo.DatoIngresado;
                    // usar el motivo ingresado según sea necesario
                    //MessageBox.Show("Motivo de cancelación: " + motivo);
                }
                //Pedir confirmación antes de guardar los cambios
                var confirmResult = MessageBox.Show("¿Está seguro de que desea cancelar el pedido?", "Confirmar Cancelación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Lógica para cancelar el pedido
                    MessageBox.Show("Pedido cancelado exitosamente.");
                }
                lblPedidoCancelado.Visible = true;


            }
        }
    }
}
