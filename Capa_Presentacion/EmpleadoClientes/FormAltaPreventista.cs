using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormAltaPreventista : Form
    {
        public FormAltaPreventista()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {   
            //Validar que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContrasena.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxApellido.Text) || string.IsNullOrWhiteSpace(textBoxTelefono.Text) || string.IsNullOrWhiteSpace(textBoxMail.Text) || string.IsNullOrWhiteSpace(textBoxDNI.Text) || string.IsNullOrWhiteSpace(textBoxDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que se haya seleccionado una zona
            if (comboBoxZona.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una zona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Confirmar la creación del preventista
            var result = MessageBox.Show("¿Está seguro que desea crear el preventista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Mostrar mensaje de éxito
                MessageBox.Show("Preventista creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cerrar el formulario
                //limpiar todos los campos con el btnLimpiar
                btnLimpiar.PerformClick();
                //Activar btnCrear
                btnCrear.Enabled = true;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar todos los campos
            txtBoxUsuario.Text = "";
            textBoxContrasena.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxTelefono.Text = "";
            textBoxMail.Text = "";
            textBoxDNI.Text = "";
            textBoxDireccion.Text = "";
            errorProvider1.Clear();
        }

        private void textBoxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permitir espacios en blanco
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxContrasena, "No se permiten espacios en blanco.");
            }
            else
            {
                errorProvider1.SetError(textBoxContrasena, "");
            }
            // No permitir más de 20 caracteres
            if (textBoxContrasena.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxContrasena, "No se permiten más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxContrasena, "");
            }

        }

        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permitir espacios en blanco
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                errorProvider1.SetError(txtBoxUsuario, "No se permiten espacios en blanco.");
            }
            else
            {
                errorProvider1.SetError(txtBoxUsuario, "");
            }
            // No permitir más de 20 caracteres
            if (txtBoxUsuario.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtBoxUsuario, "No se permiten más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtBoxUsuario, "");
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Convertir a mayúscula la primera letra
            if (textBoxNombre.Text.Length == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            // Permitir solo letras, espacios y teclas de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNombre, "Solo se permiten letras.");
            }
            else if (!char.IsControl(e.KeyChar) && textBoxNombre.Text.Length >= 20)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNombre, "El nombre no debe exceder los 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxNombre, "");
            }

        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Convertir a mayúscula la primera letra
            if (textBoxApellido.Text.Length == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            // Permitir solo letras, espacios y teclas de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxApellido, "Solo se permiten letras.");
            }
            else if (!char.IsControl(e.KeyChar) && textBoxApellido.Text.Length >= 20)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxApellido, "El apellido no debe exceder los 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxApellido, "");
            }
        }

        private void textBoxMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir más de 50 caracteres
            if (textBoxMail.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxMail, "No se permiten más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxMail, "");
            }
        }

        private void textBoxMail_Validated(object sender, EventArgs e)
        {
            // Validar formato de correo electrónico
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBoxMail.Text);
                if (addr.Address != textBoxMail.Text)
                {
                    errorProvider1.SetError(textBoxMail, "Formato de correo electrónico inválido.");
                }
                else
                {
                    errorProvider1.SetError(textBoxMail, "");
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxMail, "Formato de correo electrónico inválido.");
            }
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir más de 50 caracteres
            if (textBoxDireccion.Text.Length >= 50 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDireccion, "No se permiten más de 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxDireccion, "");
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir letras ni caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDNI, "No se permiten letras ni caracteres especiales.");
            }
            else if (textBoxDNI.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDNI, "No se permiten más de 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxDNI, "");
            }


        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir letras ni caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxTelefono, "No se permiten letras ni caracteres especiales.");
            }
            else if (textBoxTelefono.Text.Length >= 15 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxTelefono, "No se permiten más de 15 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxTelefono, "");
            }

        }

        private void textBoxContrasena_Validating(object sender, CancelEventArgs e)
        {
            // Validar que la contraseña tenga al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial
            string password = textBoxContrasena.Text;
            if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                errorProvider1.SetError(textBoxContrasena, "La contraseña debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial.");
            }
            else
            {
                errorProvider1.SetError(textBoxContrasena, "");
            }
            //si esta vacío permitir avanzar
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(textBoxContrasena, "");
            }

        }

        private void txtBoxUsuario_Validating(object sender, CancelEventArgs e)
        {
            // No permitir más de 20 caracteres
            if (txtBoxUsuario.Text.Length < 8)
            {
                errorProvider1.SetError(txtBoxUsuario, "No se permiten menos de 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtBoxUsuario, "");
            }
        }



        private void textBoxDNI_Validating(object sender, CancelEventArgs e)
        {
            // No permitir menos de 7 caracteres
            if (textBoxDNI.Text.Length < 7)
            {
                errorProvider1.SetError(textBoxDNI, "El DNI debe tener entre 7 y 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxDNI, "");
            }
        }

        private void btnBuscarPreventista_Click(object sender, EventArgs e)
        {
            //Desactivar btnCrear
            btnCrear.Enabled = false;
            btnVolver.Enabled = false;
            btnModificar.Enabled = true;
            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContrasena.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxApellido.Text) || string.IsNullOrWhiteSpace(textBoxTelefono.Text) || string.IsNullOrWhiteSpace(textBoxMail.Text) || string.IsNullOrWhiteSpace(textBoxDNI.Text) || string.IsNullOrWhiteSpace(textBoxDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que se haya seleccionado una zona
            if (comboBoxZona.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una zona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Confirmar la modificación del preventista
            var result = MessageBox.Show("¿Está seguro que desea modificar el preventista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Mostrar mensaje de éxito
                MessageBox.Show("Preventista modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiar todos los campos con el btnLimpiar
                btnLimpiar.PerformClick();
                //Activar btnCrear
                btnCrear.Enabled = true;
                btnVolver.Enabled = true;
                btnModificar.Enabled = true;
                btnBaja.Enabled = false;
                btnCancelar.Enabled = false;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //permitir activar btnCrear
            btnCrear.Enabled = true;
            btnVolver.Enabled = true;
            btnModificar.Enabled = false;
            btnBaja.Enabled = false;
            //Limpiar todos los campos
            btnLimpiar.PerformClick();
            btnCancelar.Enabled = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //Confirmar la baja del preventista
            var result = MessageBox.Show("¿Está seguro que desea dar de baja el preventista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                //Mostrar mensaje de éxito
                MessageBox.Show("Preventista dado de baja con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiar todos los campos con el btnLimpiar
                btnLimpiar.PerformClick();
                //Activar btnCrear
                btnCrear.Enabled = true;
                btnVolver.Enabled = true;
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }
    }
}
