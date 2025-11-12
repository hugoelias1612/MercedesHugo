using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Logica;

namespace ArimaERP.Preventista
{
    public partial class ModalSeleccionarCliente : Form
    {
        private readonly ClassClienteLogica _clienteLogica = new ClassClienteLogica();
        private List<ZONA> _zonas = new List<ZONA>();
        private List<CLIENTE> _clientesZona = new List<CLIENTE>();
        private List<TAMAÑO_NEGOCIO> _tamanos = new List<TAMAÑO_NEGOCIO>();

        public CLIENTE ClienteSeleccionado { get; private set; }
        public ZONA ZonaSeleccionada { get; private set; }

        public ModalSeleccionarCliente()
        {
            InitializeComponent();
            Load += ModalSeleccionarCliente_Load;
            cbxZona.SelectedIndexChanged += CbxZona_SelectedIndexChanged;
            cbxCliente.SelectedIndexChanged += CbxCliente_SelectedIndexChanged;
        }

        private void ModalSeleccionarCliente_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                _zonas = _clienteLogica.ObtenerZonas() ?? new List<ZONA>();
                _tamanos = _clienteLogica.ObtenerTamanos() ?? new List<TAMAÑO_NEGOCIO>();

                cbxZona.DataSource = _zonas
                    .OrderBy(z => z.nombre)
                    .ToList();
                cbxZona.DisplayMember = nameof(ZONA.nombre);
                cbxZona.ValueMember = nameof(ZONA.id_zona);
                cbxZona.SelectedIndex = -1;
                cbxZona.Text = "Seleccione una zona";

                cbxCliente.DataSource = null;
                cbxCliente.Items.Clear();
                cbxCliente.Text = "Seleccione un cliente";

                ClienteSeleccionado = null;
                ZonaSeleccionada = null;
                LimpiarDetallesCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CbxZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxZona.SelectedItem is ZONA zona)
            {
                ZonaSeleccionada = zona;
                CargarClientesDeZona(zona.id_zona);
            }
            else
            {
                ZonaSeleccionada = null;
                cbxCliente.DataSource = null;
                cbxCliente.Items.Clear();
                cbxCliente.Text = "Seleccione un cliente";
                ClienteSeleccionado = null;
                LimpiarDetallesCliente();
            }
        }

        private void CargarClientesDeZona(int idZona)
        {
            _clientesZona = _clienteLogica.ClientesPorZona(idZona) ?? new List<CLIENTE>();

            var clientesCombo = _clientesZona
                .OrderBy(c => c.nombre)
                .ThenBy(c => c.apellido)
                .Select(c => new ClienteComboItem(c.id_cliente, $"{c.nombre} {c.apellido}".Trim()))
                .ToList();

            cbxCliente.SelectedIndexChanged -= CbxCliente_SelectedIndexChanged;
            try
            {
                cbxCliente.DataSource = clientesCombo;
                cbxCliente.DisplayMember = nameof(ClienteComboItem.Descripcion);
                cbxCliente.ValueMember = nameof(ClienteComboItem.Id);
                cbxCliente.SelectedIndex = -1;
                cbxCliente.Text = clientesCombo.Any() ? "Seleccione un cliente" : "Sin clientes disponibles";
            }
            finally
            {
                cbxCliente.SelectedIndexChanged += CbxCliente_SelectedIndexChanged;
            }

            ClienteSeleccionado = null;
            LimpiarDetallesCliente();
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedValue is int idCliente)
            {
                ClienteSeleccionado = _clientesZona.FirstOrDefault(c => c.id_cliente == idCliente);
                MostrarDetallesCliente();
            }
            else
            {
                ClienteSeleccionado = null;
                LimpiarDetallesCliente();
            }
        }

        private void MostrarDetallesCliente()
        {
            if (ClienteSeleccionado == null)
            {
                LimpiarDetallesCliente();
                return;
            }

            var tamano = _tamanos.FirstOrDefault(t => t.id_tamano == ClienteSeleccionado.id_tamano)?.descripcion ?? "No especificado";

            lblNombre.Text = $"Nombre: {ClienteSeleccionado.nombre} {ClienteSeleccionado.apellido}".Trim();
            lblDni.Text = $"DNI: {ClienteSeleccionado.dni}";
            lblTelefono.Text = $"Teléfono: {ClienteSeleccionado.telefono}";
            lblTamaño.Text = $"Tamaño: {tamano}";
            lblCalle.Text = $"Calle: {ClienteSeleccionado.calle}";
            lblNumero.Text = $"Número: {ClienteSeleccionado.numero}";
            lblConfiable.Text = $"Confiable: {(ClienteSeleccionado.confiable ? "Sí" : "No")}";
            lblEmail.Text = $"Email: {ClienteSeleccionado.email}";
        }

        private void LimpiarDetallesCliente()
        {
            lblNombre.Text = "Nombre: -";
            lblDni.Text = "DNI: -";
            lblTelefono.Text = "Teléfono: -";
            lblTamaño.Text = "Tamaño: -";
            lblCalle.Text = "Calle: -";
            lblNumero.Text = "Número: -";
            lblConfiable.Text = "Confiable: -";
            lblEmail.Text = "Email: -";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un cliente antes de confirmar.",
                    "Selección requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (ZonaSeleccionada == null && cbxZona.SelectedItem is ZONA zona)
            {
                ZonaSeleccionada = zona;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private sealed class ClienteComboItem
        {
            public ClienteComboItem(int id, string descripcion)
            {
                Id = id;
                Descripcion = descripcion;
            }

            public int Id { get; }
            public string Descripcion { get; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
