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
    public partial class FormBajaCliente : Form
    {
        public FormBajaCliente()
        {
            InitializeComponent();
        }

        private void lblRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void FormBajaCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo letras, control y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxApellido, "Solo se permiten letras");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(textBoxApellido, "");
            }
        }
    }
}
