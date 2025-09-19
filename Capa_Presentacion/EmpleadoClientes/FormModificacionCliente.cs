using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Logica;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormModificacionCliente : Form
        
    {
        private ClassClienteLogica clienteLogica = new ClassClienteLogica();
        public FormModificacionCliente()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEdicion()
        {
            if (dataGridListarClientes.CurrentRow != null)
            {
                DataGridViewRow fila = dataGridListarClientes.CurrentRow;

                CLIENTE clienteSeleccionado = new CLIENTE
                {
                    id_cliente = Convert.ToInt32(fila.Cells["id_cliente"].Value),
                    dni = Convert.ToInt32(fila.Cells["dni"].Value),
                    nombre = fila.Cells["nombre"].Value?.ToString(),
                    apellido = fila.Cells["apellido"].Value?.ToString(),
                    telefono = Convert.ToInt64(fila.Cells["telefono"].Value),
                    email = fila.Cells["email"].Value?.ToString(),
                    razon_social = fila.Cells["razon_social"].Value?.ToString(),
                    cuil_cuit = Convert.ToInt64(fila.Cells["cuil_cuit"].Value),
                    fecha_alta = Convert.ToDateTime(fila.Cells["fecha_alta"].Value),
                    estado = fila.Cells["estado"].Value?.ToString() == "Activo",
                    confiable = fila.Cells["confiable"].Value?.ToString() == "Si",
                    condicion_frenteIVA = fila.Cells["condicion_frenteIVA"].Value?.ToString(),
                    calle = fila.Cells["calle"].Value?.ToString(),
                    numero = Convert.ToInt32(fila.Cells["numero"].Value),
                    ciudad = fila.Cells["ciudad"].Value?.ToString(),
                    provincia = fila.Cells["provincia"].Value?.ToString(),
                    cod_postal = Convert.ToInt32(fila.Cells["cod_postal"].Value),
                    id_tamano = clienteLogica.ObtenerTamanos()
        .FirstOrDefault(t => t.descripcion == fila.Cells["id_tamano"].Value?.ToString())?.id_tamano ?? 0,
                    id_zona = clienteLogica.ObtenerZonas()
        .FirstOrDefault(z => z.nombre == fila.Cells["id_zona"].Value?.ToString())?.id_zona ?? 0
               

            };

                FormEditarCliente formEditarCliente = new FormEditarCliente(clienteSeleccionado);
                formEditarCliente.ShowDialog();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    AbrirFormularioEdicion();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridListarClientes.CurrentRow != null)
            {

                AbrirFormularioEdicion();
                e.SuppressKeyPress = true;
            }
        }

        private void FormModificacionCliente_Load(object sender, EventArgs e)
        {
            //configurar la coleccion de columnas del data grid segun la tabla cliente
            dataGridListarClientes.Columns.Clear();
            dataGridListarClientes.Columns.Add("id_cliente", "ID");
            dataGridListarClientes.Columns.Add("dni", "DNI");
            dataGridListarClientes.Columns.Add("nombre", "Nombre");
            dataGridListarClientes.Columns.Add("apellido", "Apellido");
            dataGridListarClientes.Columns.Add("telefono", "Teléfono");
            dataGridListarClientes.Columns.Add("email", "Email");
            dataGridListarClientes.Columns.Add("razon_social", "Razón Social");
            dataGridListarClientes.Columns.Add("cuil_cuit", "CUIL/CUIT");
            dataGridListarClientes.Columns.Add("fecha_alta", "Fecha de Alta");
            dataGridListarClientes.Columns.Add("estado", "Estado");
            dataGridListarClientes.Columns.Add("confiable", "Confiable");
            dataGridListarClientes.Columns.Add("condicion_frenteIVA", "Condición frente al IVA");
            dataGridListarClientes.Columns.Add("calle", "Calle");
            dataGridListarClientes.Columns.Add("numero", "Número");
            dataGridListarClientes.Columns.Add("ciudad", "Ciudad");
            dataGridListarClientes.Columns.Add("provincia", "Provincia");
            dataGridListarClientes.Columns.Add("cod_postal", "Código Postal");
            dataGridListarClientes.Columns.Add("id_tamano", "Tamaño");
            dataGridListarClientes.Columns.Add("id_zona", "Zona");
            dataGridListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridListarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridListarClientes.MultiSelect = false;
            dataGridListarClientes.ReadOnly = true;
            dataGridListarClientes.AllowUserToAddRows = false;
            //agregar clientes desde tabla cliente
            List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
            var zonas = clienteLogica.ObtenerZonas();
            var tamanos = clienteLogica.ObtenerTamanos();

            foreach (var cliente in listaClientes)
            {
                string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                string confiableTexto = cliente.confiable ? "Si" : "No";
                // Buscar nombre de zona
                string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";

                // Buscar nombre de tamaño
                string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                dataGridListarClientes.Rows.Add(cliente.id_cliente, cliente.dni, cliente.nombre, cliente.apellido, cliente.telefono, cliente.email, cliente.razon_social, cliente.cuil_cuit, cliente.fecha_alta, estadoTexto, confiableTexto, cliente.condicion_frenteIVA, cliente.calle, cliente.numero, cliente.ciudad, cliente.provincia, cliente.cod_postal, nombreTamano, nombreZona);
            }
            //CARGAR COMBOBOX ZONA
            
            comboBoxBuscarClienteZona.Items.Clear();
            comboBoxBuscarClienteZona.Items.Add("Seleccione zona");
            foreach (var zona in zonas)
            {
                string nombre = $"{zona.id_zona} - {zona.nombre}";
                comboBoxBuscarClienteZona.Items.Add(nombre);
            }
            comboBoxBuscarClienteZona.SelectedIndex = 0;



        }

        private void txtNombreApellido_KeyDown(object sender, KeyEventArgs e)
        {
            //validar que se ingresaron letras y espacios
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && !char.IsLetter((char)e.KeyValue) && e.KeyCode != Keys.Space)
            {
                MessageBox.Show("Por favor, ingrese solo letras y espacios para el nombre o apellido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.SuppressKeyPress = true; // evita que el carácter no válido se ingrese en el TextBox
                return;
            }
            //al presionar enter buscar por nombre o por apellido
            if (e.KeyCode == Keys.Enter)
            {
                //
                string filtro = txtNombreApellido.Text.ToLower();
                foreach (DataGridViewRow row in dataGridListarClientes.Rows)
                {
                    string nombre = row.Cells["nombre"].Value?.ToString().ToLower() ?? "";
                    string apellido = row.Cells["apellido"].Value?.ToString().ToLower() ?? "";
                    if (nombre.Contains(filtro) || apellido.Contains(filtro))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                e.SuppressKeyPress = true; // evita el sonido de alerta
            }
        }

        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {
            //Validar que se ingresaron valores numericos
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtBuscarDni.Text))
                {
                    if (!long.TryParse(txtBuscarDni.Text, out _))
                    {
                        MessageBox.Show("Por favor, ingrese solo valores numéricos para el DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarDni.Clear();
                        return;
                    }
                }
                string filtro = txtBuscarDni.Text.ToLower();
                foreach (DataGridViewRow row in dataGridListarClientes.Rows)
                {
                    string dni = row.Cells["dni"].Value?.ToString().ToLower() ?? "";
                    if (dni.Contains(filtro))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                e.SuppressKeyPress = true; // evita el sonido de alerta
            }

        }

        private void txtBusacarEmail_KeyDown(object sender, KeyEventArgs e)
        {
            //validar que se ingresa un email
            if (e.KeyCode == Keys.Enter)
            {
                string filtro = txtBusacarEmail.Text.ToLower();
                foreach (DataGridViewRow row in dataGridListarClientes.Rows)
                {
                    string email = row.Cells["email"].Value?.ToString().ToLower() ?? "";
                    if (email.Contains(filtro))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                e.SuppressKeyPress = true; // evita el sonido de alerta
            }
        }

        private void comboBoxBuscarClienteZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validar una seleccion de la tabla zona
            if (comboBoxBuscarClienteZona.SelectedIndex > 0)
            {
                string selectedZona = comboBoxBuscarClienteZona.SelectedItem.ToString();
                int idZona = int.Parse(selectedZona.Split('-')[0].Trim());
                foreach (DataGridViewRow row in dataGridListarClientes.Rows)
                {
                    if (row.Cells["id_zona"].Value != null && (int)row.Cells["id_zona"].Value == idZona)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                // Si se selecciona "Seleccione zona", mostrar todas las filas
                foreach (DataGridViewRow row in dataGridListarClientes.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void textBoxBUSCARGENERAL_TextChanged(object sender, EventArgs e)
        {
            //busqueda general en todas las columnas
            string filtro = textBoxBUSCARGENERAL.Text.ToLower();
            foreach (DataGridViewRow row in dataGridListarClientes.Rows)
            {
                bool filaVisible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filtro))
                    {
                        filaVisible = true;
                        break;
                    }
                }
                row.Visible = filaVisible;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //salir del form
            Close();
        }
    }
}