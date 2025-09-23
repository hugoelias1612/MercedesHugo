using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class FormABM : Form
    {

        private ErrorProvider errorProvider1; // <-- Agregar esta línea

        public FormABM()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            errorProvider1.ContainerControl = this;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
         
        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox con un valor por defecto
            cbxFamilia.Items.Insert(0, "Seleccione familia");
            cbxFamilia.SelectedIndex = 0;

            cbxProveedor.Items.Insert(0, "Seleccione proveedor");
            cbxProveedor.SelectedIndex = 0;

            cbxMarca.Items.Insert(0, "Seleccione marca");
            cbxMarca.SelectedIndex = 0;

            nudUPB.Value = 0;
            nudBultosIniciales.Value = 0;
            nudUnidadesIniciales.Value = 0;

            PAlta.Visible = true;
            PBaja.Visible = false;
            PModificacion.Visible = false;
        }

        // KeyPress para Nombre: solo letras y espacios, mayúscula inicial
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length == 0 && char.IsLower(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombre, "Solo se permiten letras y espacios.");
            }
            else if (!char.IsControl(e.KeyChar) && txtNombre.Text.Length >= 30)
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombre, "El nombre no debe exceder 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
                e.Cancel = true;
            }
            else if (txtNombre.Text.Length < 2)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener al menos 2 caracteres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        // KeyPress para Precio Unit: solo números y coma decimal
        private void txtPrecioUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                errorProvider1.SetError(txtPrecioUnit, "Solo se permiten números y coma decimal.");
            }
            else
            {
                errorProvider1.SetError(txtPrecioUnit, "");
            }
        }

        private void txtPrecioUnit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioUnit.Text))
            {
                errorProvider1.SetError(txtPrecioUnit, "El precio unitario es obligatorio.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrecioUnit, "");
            }
        }

        private void numericUpDownUnidadesPorBulto_Validating(object sender, CancelEventArgs e)
        {
            if (nudUPB.Value <= 0)
            {
                errorProvider1.SetError(nudUPB, "Las unidades por bulto son obligatorias.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudUPB, "");
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cbxFamilia.SelectedIndex == 0 ||
                cbxProveedor.SelectedIndex == 0 ||
                cbxMarca.SelectedIndex == 0 ||
                string.IsNullOrWhiteSpace(txtPrecioUnit.Text) ||
                nudUPB.Value <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("Producto validado correctamente. Todos los campos obligatorios están completos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecioUnit.Clear();

            cbxFamilia.SelectedIndex = 0;
            cbxProveedor.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;

            nudUPB.Value = 0;
            nudBultosIniciales.Value = 0;
            nudUnidadesIniciales.Value = 0;

            errorProvider1.Clear();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            // Mostrar panel de Alta y ocultar los otros
            PAlta.Visible = true;
            PBaja.Visible = false;
            PModificacion.Visible = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            // Mostrar panel de Baja y ocultar los otros
            PAlta.Visible = false;
            PBaja.Visible = true;
            PModificacion.Visible = false;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            // Mostrar panel de Modificación y ocultar los otros
            PAlta.Visible = false;
            PBaja.Visible = false;
            PModificacion.Visible = true;
        }

        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
