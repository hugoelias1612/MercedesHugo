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
    public partial class FormFMP : Form
    {
        private bool limpiarPresionado = false;
        public FormFMP()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNombre.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombre, "Máximo 20 caracteres.");


            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtProvincia.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtProvincia, "Máximo 30 caracteres.");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBoxNroCalle.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNroCalle, "Máximo 10 caracteres.");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTelefono.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTelefono, "Máximo 15 caracteres.");
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCiudad.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCiudad, "Máximo 30 caracteres.");
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limitar la longitud del correo electrónico a 50 caracteres
            if (txtEmail.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtEmail, "Máximo 50 caracteres.");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            // Validar el formato del correo electrónico
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                    if (addr.Address != txtEmail.Text)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtEmail, "Formato de correo electrónico inválido.");
                    }
                    else
                    {
                        errorProvider1.SetError(txtEmail, string.Empty);
                    }
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Formato de correo electrónico inválido.");
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            if (limpiarPresionado)
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            //si this.Is Disposed no hacer nada
           if (this.IsDisposed)
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, string.Empty);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPresionado = true;
            // Limpiar todos los campos del formulario
            txtNombre.Clear();
            txtProvincia.Clear();
            textBoxNroCalle.Clear();
            txtTelefono.Clear();
            txtCiudad.Clear();
            txtEmail.Clear();
            errorProvider1.Clear();
            txtCalle.Clear();
            txtNombreMarca.Clear();
            
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso) y máximo 25 caracteres
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCalle.Text.Length >= 25 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCalle, "Máximo 25 caracteres.");
            }
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo letras, espacios y teclas de control (como retroceso) y máximo 30 caracteres
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNombreMarca.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreMarca, "Máximo 30 caracteres.");
            }
        }
    }
}
