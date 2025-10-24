using Capa_Entidades;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class FormABM : Form
    {
        private ErrorProvider errorProvider;
        private readonly ClassFamiliaLogica _familiaLogica = new ClassFamiliaLogica();
        private readonly ClassProductoLogica _productoLogica = new ClassProductoLogica();
        private readonly Dictionary<int, (int desde, int hasta)> _rangosPresentacion =
            new Dictionary<int, (int desde, int hasta)>
            {
                { 3, (1, 10) },   // Lácteos
                { 2, (11, 20) },  // Bebidas
                { 5, (21, 30) },  // Bebidas alcohólicas
                { 1, (31, 40) },  // Comidas / Alimentos
                { 7, (41, 50) },  // Pilas - Velas - Encendedores
                { 4, (51, 60) },  // Higiene personal
                { 6, (61, 70) }   // Cuidado doméstico
            };

        public FormABM()
        {
            InitializeComponent();

            // Inicialización del ErrorProvider
            errorProvider = new ErrorProvider
            {
                ContainerControl = this,
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };
            this.Load += new System.EventHandler(this.FormABM_Load);
            cbxFamilia.SelectedIndexChanged += cbxFamilia_SelectedIndexChanged;
        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            CargarFamilias();

            // Inicializar ComboBoxes que aún no se integran con la base
            cbxProveedor.Items.Insert(0, "Seleccione proveedor");
            cbxProveedor.SelectedIndex = 0;

            cbxMarca.Items.Insert(0, "Seleccione marca");
            cbxMarca.SelectedIndex = 0;

            LimpiarPresentaciones();

            // Inicializar NumericUpDown
            nudUPB.Value = 0;
            nudBultosIniciales.Value = 0;
            nudUnidadesIniciales.Value = 0;

            // Mostrar panel Alta por defecto
            PAlta.Visible = true;
            PBaja.Visible = false;
            PModificacion.Visible = false;
        }

        // Validar que Nombre solo contenga letras y espacios
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
                errorProvider1.SetError(nudUPB, "");
    }
}

private void btnCrearProducto_Click(object sender, EventArgs e)
{
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

    MessageBox.Show("Producto validado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

private void btnLimpiarCampos_Click(object sender, EventArgs e)
{
    txtNombre.Clear();
    txtPrecioUnit.Clear();

    if (cbxFamilia.Items.Count > 0)
    {
        cbxFamilia.SelectedIndex = 0;
    }
    cbxProveedor.SelectedIndex = 0;
    cbxMarca.SelectedIndex = 0;

    LimpiarPresentaciones();

    nudUPB.Value = 0;
    nudBultosIniciales.Value = 0;
    nudUnidadesIniciales.Value = 0;

    errorProvider1.Clear();
}

private void btnAlta_Click(object sender, EventArgs e)
{
    PAlta.Visible = true;
    PBaja.Visible = false;
    PModificacion.Visible = false;
}

private void btnBaja_Click(object sender, EventArgs e)
{
    PAlta.Visible = false;
    PBaja.Visible = true;
    PModificacion.Visible = false;
}

private void btnModificacion_Click(object sender, EventArgs e)
{
    PAlta.Visible = false;
    PBaja.Visible = false;
}


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
{
    // Lógica adicional si se necesita
}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    // Acción al hacer clic en una celda
}

private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
{
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

private void CargarFamilias()
{
    var familias = _familiaLogica.ObtenerTodasLasFamilias() ?? new List<FAMILIA>();

    if (familias.Count == 0 && _familiaLogica.ErroresValidacion.Any())
    {
        MessageBox.Show(
            string.Join(Environment.NewLine, _familiaLogica.ErroresValidacion),
            "Error al cargar familias",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }

    var familiasConPlaceholder = new List<FAMILIA>
            {
                new FAMILIA { id_familia = 0, descripcion = "Seleccione familia" }
            };
    familiasConPlaceholder.AddRange(familias.OrderBy(f => f.descripcion));

    cbxFamilia.SelectedIndexChanged -= cbxFamilia_SelectedIndexChanged;
    cbxFamilia.DataSource = familiasConPlaceholder;
    cbxFamilia.DisplayMember = nameof(FAMILIA.descripcion);
    cbxFamilia.ValueMember = nameof(FAMILIA.id_familia);
    cbxFamilia.SelectedIndex = 0;
    cbxFamilia.SelectedIndexChanged += cbxFamilia_SelectedIndexChanged;
}

private void cbxFamilia_SelectedIndexChanged(object sender, EventArgs e)
{
    if (!(cbxFamilia.SelectedValue is int familiaId) || familiaId == 0)
    {
        LimpiarPresentaciones();
        return;
    }

    if (!_rangosPresentacion.TryGetValue(familiaId, out var rango))
    {
        LimpiarPresentaciones();
        return;
    }

    var presentaciones = _productoLogica.ObtenerPresentacionesPorRango(rango.desde, rango.hasta) ?? new List<PRESENTACION>();

    if (presentaciones.Count == 0 && _productoLogica.ErroresValidacion.Any())
    {
        MessageBox.Show(
            string.Join(Environment.NewLine, _productoLogica.ErroresValidacion),
            "Error al cargar presentaciones",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        LimpiarPresentaciones();
        return;
    }

    var presentacionesConPlaceholder = new List<PRESENTACION>
            {
                new PRESENTACION { ID_presentacion = 0, descripcion = "Seleccione presentación" }
            };
    presentacionesConPlaceholder.AddRange(presentaciones.OrderBy(p => p.descripcion));

    cbxPresentacion.DataSource = presentacionesConPlaceholder;
    cbxPresentacion.DisplayMember = nameof(PRESENTACION.descripcion);
    cbxPresentacion.ValueMember = nameof(PRESENTACION.ID_presentacion);
    cbxPresentacion.SelectedIndex = 0;
    cbxPresentacion.Enabled = true;
}

private void LimpiarPresentaciones()
{
    cbxPresentacion.DataSource = null;
    cbxPresentacion.Items.Clear();
    cbxPresentacion.Items.Insert(0, "Seleccione presentación");
    cbxPresentacion.SelectedIndex = 0;
    cbxPresentacion.Enabled = false;
}

private void textBoxCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
{

}
    }
}

