using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ArimaERP;
using Capa_Entidades;
using Capa_Entidades.DTOs;
using Capa_Logica;

namespace ArimaERP.Preventista
{
    public partial class FormPedido : Form
    {
        private readonly ClassProductoLogica _productoLogica = new ClassProductoLogica();
        private readonly ClassFamiliaLogica _familiaLogica = new ClassFamiliaLogica();
        private readonly ClassMarcaLogica _marcaLogica = new ClassMarcaLogica();
        private readonly ClassPedidoLogica _pedidoLogica = new ClassPedidoLogica();
        private readonly CultureInfo _culturaMoneda = CultureInfo.GetCultureInfo("es-AR");
        private CLIENTE _clienteSeleccionado;
        private ZONA _zonaSeleccionada;

        public FormPedido()
        {
            InitializeComponent();

            Load += FormComprar_Load;
            btnFiltrar.Click += BtnFiltrar_Click;
            button4.Click += BtnLimpiarFiltros_Click;
            button5.Click += BtnBuscarPorNombre_Click;
            btnCarrito.Click += BtnCarrito_Click;
            btnConfirmar.Click += BtnConfirmar_Click;
            btnElegir.Click += BtnElegir_Click;
            dgvProductos.CellContentClick += DgvProductos_CellContentClick;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            dgvProductos.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;

            if (dataGridView1.Columns.Contains("Producto"))
            {
                dataGridView1.Columns["Producto"].ReadOnly = true;
            }

            if (dataGridView1.Columns.Contains("Total"))
            {
                dataGridView1.Columns["Total"].ReadOnly = true;
            }

            CargarFamilias();
            CargarMarcas();
            ActualizarLabelTotal(0m);
            LimpiarClienteSeleccionado();
            CargarProductos();
        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalSeleccionarCliente())
            {
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    _clienteSeleccionado = modal.ClienteSeleccionado;
                    _zonaSeleccionada = modal.ZonaSeleccionada;
                    ActualizarLabelCliente();
                }
            }
        }

        private void CargarFamilias()
        {
            var familias = _familiaLogica.ObtenerTodasLasFamilias() ?? new List<FAMILIA>();

            if (!familias.Any() && _familiaLogica.ErroresValidacion.Any())
            {
                MostrarErrores("Error al cargar familias", _familiaLogica.ErroresValidacion);
            }

            var familiasConOpcionTodas = new List<FAMILIA>
            {
                new FAMILIA { id_familia = 0, descripcion = "Todas" }
            };

            familiasConOpcionTodas.AddRange(familias.OrderBy(f => f.descripcion));

            cbxFamilia.DataSource = familiasConOpcionTodas;
            cbxFamilia.DisplayMember = nameof(FAMILIA.descripcion);
            cbxFamilia.ValueMember = nameof(FAMILIA.id_familia);
            cbxFamilia.SelectedIndex = 0;
        }

        private void CargarMarcas()
        {
            var marcas = _marcaLogica.ObtenerTodasLasMarcas() ?? new List<MARCA>();

            if (!marcas.Any() && _marcaLogica.ErroresValidacion.Any())
            {
                MostrarErrores("Error al cargar marcas", _marcaLogica.ErroresValidacion);
            }

            var marcasConOpcionTodas = new List<MARCA>
            {
                new MARCA { id_marca = 0, nombre = "Todas" }
            };

            marcasConOpcionTodas.AddRange(marcas.OrderBy(m => m.nombre));

            cbxMarca.DataSource = marcasConOpcionTodas;
            cbxMarca.DisplayMember = nameof(MARCA.nombre);
            cbxMarca.ValueMember = nameof(MARCA.id_marca);
            cbxMarca.SelectedIndex = 0;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void BtnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cbxFamilia.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;
            txtBuscar.Clear();
            CargarProductos();
        }

        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ActualizarLabelTotal(0m);
        }

        private void CargarProductos()
        {
            string termino = txtBuscar.Text.Trim();
            int? idFamilia = ObtenerIdSeleccionado(cbxFamilia);
            int? idMarca = ObtenerIdSeleccionado(cbxMarca);

            var productos = _productoLogica.BuscarCatalogoProductos(termino, idFamilia, idMarca, null, true);

            if (_productoLogica.ErroresValidacion.Any())
            {
                MostrarErrores("Error al buscar productos", _productoLogica.ErroresValidacion);
                return;
            }

            ActualizarListadoProductos(productos);
        }

        private int? ObtenerIdSeleccionado(ComboBox comboBox)
        {
            if (comboBox.SelectedValue is int id && id != 0)
            {
                return id;
            }

            return null;
        }

        private void ActualizarListadoProductos(IEnumerable<ProductoCatalogoDto> productos)
        {
            dgvProductos.Rows.Clear();

            var listaProductos = productos?.ToList() ?? new List<ProductoCatalogoDto>();

            foreach (var producto in listaProductos)
            {
                int fila = dgvProductos.Rows.Add(null, producto.Nombre, FormatearMoneda(producto.PrecioLista), producto.StockActual, producto.Familia, producto.Marca);
                dgvProductos.Rows[fila].Tag = producto;
            }

            if (!listaProductos.Any())
            {
                MessageBox.Show(
                    "No se encontraron productos con los filtros aplicados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvProductos.Columns[e.ColumnIndex].Name != "Agregar")
            {
                return;
            }

            var producto = dgvProductos.Rows[e.RowIndex].Tag as ProductoCatalogoDto;

            if (producto == null)
            {
                return;
            }

            if (ExisteEnCarrito(producto))
            {
                MessageBox.Show(
                    "El producto ya fue agregado al carrito.",
                    "Producto duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int fila = dataGridView1.Rows.Add(producto.Nombre, 1, FormatearMoneda(producto.PrecioLista));
            var filaCarrito = dataGridView1.Rows[fila];
            filaCarrito.Tag = producto;

            dataGridView1.CurrentCell = filaCarrito.Cells["Cantidad"];
            dataGridView1.BeginEdit(true);

            ActualizarTotalesCarrito();
        }

        private bool ExisteEnCarrito(ProductoCatalogoDto producto)
        {
            return dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Any(r => r.Tag is ProductoCatalogoDto dto &&
                          dto.IdProducto == producto.IdProducto &&
                          dto.IdPresentacion == producto.IdPresentacion);
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name != "Cantidad")
            {
                return;
            }

            var fila = dataGridView1.Rows[e.RowIndex];

            if (fila.Cells["Cantidad"].Value == null || string.IsNullOrWhiteSpace(fila.Cells["Cantidad"].Value.ToString()))
            {
                fila.Cells["Cantidad"].Value = 0;
            }

            ActualizarTotalFila(fila);
            ActualizarTotalesCarrito();
        }

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "Cantidad")
            {
                return;
            }

            string valor = e.FormattedValue?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(valor))
            {
                return;
            }

            if (!int.TryParse(valor, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida mayor o igual a cero.",
                    "Cantidad inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell?.OwningColumn?.Name == "Cantidad" && e.Control is TextBox textBox)
            {
                textBox.KeyPress -= CantidadTextBox_KeyPress;
                textBox.KeyPress += CantidadTextBox_KeyPress;
            }
            else if (e.Control is TextBox textBoxGenerico)
            {
                textBoxGenerico.KeyPress -= CantidadTextBox_KeyPress;
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ActualizarTotalFila(DataGridViewRow fila)
        {
            if (!(fila.Tag is ProductoCatalogoDto producto))
            {
                return;
            }

            int cantidad = 0;
            if (fila.Cells["Cantidad"].Value != null)
            {
                int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad);
            }

            decimal total = producto.PrecioLista * cantidad;
            fila.Cells["Total"].Value = FormatearMoneda(total);
        }

        private void ActualizarTotalesCarrito()
        {
            decimal total = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && r.Tag is ProductoCatalogoDto)
                .Sum(r =>
                {
                    var producto = (ProductoCatalogoDto)r.Tag;
                    int cantidad = 0;
                    if (r.Cells["Cantidad"].Value != null)
                    {
                        int.TryParse(r.Cells["Cantidad"].Value.ToString(), out cantidad);
                    }

                    return producto.PrecioLista * cantidad;
                });

            ActualizarLabelTotal(total);
        }

        private void ActualizarLabelTotal(decimal total)
        {
            lblTotal.Text = $"Total: {FormatearMoneda(total)}";
        }

        private void ActualizarLabelCliente()
        {
            if (_clienteSeleccionado == null)
            {
                lblClienteSeleccionado.Text = "Cliente: Ninguno";
                return;
            }

            string nombreCompleto = $"{_clienteSeleccionado.nombre} {_clienteSeleccionado.apellido}".Trim();
            string zonaDescripcion = _zonaSeleccionada?.nombre;

            if (!string.IsNullOrWhiteSpace(zonaDescripcion))
            {
                lblClienteSeleccionado.Text = $"Cliente: {nombreCompleto} (Zona: {zonaDescripcion})";
            }
            else
            {
                lblClienteSeleccionado.Text = $"Cliente: {nombreCompleto}";
            }
        }

        private void LimpiarClienteSeleccionado()
        {
            _clienteSeleccionado = null;
            _zonaSeleccionada = null;
            ActualizarLabelCliente();
        }

        private string FormatearMoneda(decimal valor)
        {
            return valor.ToString("C2", _culturaMoneda);
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un cliente antes de confirmar el pedido.",
                    "Cliente no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var items = ObtenerItemsDelCarrito();

            if (!items.Any())
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto al pedido.",
                    "Pedido vacío",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (var item in items)
            {
                if (item.Cantidad <= 0)
                {
                    MessageBox.Show(
                        "La cantidad de cada producto debe ser mayor a cero.",
                        "Cantidad inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    SeleccionarFilaConProducto(item.Producto);
                    return;
                }
            }

            string vendedor = UsuarioSesion.Nombre;

            if (string.IsNullOrWhiteSpace(vendedor))
            {
                MessageBox.Show(
                    "No se pudo identificar al usuario actual. Inicie sesión nuevamente.",
                    "Usuario no válido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var pedido = new PEDIDO
            {
                fecha_creacion = DateTime.Now,
                fecha_entrega = DateTime.Now,
                id_cliente = _clienteSeleccionado.id_cliente,
                id_estado = 1,
                total = items.Sum(i => i.Producto.PrecioLista * i.Cantidad),
                numero_factura = null,
                vendedor = vendedor
            };

            var detalles = items
                .Select((item, index) => new DETALLE_PEDIDO
                {
                    ID_detalle_pedido = index + 1,
                    id_producto = item.Producto.IdProducto,
                    ID_presentacion = item.Producto.IdPresentacion,
                    cantidad = item.Cantidad,
                    cantidad_bultos = CalcularCantidadBultos(item.Producto, item.Cantidad),
                    precio_unitario = item.Producto.PrecioLista,
                    descuento = 0m
                })
                .ToList();

            bool guardado = _pedidoLogica.GuardarPedidoCompleto(pedido, detalles, null, null);

            if (!guardado)
            {
                MostrarErrores("Error al guardar el pedido", _pedidoLogica.ErroresValidacion);
                return;
            }

            MessageBox.Show(
                $"El pedido N° {pedido.id_pedido} se creó correctamente.",
                "Pedido confirmado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            BtnCarrito_Click(this, EventArgs.Empty);
            LimpiarClienteSeleccionado();
            CargarProductos();
        }

        private void SeleccionarFilaConProducto(ProductoCatalogoDto producto)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                if (fila.Tag is ProductoCatalogoDto dto &&
                    dto.IdProducto == producto.IdProducto &&
                    dto.IdPresentacion == producto.IdPresentacion)
                {
                    dataGridView1.CurrentCell = fila.Cells["Cantidad"];
                    dataGridView1.BeginEdit(true);
                    break;
                }
            }
        }

        private List<ItemCarrito> ObtenerItemsDelCarrito()
        {
            var items = new List<ItemCarrito>();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow || !(fila.Tag is ProductoCatalogoDto producto))
                {
                    continue;
                }

                int cantidad = 0;
                if (fila.Cells["Cantidad"].Value != null)
                {
                    int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad);
                }

                items.Add(new ItemCarrito(producto, cantidad));
            }

            return items;
        }

        private void MostrarErrores(string titulo, IEnumerable<string> errores)
        {
            var mensajes = (errores ?? Enumerable.Empty<string>()).ToList();

            if (!mensajes.Any())
            {
                mensajes.Add("Se produjo un error inesperado.");
            }

            MessageBox.Show(
                string.Join(Environment.NewLine, mensajes),
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private class ItemCarrito
        {
            public ItemCarrito(ProductoCatalogoDto producto, int cantidad)
            {
                Producto = producto;
                Cantidad = cantidad;
            }

            public ProductoCatalogoDto Producto { get; }
            public int Cantidad { get; }
        }

        private int? CalcularCantidadBultos(ProductoCatalogoDto producto, int cantidad)
        {
            if (producto == null || producto.UnidadesPorBulto <= 0 || cantidad <= 0)
            {
                return null;
            }

            return (int)Math.Ceiling(cantidad / (decimal)producto.UnidadesPorBulto);
        }


        private void TLPFooter_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
