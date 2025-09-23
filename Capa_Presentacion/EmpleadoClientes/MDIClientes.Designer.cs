namespace ArimaERP.EmpleadoClientes
{
    partial class MDIClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIClientes));
            this.pnlUSUARIO = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverPanel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCobros = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPreventista = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.pnlVista = new System.Windows.Forms.Panel();
            this.pnlVistaMenuSecundario = new System.Windows.Forms.Panel();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.pnlPreventistas = new System.Windows.Forms.Panel();
            this.btnHistorialPreventistas = new System.Windows.Forms.Button();
            this.btnAltaPrevent = new System.Windows.Forms.Button();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.btnCancPedido = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlUSUARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlVista.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlPreventistas.SuspendLayout();
            this.pnlPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUSUARIO
            // 
            this.pnlUSUARIO.BackColor = System.Drawing.SystemColors.Window;
            this.pnlUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUSUARIO.Controls.Add(this.pictureBox1);
            this.pnlUSUARIO.Controls.Add(this.lblNombreUsuario);
            this.pnlUSUARIO.Controls.Add(this.lblHora);
            this.pnlUSUARIO.Controls.Add(this.lblFecha);
            this.pnlUSUARIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUSUARIO.Location = new System.Drawing.Point(0, 0);
            this.pnlUSUARIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUSUARIO.Name = "pnlUSUARIO";
            this.pnlUSUARIO.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUSUARIO.Size = new System.Drawing.Size(1264, 39);
            this.pnlUSUARIO.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ArimaERP.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(998, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNombreUsuario.Location = new System.Drawing.Point(1039, 2);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 11, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblNombreUsuario.Size = new System.Drawing.Size(221, 29);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Usuario Mercedes Fernandez";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHora.Location = new System.Drawing.Point(308, 12);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblFecha.Location = new System.Drawing.Point(109, 12);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVolverPanel);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCobros);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnPreventista);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 87);
            this.panel1.TabIndex = 3;
            // 
            // btnVolverPanel
            // 
            this.btnVolverPanel.BackColor = System.Drawing.SystemColors.Window;
            this.btnVolverPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVolverPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolverPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverPanel.Image")));
            this.btnVolverPanel.Location = new System.Drawing.Point(1105, 0);
            this.btnVolverPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverPanel.Name = "btnVolverPanel";
            this.btnVolverPanel.Size = new System.Drawing.Size(84, 85);
            this.btnVolverPanel.TabIndex = 11;
            this.btnVolverPanel.UseVisualStyleBackColor = false;
            this.btnVolverPanel.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = global::ArimaERP.Properties.Resources.salir_reducido;
            this.btnSalir.Location = new System.Drawing.Point(1189, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 85);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCobros.Image = global::ArimaERP.Properties.Resources.cobros_reducido;
            this.btnCobros.Location = new System.Drawing.Point(252, 0);
            this.btnCobros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(84, 85);
            this.btnCobros.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCobros, "Pagos");
            this.btnCobros.UseVisualStyleBackColor = true;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClientes.Image = global::ArimaERP.Properties.Resources.clientes_reducido;
            this.btnClientes.Location = new System.Drawing.Point(168, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(84, 85);
            this.btnClientes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClientes, "Clientes");
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPreventista
            // 
            this.btnPreventista.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreventista.Image = global::ArimaERP.Properties.Resources.preventista_reducido;
            this.btnPreventista.Location = new System.Drawing.Point(84, 0);
            this.btnPreventista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreventista.Name = "btnPreventista";
            this.btnPreventista.Size = new System.Drawing.Size(84, 85);
            this.btnPreventista.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPreventista, "Preventistas");
            this.btnPreventista.UseVisualStyleBackColor = true;
            this.btnPreventista.Click += new System.EventHandler(this.btnPreventista_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPedidos.Image = global::ArimaERP.Properties.Resources.pedido_reducido;
            this.btnPedidos.Location = new System.Drawing.Point(0, 0);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(84, 85);
            this.btnPedidos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPedidos, "Pedidos");
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // pnlVista
            // 
            this.pnlVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.pnlVista.Controls.Add(this.pnlVistaMenuSecundario);
            this.pnlVista.Controls.Add(this.pnlClientes);
            this.pnlVista.Controls.Add(this.pnlPreventistas);
            this.pnlVista.Controls.Add(this.pnlPedidos);
            this.pnlVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVista.Location = new System.Drawing.Point(0, 126);
            this.pnlVista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlVista.Name = "pnlVista";
            this.pnlVista.Size = new System.Drawing.Size(1264, 555);
            this.pnlVista.TabIndex = 4;
            // 
            // pnlVistaMenuSecundario
            // 
            this.pnlVistaMenuSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(160)))));
            this.pnlVistaMenuSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVistaMenuSecundario.Location = new System.Drawing.Point(521, 0);
            this.pnlVistaMenuSecundario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlVistaMenuSecundario.Name = "pnlVistaMenuSecundario";
            this.pnlVistaMenuSecundario.Size = new System.Drawing.Size(743, 555);
            this.pnlVistaMenuSecundario.TabIndex = 2;
            this.pnlVistaMenuSecundario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVistaMenuSecundario_Paint);
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(160)))));
            this.pnlClientes.Controls.Add(this.btnCuentaCorriente);
            this.pnlClientes.Controls.Add(this.btnHistorial);
            this.pnlClientes.Controls.Add(this.btnBaja);
            this.pnlClientes.Controls.Add(this.btnModificacion);
            this.pnlClientes.Controls.Add(this.btnAlta);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClientes.Location = new System.Drawing.Point(352, 0);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(169, 555);
            this.pnlClientes.TabIndex = 0;
            this.pnlClientes.Visible = false;
            // 
            // btnCuentaCorriente
            // 
            this.btnCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaCorriente.Location = new System.Drawing.Point(0, 236);
            this.btnCuentaCorriente.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnCuentaCorriente.Name = "btnCuentaCorriente";
            this.btnCuentaCorriente.Size = new System.Drawing.Size(169, 59);
            this.btnCuentaCorriente.TabIndex = 1;
            this.btnCuentaCorriente.Text = "Cuenta Corriente";
            this.btnCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(0, 177);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(169, 59);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            this.btnBaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(0, 118);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(169, 59);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.Location = new System.Drawing.Point(0, 59);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(169, 59);
            this.btnModificacion.TabIndex = 1;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click_1);
            // 
            // btnAlta
            // 
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(0, 0);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(169, 59);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // pnlPreventistas
            // 
            this.pnlPreventistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(160)))));
            this.pnlPreventistas.Controls.Add(this.btnHistorialPreventistas);
            this.pnlPreventistas.Controls.Add(this.btnAltaPrevent);
            this.pnlPreventistas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPreventistas.Location = new System.Drawing.Point(168, 0);
            this.pnlPreventistas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPreventistas.Name = "pnlPreventistas";
            this.pnlPreventistas.Size = new System.Drawing.Size(184, 555);
            this.pnlPreventistas.TabIndex = 3;
            this.pnlPreventistas.Visible = false;
            // 
            // btnHistorialPreventistas
            // 
            this.btnHistorialPreventistas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialPreventistas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPreventistas.Location = new System.Drawing.Point(0, 59);
            this.btnHistorialPreventistas.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnHistorialPreventistas.Name = "btnHistorialPreventistas";
            this.btnHistorialPreventistas.Size = new System.Drawing.Size(184, 59);
            this.btnHistorialPreventistas.TabIndex = 2;
            this.btnHistorialPreventistas.Text = "Historial";
            this.btnHistorialPreventistas.UseVisualStyleBackColor = true;
            this.btnHistorialPreventistas.Click += new System.EventHandler(this.btnHistorialPreventistas_Click);
            // 
            // btnAltaPrevent
            // 
            this.btnAltaPrevent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaPrevent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaPrevent.Location = new System.Drawing.Point(0, 0);
            this.btnAltaPrevent.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnAltaPrevent.Name = "btnAltaPrevent";
            this.btnAltaPrevent.Size = new System.Drawing.Size(184, 59);
            this.btnAltaPrevent.TabIndex = 1;
            this.btnAltaPrevent.Text = "Alta_Modificación_Baja";
            this.btnAltaPrevent.UseVisualStyleBackColor = true;
            this.btnAltaPrevent.Click += new System.EventHandler(this.btnAltaPrevent_Click);
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(160)))));
            this.pnlPedidos.Controls.Add(this.btnCancPedido);
            this.pnlPedidos.Controls.Add(this.btnModificarPedido);
            this.pnlPedidos.Controls.Add(this.btnCrearPedido);
            this.pnlPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(168, 555);
            this.pnlPedidos.TabIndex = 2;
            this.pnlPedidos.Visible = false;
            // 
            // btnCancPedido
            // 
            this.btnCancPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancPedido.Location = new System.Drawing.Point(0, 118);
            this.btnCancPedido.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnCancPedido.Name = "btnCancPedido";
            this.btnCancPedido.Size = new System.Drawing.Size(168, 59);
            this.btnCancPedido.TabIndex = 2;
            this.btnCancPedido.Text = "Cancelar";
            this.btnCancPedido.UseVisualStyleBackColor = true;
            this.btnCancPedido.Click += new System.EventHandler(this.btnCancPedido_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPedido.Location = new System.Drawing.Point(0, 59);
            this.btnModificarPedido.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(168, 59);
            this.btnModificarPedido.TabIndex = 1;
            this.btnModificarPedido.Text = "Modificar";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPedido.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPedido.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(168, 59);
            this.btnCrearPedido.TabIndex = 1;
            this.btnCrearPedido.Text = "Crear";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // MDIClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlVista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUSUARIO);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIClientes";
            this.Text = "Sección Clientes";
            this.Load += new System.EventHandler(this.MDIClientes_Load);
            this.pnlUSUARIO.ResumeLayout(false);
            this.pnlUSUARIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlVista.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlPreventistas.ResumeLayout(false);
            this.pnlPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUSUARIO;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCobros;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPreventista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlVista;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCuentaCorriente;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Panel pnlPreventistas;
        private System.Windows.Forms.Button btnAltaPrevent;
        private System.Windows.Forms.Panel pnlVistaMenuSecundario;
        private System.Windows.Forms.Button btnHistorialPreventistas;
        private System.Windows.Forms.Button btnCancPedido;
        private System.Windows.Forms.Button btnVolverPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}