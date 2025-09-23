using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.Preventista
{
    public partial class FormRutas : Form
    {
        // Declarar controles
        private Label lblPreventista;
        private Button btnGenerarRuta;
        private Button btnLimpiarRuta;
        private DataGridView dgvRuta;
        private Panel panelMapa;
        private Label lblTotalClientes, lblDistanciaTotal, lblTiempoEstimado;

        public FormRutas()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarDatosPreventista(); // Cargar datos del preventista actual
        }

        private void ConfigurarFormulario()
        {
            // Configuración del formulario
            this.Size = new Size(1264, 569);
            this.Text = "Panel de Rutas";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // **1. PANEL DE TÍTULO**
            Panel panelTitulo = new Panel();
            panelTitulo.Height = 70;
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.BackColor = Color.LightSteelBlue;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Panel de Rutas";
            lblTitulo.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Fill;
            panelTitulo.Controls.Add(lblTitulo);

            // **2. PANEL INFO PREVENTISTA**
            Panel panelInfo = new Panel();
            panelInfo.Height = 60;
            panelInfo.Dock = DockStyle.Top;
            panelInfo.BackColor = Color.White;

            lblPreventista = new Label();
            lblPreventista.Text = "Preventista: [Cargando...]";
            lblPreventista.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPreventista.ForeColor = Color.MediumPurple;
            lblPreventista.Location = new Point(20, 20);
            lblPreventista.Size = new Size(400, 25);

            btnGenerarRuta = CrearBoton("Generar Ruta Óptima", new Point(450, 15), new Size(160, 35), Color.LightSteelBlue);
            btnGenerarRuta.Click += BtnGenerarRuta_Click;

            btnLimpiarRuta = CrearBoton("Limpiar", new Point(620, 15), new Size(100, 35), Color.Thistle);
            btnLimpiarRuta.Click += BtnLimpiarRuta_Click;

            panelInfo.Controls.Add(lblPreventista);
            panelInfo.Controls.Add(btnGenerarRuta);
            panelInfo.Controls.Add(btnLimpiarRuta);

            // **3. PANEL PRINCIPAL**
            Panel panelPrincipal = new Panel();
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.BackColor = Color.White;

            // 3.1 DataGridView
            GroupBox gbRuta = new GroupBox();
            gbRuta.Text = "Ruta Generada";
            gbRuta.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            gbRuta.Location = new Point(20, 20);
            gbRuta.Size = new Size(720, 350);
            gbRuta.BackColor = Color.White;
            gbRuta.Dock = DockStyle.Left;

            dgvRuta = new DataGridView();
            dgvRuta.Location = new Point(10, 25);
            dgvRuta.Size = new Size(700, 315);
            dgvRuta.AllowUserToAddRows = false;
            dgvRuta.AllowUserToDeleteRows = false;
            dgvRuta.ReadOnly = true;
            dgvRuta.Dock = DockStyle.Fill;
            dgvRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuta.BackgroundColor = Color.White;
            dgvRuta.BorderStyle = BorderStyle.Fixed3D;

            dgvRuta.Columns.Add("Orden", "Orden");
            dgvRuta.Columns.Add("Cliente", "Cliente");
            dgvRuta.Columns.Add("Direccion", "Dirección");
            dgvRuta.Columns.Add("Telefono", "Teléfono");
            dgvRuta.Columns.Add("Observaciones", "Observaciones");

            dgvRuta.Columns["Orden"].Width = 60;
            dgvRuta.Columns["Cliente"].Width = 180;
            dgvRuta.Columns["Direccion"].Width = 220;
            dgvRuta.Columns["Telefono"].Width = 120;
            dgvRuta.Columns["Observaciones"].Width = 120;

            dgvRuta.Columns["Orden"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRuta.Columns["Orden"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            gbRuta.Controls.Add(dgvRuta);

            // 3.2 Mapa
            GroupBox gbMapa = new GroupBox();
            gbMapa.Text = "Visualización de Ruta";
            gbMapa.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            gbMapa.Location = new Point(760, 20);
            gbMapa.Size = new Size(480, 250);
            gbMapa.BackColor = Color.White;

            panelMapa = new Panel();
            panelMapa.Location = new Point(10, 25);
            panelMapa.Size = new Size(460, 215);
            panelMapa.BackColor = Color.WhiteSmoke;
            panelMapa.BorderStyle = BorderStyle.FixedSingle;

            Label lblMapaPlaceholder = new Label();
            lblMapaPlaceholder.Text = "Mapa de Ruta\n(Aquí se mostrará el mapa visual)";
            lblMapaPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            lblMapaPlaceholder.Dock = DockStyle.Fill;
            lblMapaPlaceholder.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lblMapaPlaceholder.ForeColor = Color.Gray;
            panelMapa.Controls.Add(lblMapaPlaceholder);

            gbMapa.Controls.Add(panelMapa);

            // 3.3 Estadísticas
            GroupBox gbEstadisticas = new GroupBox();
            gbEstadisticas.Text = "Resumen de Ruta";
            gbEstadisticas.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            gbEstadisticas.Location = new Point(760, 280);
            gbEstadisticas.Size = new Size(480, 120);
            gbEstadisticas.BackColor = Color.White;

            lblTotalClientes = new Label();
            lblTotalClientes.Text = "Total de Clientes: 0";
            lblTotalClientes.Location = new Point(20, 30);
            lblTotalClientes.Size = new Size(200, 25);
            lblTotalClientes.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblDistanciaTotal = new Label();
            lblDistanciaTotal.Text = "Distancia Estimada: 0 km";
            lblDistanciaTotal.Location = new Point(20, 55);
            lblDistanciaTotal.Size = new Size(200, 25);
            lblDistanciaTotal.Font = new Font("Segoe UI", 10);

            lblTiempoEstimado = new Label();
            lblTiempoEstimado.Text = "Tiempo Estimado: 0 min";
            lblTiempoEstimado.Location = new Point(20, 80);
            lblTiempoEstimado.Size = new Size(200, 25);
            lblTiempoEstimado.Font = new Font("Segoe UI", 10);

            gbEstadisticas.Controls.Add(lblTotalClientes);
            gbEstadisticas.Controls.Add(lblDistanciaTotal);
            gbEstadisticas.Controls.Add(lblTiempoEstimado);

            panelPrincipal.Controls.Add(gbRuta);
            panelPrincipal.Controls.Add(gbMapa);
            panelPrincipal.Controls.Add(gbEstadisticas);

            // **4. PANEL BOTONES INFERIOR**
            Panel panelBotones = new Panel();
            panelBotones.Height = 50;
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.BackColor = Color.WhiteSmoke;

            Button btnExportar = CrearBoton("Exportar Ruta", new Point(20, 10), new Size(120, 30), Color.LightSteelBlue);
            btnExportar.Click += BtnExportar_Click;

            Button btnImprimir = CrearBoton("Imprimir", new Point(150, 10), new Size(100, 30), Color.Thistle);
            btnImprimir.Click += BtnImprimir_Click;

            panelBotones.Controls.Add(btnExportar);
            panelBotones.Controls.Add(btnImprimir);

            // Agregar al formulario
            this.Controls.Add(panelPrincipal);
            this.Controls.Add(panelBotones);
            this.Controls.Add(panelInfo);
            this.Controls.Add(panelTitulo);
        }

        // Método para crear botones lindos
        private Button CrearBoton(string texto, Point loc, Size tam, Color colorFondo)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.Location = loc;
            btn.Size = tam;
            btn.BackColor = colorFondo;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            return btn;
        }


        private void CargarDatosPreventista()
        {
            // Aquí cargarías los datos del preventista actual desde la sesión
            // Por ejemplo:
            // string nombrePreventista = SesionActual.NombreUsuario;
            // string zona = SesionActual.Zona;

            // Por ahora, datos de ejemplo:
            lblPreventista.Text = "Preventista: Juan Pérez - Zona Norte";
        }


        private void GenerarRutaOptima()
        {
            // Limpiar datos anteriores
            dgvRuta.Rows.Clear();

            // Aquí conectarías con la base de datos para obtener los clientes del preventista
            // Por ahora, datos de ejemplo:
            string[,] clientesEjemplo = {
                {"1", "Supermercado Central", "Av. San Martín 1234", "4567-8901", "Pedido urgente"},
                {"2", "Farmacia del Pueblo", "Calle Belgrano 567", "4567-8902", "Entrega matutina"},
                {"3", "Kiosco La Esquina", "Av. Rivadavia 890", "4567-8903", "Cliente frecuente"},
                {"4", "Almacén Don José", "Calle Mitre 345", "4567-8904", "Pago contado"},
                {"5", "Panadería El Trigo", "Av. Corrientes 678", "4567-8905", "Entrega temprana"}
            };

            // Agregar filas al DataGridView
            for (int i = 0; i < clientesEjemplo.GetLength(0); i++)
            {
                dgvRuta.Rows.Add(
                    clientesEjemplo[i, 0],
                    clientesEjemplo[i, 1],
                    clientesEjemplo[i, 2],
                    clientesEjemplo[i, 3],
                    clientesEjemplo[i, 4]
                );
            }

            // Actualizar estadísticas
            ActualizarEstadisticas(5, 25.5, 180);
        }

        private void ActualizarEstadisticas(int totalClientes, double distancia, int tiempo)
        {
            lblTotalClientes.Text = $"Total de Clientes: {totalClientes}";
            lblDistanciaTotal.Text = $"Distancia Estimada: {distancia} km";
            lblTiempoEstimado.Text = $"Tiempo Estimado: {tiempo} min";
        }


        // Métodos de eventos (agregar al final de tu clase)
        private void BtnGenerarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarRutaOptima();
                MessageBox.Show("Ruta generada correctamente", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar ruta: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiarRuta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea limpiar la ruta?",
                                                 "Confirmar", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgvRuta.Rows.Clear();
                ActualizarEstadisticas(0, 0, 0);
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (dgvRuta.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí implementarías la exportación (Excel, PDF, etc.)
            MessageBox.Show("Funcionalidad de exportación pendiente", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvRuta.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí implementarías la impresión
            MessageBox.Show("Funcionalidad de impresión pendiente", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}