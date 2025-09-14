using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.Administrador
{
    public partial class FormAgregarRol : Form
    {
        public FormAgregarRol()
        {
            InitializeComponent();
        }

     

        

        private void iD_rolTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private bool completoCampos()
        {
            if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)

        {   
           
    }
        private void bloqueo()
        {
            rOLDataGridView.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
        }
        private void desbloqueo()
        {
            rOLDataGridView.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

       

        private void descripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convertir a mayúsculas
            e.KeyChar = char.ToUpper(e.KeyChar);
            // Permitir solo letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(descripcionTextBox, "Solo se permiten letras y espacios.");
            }
            else
            {
                errorProvider1.SetError(descripcionTextBox, "");
            }
        }
    }
}
