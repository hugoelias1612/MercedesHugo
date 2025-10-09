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

        public FormClienteHistorial()
        {
            InitializeComponent();
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListarPagos_Click(object sender, EventArgs e)
        {
            //Visualizar dataGridViewDetallePagos
            dataGridViewDetallePagos.Visible = true;
        }

        private void btnListarPedidosPendientes_Click(object sender, EventArgs e)
        {
            //visualizar dataGridViewVerPedidos
            dataGridViewVerPedidos.Visible = true;
            dgvClientes.Visible = false;
            dataGridViewDetallePagos.Visible = false;
        }

        private void btnPedidosEntregados_Click(object sender, EventArgs e)
        {
            //visualizar dataGridViewVerPedidos
            dataGridViewVerPedidos.Visible = true;
            dgvClientes.Visible = false;
            dataGridViewDetallePagos.Visible = false;
        }

        private void btnListarSaldosPendientes_Click(object sender, EventArgs e)
        {
            dataGridViewVerPedidos.Visible = true;
            dataGridViewDetallePagos.Visible = false;
            dgvClientes.Visible = false;
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = true;
            dataGridViewDetallePagos.Visible = false;
            dataGridViewVerPedidos.Visible = false;
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

        private void FormClienteHistorial_Load(object sender, EventArgs e)
        {
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
        }

        private void txtBuscarDni_KeyDown(object sender, KeyEventArgs e)
        {
            //verificar si hay 7 o 8 caracteres y si se presiona enter
            if ((txtBuscarDni.Text.Length == 7 || txtBuscarDni.Text.Length == 8) && e.KeyCode == Keys.Enter)
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
            else
            {
                MessageBox.Show("El DNI debe tener 7 u 8 caracteres", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            if (txtNombreApellido.Text.Length >= 3 && e.KeyCode == Keys.Enter)
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
            else
            {
                MessageBox.Show("Se requieren al menos 3 caracteres", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
