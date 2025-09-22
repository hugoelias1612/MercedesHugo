namespace ArimaERP.EmpleadoClientes
{
    partial class FormClienteHistorial
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
            this.TLPHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnListarPagos = new System.Windows.Forms.Button();
            this.textBoxBUSCARGENERAL = new System.Windows.Forms.TextBox();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBusacarEmail = new System.Windows.Forms.TextBox();
            this.btnListarSaldosPendientes = new System.Windows.Forms.Button();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.btnPedidosEntregados = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblLetraApellido = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.btnListarPedidosPendientes = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.tableLayoutPanelClientes = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPreventistas = new System.Windows.Forms.TextBox();
            this.lblPreventistas = new System.Windows.Forms.Label();
            this.lblZONA = new System.Windows.Forms.Label();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.comboBoxZona = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxTamano = new System.Windows.Forms.ComboBox();
            this.dataGridViewVerPedidos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preventista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDetallePagos = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.TLPHeader.SuspendLayout();
            this.tableLayoutPanelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            this.tableLayoutPanelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPHeader
            // 
            this.TLPHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TLPHeader.ColumnCount = 1;
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPHeader.Controls.Add(this.lblHistorial, 0, 0);
            this.TLPHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPHeader.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLPHeader.Location = new System.Drawing.Point(0, 0);
            this.TLPHeader.Margin = new System.Windows.Forms.Padding(0);
            this.TLPHeader.Name = "TLPHeader";
            this.TLPHeader.RowCount = 1;
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.TLPHeader.Size = new System.Drawing.Size(1325, 58);
            this.TLPHeader.TabIndex = 2;
            // 
            // tableLayoutPanelCliente
            // 
            this.tableLayoutPanelCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanelCliente.ColumnCount = 9;
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0093F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07116F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.49057F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.86792F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.96226F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.58491F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.754717F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.003839F));
            this.tableLayoutPanelCliente.Controls.Add(this.btnListarPagos, 1, 0);
            this.tableLayoutPanelCliente.Controls.Add(this.textBoxBUSCARGENERAL, 7, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.pictureBoxBuscar, 6, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.lblMail, 5, 0);
            this.tableLayoutPanelCliente.Controls.Add(this.txtBusacarEmail, 5, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.btnListarSaldosPendientes, 1, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.txtBuscarDni, 4, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.btnPedidosEntregados, 2, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.lblDNI, 4, 0);
            this.tableLayoutPanelCliente.Controls.Add(this.lblLetraApellido, 3, 0);
            this.tableLayoutPanelCliente.Controls.Add(this.txtNombreApellido, 3, 1);
            this.tableLayoutPanelCliente.Controls.Add(this.btnListarPedidosPendientes, 2, 0);
            this.tableLayoutPanelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCliente.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelCliente.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanelCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCliente.Name = "tableLayoutPanelCliente";
            this.tableLayoutPanelCliente.RowCount = 2;
            this.tableLayoutPanelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanelCliente.Size = new System.Drawing.Size(1325, 89);
            this.tableLayoutPanelCliente.TabIndex = 6;
            // 
            // btnListarPagos
            // 
            this.btnListarPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListarPagos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPagos.Location = new System.Drawing.Point(16, 3);
            this.btnListarPagos.Name = "btnListarPagos";
            this.btnListarPagos.Size = new System.Drawing.Size(207, 38);
            this.btnListarPagos.TabIndex = 40;
            this.btnListarPagos.Text = "Pagos";
            this.btnListarPagos.UseVisualStyleBackColor = true;
            this.btnListarPagos.Click += new System.EventHandler(this.btnListarPagos_Click);
            // 
            // textBoxBUSCARGENERAL
            // 
            this.textBoxBUSCARGENERAL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBUSCARGENERAL.Location = new System.Drawing.Point(1100, 48);
            this.textBoxBUSCARGENERAL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBUSCARGENERAL.Name = "textBoxBUSCARGENERAL";
            this.textBoxBUSCARGENERAL.Size = new System.Drawing.Size(166, 31);
            this.textBoxBUSCARGENERAL.TabIndex = 37;
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxBuscar.Image = global::ArimaERP.Properties.Resources.BUSCAR_reducido20x20;
            this.pictureBoxBuscar.Location = new System.Drawing.Point(1053, 53);
            this.pictureBoxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(39, 26);
            this.pictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBuscar.TabIndex = 38;
            this.pictureBoxBuscar.TabStop = false;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(912, 9);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(62, 25);
            this.lblMail.TabIndex = 33;
            this.lblMail.Text = "EMAIL";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusacarEmail
            // 
            this.txtBusacarEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusacarEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusacarEmail.Location = new System.Drawing.Point(856, 51);
            this.txtBusacarEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusacarEmail.Name = "txtBusacarEmail";
            this.txtBusacarEmail.Size = new System.Drawing.Size(174, 31);
            this.txtBusacarEmail.TabIndex = 25;
            // 
            // btnListarSaldosPendientes
            // 
            this.btnListarSaldosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListarSaldosPendientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSaldosPendientes.Location = new System.Drawing.Point(16, 47);
            this.btnListarSaldosPendientes.Name = "btnListarSaldosPendientes";
            this.btnListarSaldosPendientes.Size = new System.Drawing.Size(207, 39);
            this.btnListarSaldosPendientes.TabIndex = 43;
            this.btnListarSaldosPendientes.Text = "Saldos Pendientes";
            this.btnListarSaldosPendientes.UseVisualStyleBackColor = true;
            this.btnListarSaldosPendientes.Click += new System.EventHandler(this.btnListarSaldosPendientes_Click);
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDni.Location = new System.Drawing.Point(672, 51);
            this.txtBuscarDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(177, 31);
            this.txtBuscarDni.TabIndex = 21;
            // 
            // btnPedidosEntregados
            // 
            this.btnPedidosEntregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPedidosEntregados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosEntregados.Location = new System.Drawing.Point(229, 47);
            this.btnPedidosEntregados.Name = "btnPedidosEntregados";
            this.btnPedidosEntregados.Size = new System.Drawing.Size(239, 39);
            this.btnPedidosEntregados.TabIndex = 42;
            this.btnPedidosEntregados.Text = "Pedidos Entregados";
            this.btnPedidosEntregados.UseVisualStyleBackColor = true;
            this.btnPedidosEntregados.Click += new System.EventHandler(this.btnPedidosEntregados_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(739, 9);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 25);
            this.lblDNI.TabIndex = 31;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetraApellido
            // 
            this.lblLetraApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLetraApellido.AutoSize = true;
            this.lblLetraApellido.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraApellido.Location = new System.Drawing.Point(487, 9);
            this.lblLetraApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetraApellido.Name = "lblLetraApellido";
            this.lblLetraApellido.Size = new System.Drawing.Size(165, 25);
            this.lblLetraApellido.TabIndex = 4;
            this.lblLetraApellido.Text = "Nombre o Apellido";
            this.lblLetraApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreApellido.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreApellido.Location = new System.Drawing.Point(475, 51);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(189, 31);
            this.txtNombreApellido.TabIndex = 36;
            // 
            // btnListarPedidosPendientes
            // 
            this.btnListarPedidosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListarPedidosPendientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPedidosPendientes.Location = new System.Drawing.Point(229, 3);
            this.btnListarPedidosPendientes.Name = "btnListarPedidosPendientes";
            this.btnListarPedidosPendientes.Size = new System.Drawing.Size(239, 38);
            this.btnListarPedidosPendientes.TabIndex = 41;
            this.btnListarPedidosPendientes.Text = "Pedidos Pendientes";
            this.btnListarPedidosPendientes.UseVisualStyleBackColor = true;
            this.btnListarPedidosPendientes.Click += new System.EventHandler(this.btnListarPedidosPendientes_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(526, 2);
            this.lblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(273, 54);
            this.lblHistorial.TabIndex = 7;
            this.lblHistorial.Text = "Buscar Cliente";
            // 
            // tableLayoutPanelClientes
            // 
            this.tableLayoutPanelClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanelClientes.ColumnCount = 9;
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0093F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07116F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.15262F));
            this.tableLayoutPanelClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.00384F));
            this.tableLayoutPanelClientes.Controls.Add(this.textBoxPreventistas, 4, 1);
            this.tableLayoutPanelClientes.Controls.Add(this.lblPreventistas, 4, 0);
            this.tableLayoutPanelClientes.Controls.Add(this.lblZONA, 3, 0);
            this.tableLayoutPanelClientes.Controls.Add(this.btnBuscarClientes, 1, 1);
            this.tableLayoutPanelClientes.Controls.Add(this.lblTipo, 2, 0);
            this.tableLayoutPanelClientes.Controls.Add(this.comboBoxTipo, 2, 1);
            this.tableLayoutPanelClientes.Controls.Add(this.lblEstado, 5, 0);
            this.tableLayoutPanelClientes.Controls.Add(this.lblTamano, 6, 0);
            this.tableLayoutPanelClientes.Controls.Add(this.comboBoxZona, 3, 1);
            this.tableLayoutPanelClientes.Controls.Add(this.comboBoxEstado, 5, 1);
            this.tableLayoutPanelClientes.Controls.Add(this.comboBoxTamano, 6, 1);
            this.tableLayoutPanelClientes.Location = new System.Drawing.Point(49, 180);
            this.tableLayoutPanelClientes.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelClientes.Name = "tableLayoutPanelClientes";
            this.tableLayoutPanelClientes.RowCount = 2;
            this.tableLayoutPanelClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanelClientes.Size = new System.Drawing.Size(1244, 84);
            this.tableLayoutPanelClientes.TabIndex = 39;
            // 
            // textBoxPreventistas
            // 
            this.textBoxPreventistas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPreventistas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreventistas.Location = new System.Drawing.Point(540, 47);
            this.textBoxPreventistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPreventistas.Name = "textBoxPreventistas";
            this.textBoxPreventistas.Size = new System.Drawing.Size(157, 31);
            this.textBoxPreventistas.TabIndex = 25;
            // 
            // lblPreventistas
            // 
            this.lblPreventistas.AutoSize = true;
            this.lblPreventistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreventistas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreventistas.Location = new System.Drawing.Point(540, 0);
            this.lblPreventistas.Name = "lblPreventistas";
            this.lblPreventistas.Size = new System.Drawing.Size(157, 42);
            this.lblPreventistas.TabIndex = 33;
            this.lblPreventistas.Text = "Preventista";
            this.lblPreventistas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZONA
            // 
            this.lblZONA.AutoSize = true;
            this.lblZONA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZONA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZONA.Location = new System.Drawing.Point(378, 0);
            this.lblZONA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZONA.Name = "lblZONA";
            this.lblZONA.Size = new System.Drawing.Size(155, 42);
            this.lblZONA.TabIndex = 31;
            this.lblZONA.Text = "Zona";
            this.lblZONA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientes.Location = new System.Drawing.Point(15, 45);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(193, 36);
            this.btnBuscarClientes.TabIndex = 44;
            this.btnBuscarClientes.Text = "Buscar Todos";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(240, 8);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(105, 25);
            this.lblTipo.TabIndex = 45;
            this.lblTipo.Text = "Tipo Cliente";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Contado",
            "Cuenta Corriente"});
            this.comboBoxTipo.Location = new System.Drawing.Point(218, 46);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(148, 33);
            this.comboBoxTipo.TabIndex = 46;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(751, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 23);
            this.lblEstado.TabIndex = 47;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTamano
            // 
            this.lblTamano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(909, 9);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(70, 23);
            this.lblTamano.TabIndex = 48;
            this.lblTamano.Text = "Tamaño";
            this.lblTamano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxZona
            // 
            this.comboBoxZona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxZona.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxZona.FormattingEnabled = true;
            this.comboBoxZona.Location = new System.Drawing.Point(379, 46);
            this.comboBoxZona.Name = "comboBoxZona";
            this.comboBoxZona.Size = new System.Drawing.Size(153, 33);
            this.comboBoxZona.TabIndex = 49;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEstado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(703, 46);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(157, 33);
            this.comboBoxEstado.TabIndex = 50;
            // 
            // comboBoxTamano
            // 
            this.comboBoxTamano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTamano.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTamano.FormattingEnabled = true;
            this.comboBoxTamano.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.comboBoxTamano.Location = new System.Drawing.Point(866, 46);
            this.comboBoxTamano.Name = "comboBoxTamano";
            this.comboBoxTamano.Size = new System.Drawing.Size(157, 33);
            this.comboBoxTamano.TabIndex = 51;
            // 
            // dataGridViewVerPedidos
            // 
            this.dataGridViewVerPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewVerPedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewVerPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Preventista,
            this.Column5,
            this.Column6,
            this.Column10});
            this.dataGridViewVerPedidos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewVerPedidos.Location = new System.Drawing.Point(13, 291);
            this.dataGridViewVerPedidos.Name = "dataGridViewVerPedidos";
            this.dataGridViewVerPedidos.RowHeadersVisible = false;
            this.dataGridViewVerPedidos.RowHeadersWidth = 51;
            this.dataGridViewVerPedidos.RowTemplate.Height = 24;
            this.dataGridViewVerPedidos.Size = new System.Drawing.Size(1300, 204);
            this.dataGridViewVerPedidos.TabIndex = 40;
            this.dataGridViewVerPedidos.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pedido N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Entrega";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Creación";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Preventista
            // 
            this.Preventista.HeaderText = "Preventista";
            this.Preventista.MinimumWidth = 6;
            this.Preventista.Name = "Preventista";
            this.Preventista.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Monto Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Saldo";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 125;
            // 
            // dataGridViewDetallePagos
            // 
            this.dataGridViewDetallePagos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewDetallePagos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallePagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewDetallePagos.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDetallePagos.Location = new System.Drawing.Point(27, 291);
            this.dataGridViewDetallePagos.Name = "dataGridViewDetallePagos";
            this.dataGridViewDetallePagos.RowHeadersWidth = 51;
            this.dataGridViewDetallePagos.RowTemplate.Height = 24;
            this.dataGridViewDetallePagos.Size = new System.Drawing.Size(1266, 59);
            this.dataGridViewDetallePagos.TabIndex = 41;
            this.dataGridViewDetallePagos.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cliente";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fecha";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Monto";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Método Pago";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "N° Pedido";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn10});
            this.dgvClientes.Location = new System.Drawing.Point(12, 330);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1294, 104);
            this.dgvClientes.TabIndex = 42;
            this.dgvClientes.Visible = false;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Zona";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Calle";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Número";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Cgo Postal";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1024, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 55);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormClienteHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 585);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dataGridViewDetallePagos);
            this.Controls.Add(this.dataGridViewVerPedidos);
            this.Controls.Add(this.tableLayoutPanelCliente);
            this.Controls.Add(this.tableLayoutPanelClientes);
            this.Controls.Add(this.TLPHeader);
            this.Name = "FormClienteHistorial";
            this.Text = "Historial de Clientes";
            this.TLPHeader.ResumeLayout(false);
            this.TLPHeader.PerformLayout();
            this.tableLayoutPanelCliente.ResumeLayout(false);
            this.tableLayoutPanelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            this.tableLayoutPanelClientes.ResumeLayout(false);
            this.tableLayoutPanelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCliente;
        private System.Windows.Forms.TextBox txtBusacarEmail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblLetraApellido;
        private System.Windows.Forms.TextBox textBoxBUSCARGENERAL;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClientes;
        private System.Windows.Forms.TextBox textBoxPreventistas;
        private System.Windows.Forms.Label lblPreventistas;
        private System.Windows.Forms.Label lblZONA;
        private System.Windows.Forms.Button btnListarPagos;
        private System.Windows.Forms.Button btnListarPedidosPendientes;
        private System.Windows.Forms.Button btnPedidosEntregados;
        private System.Windows.Forms.Button btnListarSaldosPendientes;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.ComboBox comboBoxZona;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxTamano;
        private System.Windows.Forms.DataGridView dataGridViewVerPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preventista;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dataGridViewDetallePagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnSalir;
    }
}