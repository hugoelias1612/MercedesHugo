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
    public partial class FormRegistrarUsuario : Form
    {
        
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            //activar btnModificar y btnBaja
            btnModificar.Enabled = true;
            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
            //desactivar btnNuevo
            btnCrear.Enabled = false;
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permitir espacios en blanco
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxUsuario, "No se permiten espacios en blanco.");
            }
            else
            {
                errorProvider1.SetError(textBoxUsuario, "");
            }
            // No permitir más de 20 caracteres
            if (textBoxUsuario.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxUsuario, "No se permiten más de 20 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxUsuario, "");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //habilitar btnNuevo
            btnCrear.Enabled = true;
            //deshabilitar btnModificar y btnBaja
            btnModificar.Enabled = false;
            btnBaja.Enabled = false;
            btnCancelar.Enabled = false;
            //limpiar campos
            btnLimpiar.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cerrar formulario
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //solicitar confirmación
            var result = MessageBox.Show("¿Está seguro que desea dar de baja este usuario?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //dar de baja usuario
                MessageBox.Show("Usuario dado de baja con éxito.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //habilitar btnNuevo
                btnCrear.Enabled = true;
                //deshabilitar btnModificar y btnBaja
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
                btnCancelar.Enabled = false;
                //limpiar campos
                btnLimpiar.PerformClick();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //validar que no haya errores en los campos
            if (errorProvider1.GetError(textBoxUsuario) == "" &&
                errorProvider1.GetError(textBoxContrasena) == "" &&
                errorProvider1.GetError(textBoxNombre) == "" &&
                errorProvider1.GetError(textBoxApellido) == "" &&
                errorProvider1.GetError(textBoxMail) == "" &&
                errorProvider1.GetError(textBoxDireccion) == "" &&
                errorProvider1.GetError(textBoxDNI) == "" &&
                errorProvider1.GetError(textBoxTelefono) == "")
            {
                //validar que no haya campos vacíos y que se seleccionó un rol
                if (textBoxUsuario.Text != "" &&
                    textBoxContrasena.Text != "" &&
                    textBoxNombre.Text != "" &&
                    textBoxApellido.Text != "" &&
                    textBoxMail.Text != "" &&
                    textBoxDireccion.Text != "" &&
                    textBoxDNI.Text != "" &&
                    textBoxTelefono.Text != "" && comboBoxRol.SelectedIndex > 0)
                {
                    //crear usuario
                    MessageBox.Show("Usuario creado con éxito.", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos
                    btnLimpiar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, corrija los errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBoxMail_Validated(object sender, EventArgs e)
        {
            // Validar formato de email
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBoxMail.Text);
                if (addr.Address != textBoxMail.Text)
                {
                    errorProvider1.SetError(textBoxMail, "Formato de email inválido.");
                }
                else
                {
                    errorProvider1.SetError(textBoxMail, "");
                }
            }
            catch
            {
                if (!string.IsNullOrWhiteSpace(textBoxMail.Text))
                {
                    errorProvider1.SetError(textBoxMail, "Formato de email inválido.");
                }
                else
                {
                    errorProvider1.SetError(textBoxMail, "");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            //limpiar todos los campos y reiniciar comboBox
            textBoxUsuario.Clear(); 
            textBoxContrasena.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxMail.Clear();
            textBoxDireccion.Clear();
            textBoxDNI.Clear();
            textBoxTelefono.Clear();
            comboBoxRol.SelectedIndex = -1;
            //limpiar errores
            errorProvider1.Clear();

        }
    }
}
