using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using System.Diagnostics.Eventing.Reader;

namespace ArimaERP.EmpleadoClientes
{
    public partial class FormClienteHistorial : Form

    {
        ClassClienteLogica clienteLogica = new ClassClienteLogica();
        private bool cargandoFormulario = true;
        private ClassUsuarioLogica usuarios = new ClassUsuarioLogica();
        private ClassEmpleadoLogica empleado = new ClassEmpleadoLogica();
        private ClassZonaLogica zona = new ClassZonaLogica();
        public FormClienteHistorial()
        {
            InitializeComponent();
        }              

        private void btnListarPagos_Click(object sender, EventArgs e)
        {
            //Visualizar dataGridViewDetallePagos
            
        }

        private void btnListarPedidosPendientes_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPedidosEntregados_Click(object sender, EventArgs e)
        {
            //visualizar dataGridViewVerPedidos
            
        }

        private void btnListarSaldosPendientes_Click(object sender, EventArgs e)
        {
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar formulario
            this.Close();
        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo letras y espacios en blanco y control (backspace) y limitar a 30 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreApellido, "Solo se permiten letras y espacios en blanco");
            }
            else if (txtNombreApellido.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreApellido, "No se permiten mas de 30 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtNombreApellido, "");
            }
        }

        private void txtBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros y control (backspace) y limitar a 8 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuscarDni, "Solo se permiten numeros");
            }
            else if (txtBuscarDni.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuscarDni, "No se permiten mas de 8 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtBuscarDni, "");
            }

        }
        //recargar dgvClientes
        private void RecargardgvClientes()
        {
            try
            {
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in listaClientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );
                }
                //limpiar txtBuscarDni, txtNombreApellido, txtBuscarEmail, textBoxBUSCARGENERAL
                txtBuscarDni.Clear();
                txtNombreApellido.Clear();
                txtBuscarEmail.Clear();
                textBoxBUSCARGENERAL.Clear();
                comboBoxPreventista.SelectedIndex = -1;
                comboBoxTipo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar clientes: " + ex.Message);
            }
        }

        private void FormClienteHistorial_Load(object sender, EventArgs e)
        {
            cargandoFormulario = true;
            //ocultar dataGridViews
            dgvClientes.Visible = true;
            dataGridViewDetallePagos.Visible = true;
            dataGridViewVerPedidos.Visible = true;
            //crear columnas en dataGridViewClientes
            dgvClientes.Columns.Add("id_cliente", "ID");
            dgvClientes.Columns.Add("dni", "DNI");
            dgvClientes.Columns.Add("nombre", "Nombre");
            dgvClientes.Columns.Add("apellido", "Apellido");
            dgvClientes.Columns.Add("telefono", "Teléfono");
            dgvClientes.Columns.Add("email", "Email");
            dgvClientes.Columns.Add("razon_social", "Razón Social");
            dgvClientes.Columns.Add("cuil_cuit", "CUIL/CUIT");
            dgvClientes.Columns.Add("fecha_alta", "Fecha de Alta");
            dgvClientes.Columns.Add("estado", "Estado");
            dgvClientes.Columns.Add("confiable", "Confiable");
            dgvClientes.Columns.Add("condicion_frenteIVA", "Condición frente al IVA");
            dgvClientes.Columns.Add("calle", "Calle");
            dgvClientes.Columns.Add("numero", "Número");
            dgvClientes.Columns.Add("ciudad", "Ciudad");
            dgvClientes.Columns.Add("provincia", "Provincia");
            dgvClientes.Columns.Add("cod_postal", "Código Postal");
            dgvClientes.Columns.Add("tamano", "Tamaño");
            dgvClientes.Columns.Add("zona", "Zona");
            dgvClientes.Columns.Add("id_tamano", "ID Tamaño");
            dgvClientes.Columns.Add("id_zona", "ID Zona");
            //permitir solo lectura del dgvClientes
            dgvClientes.ReadOnly = true;
            //seleccionar toda la fila al hacer click en una celda
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //no permitir seleccionar multiples filas
            dgvClientes.MultiSelect = false;
            //ocultar columnas id_tamano e id_zona
            dgvClientes.Columns["id_tamano"].Visible = false;
            dgvClientes.Columns["id_zona"].Visible = false;
            //cargar lista de clientes en dgvClientes

            RecargardgvClientes();
            //cargar preventistas en comboBoxPreventista
            // Obtener usuarios con rol Preventista
            var empleadosPreventistas = empleado.ObtenerEmpleadosPorRol(5);

            comboBoxPreventista.DataSource = empleadosPreventistas;
            comboBoxPreventista.DisplayMember = "nombre";
            comboBoxPreventista.ValueMember = "nombre_usuario";
            comboBoxPreventista.SelectedIndex = -1;
            //cargar zonas en comboBoxZona desde base de datos
            comboBoxZona.DataSource = clienteLogica.ObtenerZonas();
            comboBoxZona.DisplayMember = "nombre";
            comboBoxZona.ValueMember = "id_zona";
            comboBoxZona.SelectedIndex = -1;
            //cargar tamaños en comboBoxTamano desde base de datos
            comboBoxTamano.DataSource = clienteLogica.ObtenerTamanos();
            comboBoxTamano.DisplayMember = "descripcion";
            comboBoxTamano.ValueMember = "id_tamano";
            comboBoxTamano.SelectedIndex = -1;
            //cargar dataGridViewVerPedidos
            dataGridViewVerPedidos.Columns.Add("id_pedido", "ID Pedido");
            dataGridViewVerPedidos.Columns.Add("fecha_creacion", "Fecha Creación");
            dataGridViewVerPedidos.Columns.Add("fecha_entrega", "Fecha Entrega");
            dataGridViewVerPedidos.Columns.Add("id_cliente", "ID Cliente");
            dataGridViewVerPedidos.Columns.Add("nombre_cliente", "Cliente");
            dataGridViewVerPedidos.Columns.Add("id_estado", "ID_estado");
            dataGridViewVerPedidos.Columns.Add("estado", "Estado");
            dataGridViewVerPedidos.Columns.Add("total", "Total");
            dataGridViewVerPedidos.Columns.Add("numero_factura", "Número Factura");
            dataGridViewVerPedidos.Columns.Add("vendedor", "Vendedor");
            //ocultar columna id_estado
            dataGridViewVerPedidos.Columns["id_estado"].Visible = false;
            //ocultar columna id_cliente
            dataGridViewVerPedidos.Columns["id_cliente"].Visible = false;
            //permitir solo lectura del dataGridViewVerPedidos
            dataGridViewVerPedidos.ReadOnly = true;
            //cargar dataGridViewDetallePagos
            dataGridViewDetallePagos.Columns.Add("id_pago", "ID Pago");
            dataGridViewDetallePagos.Columns.Add("id_cliente", "ID Cliente");
            dataGridViewDetallePagos.Columns.Add("nombre_cliente", "Cliente");
            dataGridViewDetallePagos.Columns.Add("monto", "Monto");
            dataGridViewDetallePagos.Columns.Add("fecha", "Fecha Pago");
            dataGridViewDetallePagos.Columns.Add("id_metodo", "Método de Pago");
            dataGridViewDetallePagos.Columns.Add("metodo_pago", "Método de Pago");
            //ocultar columna id_cliente
            dataGridViewDetallePagos.Columns["id_cliente"].Visible = false;
            dataGridViewDetallePagos.Columns["id_metodo"].Visible = false;
            //permitir solo lectura del dataGridViewDetallePagos
            dataGridViewDetallePagos.ReadOnly = true;
            cargandoFormulario = false;
        }     
       
        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //buscar cliente por dni
                dgvClientes.Visible = true;
                dataGridViewDetallePagos.Visible = false;
                dataGridViewVerPedidos.Visible = false;
                //ocultar errorProvider
                errorProvider1.SetError(txtBuscarDni, "");

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
                //buscar por dni en tabla CLIENTE de base de datos
                // Limpiar las filas actuales del DataGridView
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
                var clientesFiltrados = listaClientes.Where(cliente =>
                    cliente.dni.ToString().ToLower().Contains(filtro)
                ).ToList();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in clientesFiltrados)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );
                }
            }
        }

        private void txtBusacarEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limitar a 50 caracteres
            if (txtBuscarEmail.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuscarEmail, "No se permiten mas de 50 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtBuscarEmail, "");
            }
        }

        private void txtNombreApellido_KeyDown(object sender, KeyEventArgs e)
        {
            //verificar si hay al menos 3 caracteres y si se presiona enter
            if (e.KeyCode == Keys.Enter)
            {
                //buscar cliente por nombre y apellido
                dgvClientes.Visible = true;
                dataGridViewDetallePagos.Visible = false;
                dataGridViewVerPedidos.Visible = false;
                //ocultar errorProvider
                errorProvider1.SetError(txtNombreApellido, "");

                string filtro = txtNombreApellido.Text.ToLower();
                //buscar por nombre o apellido en tabla CLIENTE de base de datos
                // Limpiar las filas actuales del DataGridView
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
                var clientesFiltrados = listaClientes.Where(cliente =>
                    (cliente.nombre != null && cliente.nombre.ToLower().Contains(filtro)) ||
                    (cliente.apellido != null && cliente.apellido.ToLower().Contains(filtro))
                ).ToList();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in clientesFiltrados)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                            cliente.id_tamano, cliente.id_zona
                    );
                }
            }
        }

        private void txtBuscarEmail_KeyDown(object sender, KeyEventArgs e)
        {
            //verificar si tiene formato de email y si se presiona enter
            if (e.KeyCode == Keys.Enter)
            {
                //buscar cliente por email
                dgvClientes.Visible = true;
                dataGridViewDetallePagos.Visible = false;
                dataGridViewVerPedidos.Visible = false;
                //ocultar errorProvider
                errorProvider1.SetError(txtBuscarEmail, "");
                if (!string.IsNullOrEmpty(txtBuscarEmail.Text))
                {
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(txtBuscarEmail.Text);
                        if (addr.Address != txtBuscarEmail.Text)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Por favor, ingrese un formato de email válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarEmail.Clear();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El campo de email no puede estar vacío", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string filtro = txtBuscarEmail.Text.ToLower();
                //buscar por email en tabla CLIENTE de base de datos
                // Limpiar las filas actuales del DataGridView
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
                var clientesFiltrados = listaClientes.Where(cliente =>
                    cliente.email != null && cliente.email.ToLower().Contains(filtro)
                ).ToList();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in clientesFiltrados)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                        cliente.id_tamano,
                        cliente.id_zona
                        );
                }
            }

        }

        private void textBoxBUSCARGENERAL_TextChanged(object sender, EventArgs e)
        {
            //busqueda general en todas las columnas de la tabla cliente
            var zonas = clienteLogica.ObtenerZonas();
            var tamanos = clienteLogica.ObtenerTamanos();

            List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
            string filtro = textBoxBUSCARGENERAL.Text.ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                return;
            }
            var clientesFiltrados = listaClientes.Where(cliente =>
                (cliente.nombre != null && cliente.nombre.ToLower().Contains(filtro)) ||
                (cliente.apellido != null && cliente.apellido.ToLower().Contains(filtro)) ||
                (cliente.dni.ToString().ToLower().Contains(filtro)) ||
                (cliente.email != null && cliente.email.ToLower().Contains(filtro)) ||
                (cliente.razon_social != null && cliente.razon_social.ToLower().Contains(filtro)) ||
                (cliente.cuil_cuit.ToString().ToLower().Contains(filtro)) ||
                (cliente.fecha_alta.ToString("dd/MM/yyyy").ToLower().Contains(filtro)) ||
                (cliente.estado ? "activo" : "inactivo").Contains(filtro) ||
                (cliente.confiable ? "si" : "no").Contains(filtro) ||
                (cliente.condicion_frenteIVA != null && cliente.condicion_frenteIVA.ToLower().Contains(filtro)) ||
                (cliente.calle != null && cliente.calle.ToLower().Contains(filtro)) ||
                (cliente.numero.ToString().ToLower().Contains(filtro)) ||
                (cliente.ciudad != null && cliente.ciudad.ToLower().Contains(filtro)) ||
                (cliente.provincia != null && cliente.provincia.ToLower().Contains(filtro)) ||
                (cliente.cod_postal.ToString().ToLower().Contains(filtro)) ||
                (tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion.ToLower().Contains(filtro) ?? false) ||
                (zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre.ToLower().Contains(filtro) ?? false)
            ).ToList();
            // Limpiar las filas actuales del DataGridView
            dgvClientes.Rows.Clear();
            foreach (var cliente in clientesFiltrados)
            {
                string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                string confiableTexto = cliente.confiable ? "Si" : "No";
                string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                dgvClientes.Rows.Add(
                    cliente.id_cliente,
                    cliente.dni,
                    cliente.nombre,
                    cliente.apellido,
                    cliente.telefono,
                    cliente.email,
                    cliente.razon_social,
                    cliente.cuil_cuit,
                    cliente.fecha_alta,
                    estadoTexto,
                    confiableTexto,
                    cliente.condicion_frenteIVA,
                    cliente.calle,
                    cliente.numero,
                    cliente.ciudad,
                    cliente.provincia,
                    cliente.cod_postal,
                    nombreTamano,
                    nombreZona,
                     cliente.id_tamano, cliente.id_zona
                );
            }

        }

        private void comboBoxPreventista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario || comboBoxPreventista.SelectedIndex == -1)
                return;

            if (comboBoxPreventista.SelectedItem is Empleado preventista)
            {
                string nombreUsuario = preventista.nombre_usuario;

                if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    int idZona = zona.BuscarZonaPorPreventista(nombreUsuario);
                    List<CLIENTE> clientes = clienteLogica.ClientesPorZona(idZona);
                    MessageBox.Show($"Clientes encontrados: {clientes.Count}");

                    dgvClientes.Rows.Clear();
                    var zonas = clienteLogica.ObtenerZonas();
                    var tamanos = clienteLogica.ObtenerTamanos();

                    foreach (var cliente in clientes)
                    {
                        string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                        string confiableTexto = cliente.confiable ? "Si" : "No";
                        string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                        string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";

                        dgvClientes.Rows.Add(
                            cliente.id_cliente,
                            cliente.dni,
                            cliente.nombre,
                            cliente.apellido,
                            cliente.telefono,
                            cliente.email,
                            cliente.razon_social,
                            cliente.cuil_cuit,
                            cliente.fecha_alta,
                            estadoTexto,
                            confiableTexto,
                            cliente.condicion_frenteIVA,
                            cliente.calle,
                            cliente.numero,
                            cliente.ciudad,
                            cliente.provincia,
                            cliente.cod_postal,
                            nombreTamano,
                            nombreZona,
                            cliente.id_tamano,
                            cliente.id_zona
                        );
                    }
                    comboBoxPreventista.SelectedIndex = -1;
                    cargandoFormulario = false;
                }
                else
                {
                    MessageBox.Show("El preventista seleccionado no tiene asignada una zona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si se selecciona Contado en comboBoxTipo, mostrar clientes no confiables
            if (cargandoFormulario || comboBoxTipo.SelectedIndex == -1)
                return;
            //si se selecciona Cuenta Corriente en comboBoxTipo, mostrar clientes confiables
            if (comboBoxTipo.SelectedItem.ToString() == "Cuenta Corriente")
            {
                //mostrar clientes no confiables
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientesConfiables();

                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in listaClientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );

                }
                comboBoxTipo.SelectedIndex = -1;
            }
            //si se selecciona Contado en comboBoxTipo, mostrar clientes no confiables
            else if (comboBoxTipo.SelectedItem.ToString() == "Contado")
            {
                //mostrar clientes confiables
                dgvClientes.Rows.Clear();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientesNoConfiables();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in listaClientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );
                }
                comboBoxTipo.SelectedIndex = -1;
            }
            else
            {
                //mostrar todos los clientes
                RecargardgvClientes();
            }
        }

        private void comboBoxZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filtrar clientes por zona seleccionada
            if (cargandoFormulario || comboBoxZona.SelectedIndex == -1)
                return;
            if (comboBoxZona.SelectedItem is ZONA zonaSeleccionada)
            {
                comboBoxZona.SelectedIndex = -1;
                int idZona = zonaSeleccionada.id_zona;
                List<CLIENTE> clientes = clienteLogica.ClientesPorZona(idZona);
                dgvClientes.Rows.Clear();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in clientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                        cliente.id_tamano,
                        cliente.id_zona
                    );
                }
                cargandoFormulario = false;
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filtrar clientes por estado
            if (cargandoFormulario || comboBoxEstado.SelectedIndex == -1)
                return;
            if (comboBoxEstado.SelectedItem.ToString() == "Activo")
            {
                //mostrar clientes activos
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientesActivos();
                dgvClientes.Rows.Clear();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in listaClientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );
                }
                cargandoFormulario = false;
                comboBoxEstado.SelectedIndex = -1;
            }

            else if (comboBoxEstado.SelectedItem.ToString() == "Inactivo")
            {
                //ver clientes inactivos
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientesInactivos();
                dgvClientes.Rows.Clear();
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                foreach (var cliente in listaClientes)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvClientes.Rows.Add(
                        cliente.id_cliente,
                        cliente.dni,
                        cliente.nombre,
                        cliente.apellido,
                        cliente.telefono,
                        cliente.email,
                        cliente.razon_social,
                        cliente.cuil_cuit,
                        cliente.fecha_alta,
                        estadoTexto,
                        confiableTexto,
                        cliente.condicion_frenteIVA,
                        cliente.calle,
                        cliente.numero,
                        cliente.ciudad,
                        cliente.provincia,
                        cliente.cod_postal,
                        nombreTamano,
                        nombreZona,
                         cliente.id_tamano, cliente.id_zona
                    );
                }
                cargandoFormulario = false;
                comboBoxEstado.SelectedIndex = -1;
            }
            else            
                {
                    //mostrar todos los clientes
                    RecargardgvClientes();
                }            
        }                
    }
}

