﻿using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;


namespace ArimaERP.EmpleadoClientes
{
    public partial class FormCrearPedido : Form
    {
        ClassClienteLogica clienteLogica = new ClassClienteLogica();
        ClassPedidoLogica pedidoLogica = new ClassPedidoLogica();
        ClassFamiliaLogica familiaLogica = new ClassFamiliaLogica();
        ClassMarcaLogica marcaLogica = new ClassMarcaLogica();
        ClassProveedorLogica proveedorLogica = new ClassProveedorLogica();
        public FormCrearPedido()
        {
            InitializeComponent();
        }

        private void FormCrearPedido_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //crear dgvResultados con columnas:
            dgvResultados.Columns.Add("id_cliente", "ID");
            dgvResultados.Columns.Add("DNI", "DNI");
            dgvResultados.Columns.Add("Nombre", "Nombre");
            dgvResultados.Columns.Add("Apellido", "Apellido");
            dgvResultados.Columns.Add("Telefono", "Teléfono");
            dgvResultados.Columns.Add("Email", "Email");
            dgvResultados.Columns.Add("RazonSocial", "Razón Social");
            dgvResultados.Columns.Add("CUIT_CUIL", "CUIT/CUIL");
            dgvResultados.Columns.Add("FechaAlta", "Fecha de Alta");
            dgvResultados.Columns.Add("Estado", "Estado");
            dgvResultados.Columns.Add("Confiable", "Confiable");
            dgvResultados.Columns.Add("CondicionFrenteIVA", "Condición frente al IVA");
            dgvResultados.Columns.Add("Calle", "Calle");
            dgvResultados.Columns.Add("Numero", "Número");
            dgvResultados.Columns.Add("Ciudad", "Ciudad");
            dgvResultados.Columns.Add("Provincia", "Provincia");
            dgvResultados.Columns.Add("CodPostal", "Código Postal");
            dgvResultados.Columns.Add("Tamano_Negocio", "Tamaño del Negocio");
            dgvResultados.Columns.Add("Zona", "Zona");
            dgvResultados.Columns.Add("id_tamano", "id_tamano");
            dgvResultados.Columns.Add("id_zona", "id_zona");
            dgvResultados.Columns["id_tamano"].Visible = false;
            dgvResultados.Columns["id_zona"].Visible = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.MultiSelect = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.AllowUserToAddRows = false;
            //cargar zonas en comboBoxClienteZona
            var zonas = clienteLogica.ObtenerZonas();
            comboBoxClienteZona.DataSource = zonas;
            comboBoxClienteZona.DisplayMember = "nombre";
            comboBoxClienteZona.ValueMember = "id_zona";
            comboBoxClienteZona.SelectedIndex = -1; // No seleccionar nada al inicio
            //cargar comboBoxFamilia de base de datos
            var familias = familiaLogica.ObtenerTodasLasFamilias();
            comboBoxFamilia.DataSource = familias;
            comboBoxFamilia.DisplayMember = "descripcion";
            comboBoxFamilia.ValueMember = "id_familia";

            comboBoxFamilia.SelectedIndex = -1; // No seleccionar nada al inicio
            //cargar comboBoxMarca de base de datos
            var marcas = marcaLogica.ObtenerTodasLasMarcas();
            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.DisplayMember = "nombre";
            comboBoxMarca.ValueMember = "id_marca";
            comboBoxMarca.SelectedIndex = -1; // No seleccionar nada al inicio
            //cargar comboBoxProveedor de base de datos
            var proveedores = proveedorLogica.ObtenerTodosLosProveedores();
            if (proveedores.Any())
            {
                comboBoxProveedor.DataSource = proveedores;
                comboBoxProveedor.DisplayMember = "razon_social";
                comboBoxProveedor.ValueMember = "id_proveedor";
                comboBoxProveedor.SelectedIndex = -1; // No seleccionar nada al inicio
            }
            else
            {
                MessageBox.Show("No se encontraron proveedores.");
                if (proveedorLogica.ErroresValidacion.Any())
                {
                    MessageBox.Show(string.Join("\n", proveedorLogica.ErroresValidacion));
                }


            }
            //cargar dataGridViewProductos con columnas
            dataGridViewProductos.Columns.Add("nombre", "Nombre");
            dataGridViewProductos.Columns.Add("presentacion", "Presentación");
            dataGridViewProductos.Columns.Add("cod_producto", "Código");
            dataGridViewProductos.Columns.Add("precioLista", "Precio");
            dataGridViewProductos.Columns.Add("stock", "Stock");
            dataGridViewProductos.Columns.Add("marca", "Marca");
            dataGridViewProductos.Columns.Add("ID_presentacion", "id_Presentacion");
            dataGridViewProductos.Columns["ID_presentacion"].Visible = false;
            dataGridViewProductos.Columns.Add("id_producto", "ID_producto");
            dataGridViewProductos.Columns["id_producto"].Visible = false;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.MultiSelect = false;
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.AllowUserToAddRows = false;
            //cargar dataGridViewDetallePedido con columnas
            dataGridViewDetallePedido.Columns.Add("id_pedido", "ID_pedido");
            dataGridViewDetallePedido.Columns.Add("ID_detalle_pedido", "ID_Detalle");
            dataGridViewDetallePedido.Columns.Add("id_producto", "ID_producto");
            dataGridViewDetallePedido.Columns.Add("ID_presentacion", "ID_presentacion");
            dataGridViewDetallePedido.Columns.Add("nombre", "Nombre");
            dataGridViewDetallePedido.Columns.Add("presentacion", "Presentación");
            dataGridViewDetallePedido.Columns.Add("cantidad_unidad", "Cantidad Unidades");
            dataGridViewDetallePedido.Columns.Add("cantidad_bultos", "Cantidad Bultos");
            dataGridViewDetallePedido.Columns.Add("precio_unitario", "Precio Unitario");
            dataGridViewDetallePedido.Columns.Add("subtotal", "Subtotal");
            dataGridViewDetallePedido.Columns.Add("descuento", "Descuento");
            dataGridViewDetallePedido.Columns.Add("total", "Total");
            //permitir editar solo cantidad_unidad, cantidad_bultos y descuento
            dataGridViewDetallePedido.Columns["cantidad_unidad"].ReadOnly = false;
            dataGridViewDetallePedido.Columns["cantidad_bultos"].ReadOnly = false;
            dataGridViewDetallePedido.Columns["descuento"].ReadOnly = false;
            //no permitir la edición de las demás columnas
            dataGridViewDetallePedido.Columns["id_pedido"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["ID_detalle_pedido"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["id_producto"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["ID_presentacion"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["nombre"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["presentacion"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["precio_unitario"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["subtotal"].ReadOnly = true;
            dataGridViewDetallePedido.Columns["total"].ReadOnly = true;

            //agregar boton de eliminar detalle
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acción";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridViewDetallePedido.Columns.Add(btnEliminar);
            dataGridViewDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetallePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetallePedido.ReadOnly = false;
            dataGridViewDetallePedido.MultiSelect = false;
            dataGridViewDetallePedido.Columns["id_pedido"].Visible = false;
            dataGridViewDetallePedido.Columns["id_producto"].Visible = false;
            dataGridViewDetallePedido.Columns["ID_presentacion"].Visible = false;
            dataGridViewDetallePedido.Columns["total"].Visible = false;

        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {   //clear textBoxDNI
            textBoxDNI.Clear();
            //buscar cliente por cualquier campo de tabla CLIENTE a partir de txtBuscarCliente
            // y cargar datos en el dgvResultados
            string filtro = txtBuscarCliente.Text.ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Ingrese un término de búsqueda.");
                return;
            }
            // Realizar búsqueda en la base de datos
            //busqueda general en todas las columnas de la tabla cliente
            var zonas = clienteLogica.ObtenerZonas();
            var tamanos = clienteLogica.ObtenerTamanos();

            List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();

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
            dgvResultados.Rows.Clear();
            foreach (var cliente in clientesFiltrados)
            {
                string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                string confiableTexto = cliente.confiable ? "Si" : "No";
                string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                dgvResultados.Rows.Add(
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

        private void button1_Click(object sender, EventArgs e)
        {

            // Instanciar el formulario
            FormCliente formCliente = new FormCliente();
            //Ubicar en el centro de pnlVistaMenuSecundario como showDialog
            formCliente.StartPosition = FormStartPosition.CenterParent;
            formCliente.ShowDialog();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            //cerrar formulario
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Validar campos en dataGridViewDetallePedido
            if (dataGridViewDetallePedido.Rows.Count == 0)
            {
                MessageBox.Show("El pedido debe tener al menos un producto.");
                return;
            }
            foreach (DataGridViewRow fila in dataGridViewDetallePedido.Rows)
            {
                if (fila.Cells["ID_detalle_pedido"].Value == null||fila.Cells["cantidad_unidad"].Value == null || fila.Cells["cantidad_bultos"].Value == null || fila.Cells["descuento"].Value == null)
                {
                    MessageBox.Show("Todos los campos de cantidad y descuento deben estar completos.");
                    return;
                }
                int cantidadUnidades;
                int cantidadBultos;
                decimal descuento;
                if (!int.TryParse(fila.Cells["cantidad_unidad"].Value.ToString(), out cantidadUnidades) || cantidadUnidades < 0)
                {
                    MessageBox.Show("La cantidad de unidades debe ser un número entero positivo.");
                    return;
                }
                if (!int.TryParse(fila.Cells["cantidad_bultos"].Value.ToString(), out cantidadBultos) || cantidadBultos < 0)
                {
                    MessageBox.Show("La cantidad de bultos debe ser un número entero positivo.");
                    return;
                }
                if (!decimal.TryParse(fila.Cells["descuento"].Value.ToString(), out descuento) || descuento < 0)
                {
                    MessageBox.Show("El descuento debe ser un número decimal positivo.");
                    return;
                }
                //guardar detalle pedido
                if(pedidoLogica.GuardarDetallePedido(
                    cantidadUnidades.ToString(),
                    descuento.ToString(),
                    fila.Cells["ID_detalle_pedido"].Value.ToString(),
                    fila.Cells["id_pedido"].Value.ToString(),
                    fila.Cells["id_producto"].Value.ToString(),
                    fila.Cells["ID_presentacion"].Value.ToString(),
                    cantidadBultos.ToString(),
                    fila.Cells["precio_unitario"].Value.ToString()
                    ))
                {
                    MessageBox.Show("Detalle del pedido guardado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar el detalle del pedido.");
                    if (pedidoLogica.ErroresValidacion.Any())
                    {
                        MessageBox.Show(string.Join("\n", pedidoLogica.ErroresValidacion));
                    }
                    return;
                }
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros y control y no mas de 8 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDNI, "Solo se permiten números.");
            }
            else
            {
                errorProvider1.SetError(textBoxDNI, "");
            }
            if (textBoxDNI.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDNI, "No se permiten más de 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxDNI, "");
            }
        }

        private void textBoxDNI_KeyDown(object sender, KeyEventArgs e)
        {
            //limpiar txtBuscarCliente
            txtBuscarCliente.Clear();
            //si presiona enter buscar cliente por dni
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                string dni = textBoxDNI.Text;
                if (string.IsNullOrEmpty(dni))
                {
                    MessageBox.Show("Ingrese un DNI para buscar.");
                    return;
                }
                //buscar cliente por dni y cargar datos en el dgvResultados
                var zonas = clienteLogica.ObtenerZonas();
                var tamanos = clienteLogica.ObtenerTamanos();
                List<CLIENTE> listaClientes = clienteLogica.ObtenerClientes();
                var clientesFiltrados = listaClientes.Where(cliente =>
                    (cliente.dni.ToString().ToLower().Contains(dni))
                ).ToList();
                // Limpiar las filas actuales del DataGridView
                dgvResultados.Rows.Clear();
                foreach (var cliente in clientesFiltrados)
                {
                    string estadoTexto = cliente.estado ? "Activo" : "Inactivo";
                    string confiableTexto = cliente.confiable ? "Si" : "No";
                    string nombreZona = zonas.FirstOrDefault(z => z.id_zona == cliente.id_zona)?.nombre ?? "Zona desconocida";
                    string nombreTamano = tamanos.FirstOrDefault(t => t.id_tamano == cliente.id_tamano)?.descripcion ?? "Tamaño desconocido";
                    dgvResultados.Rows.Add(
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

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarDatosPedidoDesdeFila(e.RowIndex);
            }
        }

        private void dgvResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvResultados.CurrentRow != null)
            {
                e.Handled = true;
                CargarDatosPedidoDesdeFila(dgvResultados.CurrentRow.Index);
            }
        }
        private void CargarDatosPedidoDesdeFila(int rowIndex)
        {
            // Obtener datos del cliente desde la fila seleccionada
            DataGridViewRow fila = dgvResultados.Rows[rowIndex];
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string apellido = fila.Cells["Apellido"].Value.ToString();
            string zona = fila.Cells["Zona"].Value.ToString();
            string telefono = fila.Cells["Telefono"].Value.ToString();
            //Obtener usuario actual
            string usuarioActual = ObtenerUsuarioActual();
            //obtener nombre de empleado de tabla Empleado partir de nombre_usuario que corresponde al usuario actual
            Empleado empleado = new ClassEmpleadoLogica().ObtenerEmpleadoPorNombreUsuario(usuarioActual);
            if (empleado != null)
            {
                lblVendedor.Text = $"{empleado.nombre} {empleado.apellido}";
            }
            else
            {
                lblVendedor.Text = "Empleado no encontrado";
            }
            // Cargar en labels agregando datos de la fila seleccionada al texto existente

            lblNombre.Text = $"Cliente: {nombre} {apellido}";
            lblZona.Text = $"Zona: {zona}";
            lblTelefono.Text = $"Teléfono: {telefono}";
            lblDireccion.Text = $"Dirección: {fila.Cells["Calle"].Value} {fila.Cells["Numero"].Value}, {fila.Cells["Ciudad"].Value}, {fila.Cells["Provincia"].Value}, CP: {fila.Cells["codPostal"].Value}";
            int siguienteIdPedido = pedidoLogica.ObtenerSiguienteIdPedido();
            lblNumeroPedido.Text = $"Pedido N°: {siguienteIdPedido}";

        }


        private string ObtenerUsuarioActual()
        {
            // Aquí debes implementar la lógica para obtener el nombre del usuario actual
            return UsuarioSesion.Nombre; // Ejemplo: retorna el nombre del usuario desde una clase estática de sesión


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo numeros y no mas de 10 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxCodigo, "Solo se permiten números.");
            }
            else
            {
                errorProvider1.SetError(textBoxCodigo, "");
            }
            if (textBoxCodigo.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxCodigo, "No se permiten más de 10 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxCodigo, "");
            }
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //si presiona enter buscar producto por codigo y cargar datos en el dataGridViewProductos a partir de PRESENTACION, PRODUCTO Y producto_presentacion
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                string codigo = textBoxCodigo.Text;
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Ingrese un código para buscar.");
                    return;
                }
                //buscar producto por codigo y cargar datos en el dataGridViewProductos a partir de PRESENTACION, PRODUCTO Y producto_presentacion
                int codProducto;
                if (!int.TryParse(codigo, out codProducto))
                {
                    MessageBox.Show("El código debe ser un número válido.");
                    return;
                }
                var productoPresentacion = new ClassProductoLogica().ObtenerProductoPresentacionPorCodigo(codProducto);
                if (productoPresentacion != null)
                {
                    var producto = new ClassProductoLogica().ObtenerProductoPorId(productoPresentacion.id_producto);
                    var presentacion = new ClassProductoLogica().ObtenerPresentacionPorId(productoPresentacion.ID_presentacion);
                    var stockProducto = new ClassProductoLogica().ObtenerStockPorProductoYPresentacion(productoPresentacion.id_producto, productoPresentacion.ID_presentacion);
                    var marca = new ClassMarcaLogica().ObtenerMarcaPorId(producto.id_marca);
                    if (producto != null && presentacion != null)
                    {
                        // Agregar fila al dataGridViewProductos
                        dataGridViewProductos.Rows.Add(
                            producto.nombre,
                            presentacion.descripcion,
                            productoPresentacion.cod_producto,
                            productoPresentacion.precioLista,
                            stockProducto.stock_actual,
                            marca.nombre,
                            productoPresentacion.ID_presentacion,
                            productoPresentacion.id_producto

                        );
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto o la presentación asociada.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el código proporcionado.");
                    if (new ClassProductoLogica().ErroresValidacion.Any())
                    {
                        MessageBox.Show(string.Join("\n", new ClassProductoLogica().ErroresValidacion));
                    }
                }
            }
        }

        private void dataGridViewProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Agregar producto seleccionado a dataGridViewDetallePedido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewProductos.Rows[e.RowIndex];
                // Verificar si el producto ya está en el detalle del pedido
                foreach (DataGridViewRow detalleFila in dataGridViewDetallePedido.Rows)
                {
                    if (detalleFila.Cells["id_producto"].Value.ToString() == fila.Cells["id_producto"].Value.ToString() &&
                        detalleFila.Cells["ID_presentacion"].Value.ToString() == fila.Cells["ID_presentacion"].Value.ToString())
                    {
                        MessageBox.Show("El producto ya está en el detalle del pedido.");
                        return;
                    }
                }
                // Agregar el producto al detalle del pedido con cantidad inicial de 1 unidad y 1 bulto
                decimal precioUnitario = Convert.ToDecimal(fila.Cells["precioLista"].Value);
                int cantidadUnidades = 1;
                int cantidadBultos = 1;
                decimal subtotal = precioUnitario * cantidadUnidades;
                decimal descuento = 0; // Inicialmente sin descuento
                decimal total = subtotal - descuento;
                //agregar en dataGridViewDetallePedido en un valor id_pedido el siguiente id de pedido a partir de pedidoLogica.ObtenerSiguienteIdPedido()
                int siguienteIdPedido = pedidoLogica.ObtenerSiguienteIdPedido();


                dataGridViewDetallePedido.Rows.Add(
                    siguienteIdPedido,
                    dataGridViewDetallePedido.Rows.Count + 1, // ID_detalle_pedido secuencial
                    fila.Cells["id_producto"].Value,
                    fila.Cells["ID_presentacion"].Value,
                    fila.Cells["nombre"].Value,
                    fila.Cells["presentacion"].Value,
                    cantidadUnidades,
                    cantidadBultos,
                    precioUnitario,
                    subtotal,
                    descuento,
                    total
                );
            }
        }
                
        
        private void dataGridViewDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se presiona el boton eliminar eliminar fila
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDetallePedido.Columns["btnEliminar"].Index)
            {
                dataGridViewDetallePedido.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

