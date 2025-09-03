using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
           

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void txtRubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRubro_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelFijoCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblProvincia_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoFactura_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefonoFijo_Click(object sender, EventArgs e)
        {

        }

        private void txtBarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelMovilCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Permitir letras, espacio y teclas de control
            if (char.IsLetter(c) || char.IsControl(c) || c == ' ')
            {
                errorProvider1.SetError(txtNombre, ""); // Limpiar error si el carácter es válido
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras y espacios");
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Permitir letras, espacio y teclas de control
            if (char.IsLetter(c) || char.IsControl(c) || c == ' ')
            {
                errorProvider2.SetError(txtApellido, ""); // Limpiar error si el carácter es válido
                e.Handled = false;
            }
            else
            {
                errorProvider2.SetError(txtApellido, "Solo se permiten letras y espacios");
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Aceptar el carácter
            }
            else
            {
                e.Handled = true; // Bloquear el carácter
                errorProvider3.SetError(txtDNI, "Solo se permiten números en el DNI");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // Expresión regular básica para validar formato de email
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider4.SetError(txtEmail, "");
                return; // Permite salir sin validar formato
            }
            else if (!regex.IsMatch(email))
            {
                errorProvider4.SetError(txtEmail, "Formato de email inválido. Ej: usuario@dominio.com");
                e.Cancel = true;
            }
            else
            {
                errorProvider4.SetError(txtEmail, ""); // Limpia el error si es válido
            }
        }

        private void comboBoxCondicionIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Aceptar el carácter
            }
            else
            {
                e.Handled = true; // Bloquear el carácter
                errorProvider5.SetError(textBox4, "Solo se permiten números");
            }
        }
    }
}
