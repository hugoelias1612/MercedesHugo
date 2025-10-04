namespace ArimaERP.EmpleadoClientes
{
    partial class FormBajaCliente
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrarCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLetraApellido = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.txtBuscarCuilCuit = new System.Windows.Forms.TextBox();
            this.txtBusacarEmail = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarClienteZona = new System.Windows.Forms.ComboBox();
            this.comboBoxBuscarClientePreventista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarTodosClientes = new System.Windows.Forms.Button();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBajaCliente = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEMAIL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnaZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPreventista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBajaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrarCliente, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1405, 55);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblRegistrarCliente
            // 
            this.lblRegistrarCliente.AutoSize = true;
            this.lblRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistrarCliente.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCliente.Location = new System.Drawing.Point(354, 0);
            this.lblRegistrarCliente.Name = "lblRegistrarCliente";
            this.lblRegistrarCliente.Size = new System.Drawing.Size(696, 55);
            this.lblRegistrarCliente.TabIndex = 0;
            this.lblRegistrarCliente.Text = "Consulta y Baja de Cliente";
            this.lblRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistrarCliente.Click += new System.EventHandler(this.lblRegistrarCliente_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0008F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0008F));
            this.tableLayoutPanel2.Controls.Add(this.lblLetraApellido, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarDni, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarCuilCuit, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBusacarEmail, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBuscarClienteZona, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBuscarClientePreventista, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarTodosClientes, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxApellido, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.26087F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.73913F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1405, 71);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblLetraApellido
            // 
            this.lblLetraApellido.AutoSize = true;
            this.lblLetraApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLetraApellido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraApellido.Location = new System.Drawing.Point(59, 0);
            this.lblLetraApellido.Name = "lblLetraApellido";
            this.lblLetraApellido.Size = new System.Drawing.Size(178, 37);
            this.lblLetraApellido.TabIndex = 4;
            this.lblLetraApellido.Text = "Apellido";
            this.lblLetraApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDni.Location = new System.Drawing.Point(243, 43);
            this.txtBuscarDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(178, 22);
            this.txtBuscarDni.TabIndex = 21;
            // 
            // txtBuscarCuilCuit
            // 
            this.txtBuscarCuilCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCuilCuit.Location = new System.Drawing.Point(427, 43);
            this.txtBuscarCuilCuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCuilCuit.Name = "txtBuscarCuilCuit";
            this.txtBuscarCuilCuit.Size = new System.Drawing.Size(178, 22);
            this.txtBuscarCuilCuit.TabIndex = 23;
            // 
            // txtBusacarEmail
            // 
            this.txtBusacarEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusacarEmail.Location = new System.Drawing.Point(611, 43);
            this.txtBusacarEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusacarEmail.Name = "txtBusacarEmail";
            this.txtBusacarEmail.Size = new System.Drawing.Size(178, 22);
            this.txtBusacarEmail.TabIndex = 25;
            // 
            // comboBoxBuscarClienteZona
            // 
            this.comboBoxBuscarClienteZona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarClienteZona.FormattingEnabled = true;
            this.comboBoxBuscarClienteZona.Location = new System.Drawing.Point(795, 42);
            this.comboBoxBuscarClienteZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBuscarClienteZona.Name = "comboBoxBuscarClienteZona";
            this.comboBoxBuscarClienteZona.Size = new System.Drawing.Size(178, 24);
            this.comboBoxBuscarClienteZona.TabIndex = 27;
            // 
            // comboBoxBuscarClientePreventista
            // 
            this.comboBoxBuscarClientePreventista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarClientePreventista.FormattingEnabled = true;
            this.comboBoxBuscarClientePreventista.Location = new System.Drawing.Point(979, 39);
            this.comboBoxBuscarClientePreventista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBuscarClientePreventista.Name = "comboBoxBuscarClientePreventista";
            this.comboBoxBuscarClientePreventista.Size = new System.Drawing.Size(178, 24);
            this.comboBoxBuscarClientePreventista.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "CUIL/CUIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "EMAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 37);
            this.label5.TabIndex = 34;
            this.label5.Text = "ZONA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(979, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 37);
            this.label6.TabIndex = 35;
            this.label6.Text = "PREVENTISTA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarTodosClientes
            // 
            this.btnBuscarTodosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTodosClientes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTodosClientes.Location = new System.Drawing.Point(1163, 39);
            this.btnBuscarTodosClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarTodosClientes.Name = "btnBuscarTodosClientes";
            this.btnBuscarTodosClientes.Size = new System.Drawing.Size(178, 30);
            this.btnBuscarTodosClientes.TabIndex = 30;
            this.btnBuscarTodosClientes.Text = "TODOS";
            this.btnBuscarTodosClientes.UseVisualStyleBackColor = true;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApellido.Location = new System.Drawing.Point(59, 43);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(178, 22);
            this.textBoxApellido.TabIndex = 36;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 103);
            this.panel1.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(583, 26);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(300, 50);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Ver clientes inactivos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewBajaCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 374);
            this.panel2.TabIndex = 10;
            // 
            // dataGridViewBajaCliente
            // 
            this.dataGridViewBajaCliente.AllowUserToDeleteRows = false;
            this.dataGridViewBajaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBajaCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBajaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBajaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaDNI,
            this.ColumnaCUIL,
            this.ColumnaEMAIL,
            this.ColumnaZona,
            this.ColumnaPreventista,
            this.ColumnaModificar,
            this.Column1});
            this.dataGridViewBajaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBajaCliente.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBajaCliente.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBajaCliente.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBajaCliente.MultiSelect = false;
            this.dataGridViewBajaCliente.Name = "dataGridViewBajaCliente";
            this.dataGridViewBajaCliente.ReadOnly = true;
            this.dataGridViewBajaCliente.RowHeadersVisible = false;
            this.dataGridViewBajaCliente.RowHeadersWidth = 51;
            this.dataGridViewBajaCliente.RowTemplate.Height = 24;
            this.dataGridViewBajaCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBajaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBajaCliente.Size = new System.Drawing.Size(1405, 374);
            this.dataGridViewBajaCliente.TabIndex = 8;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaDNI
            // 
            this.ColumnaDNI.HeaderText = "DNI";
            this.ColumnaDNI.MinimumWidth = 6;
            this.ColumnaDNI.Name = "ColumnaDNI";
            this.ColumnaDNI.ReadOnly = true;
            // 
            // ColumnaCUIL
            // 
            this.ColumnaCUIL.HeaderText = "CUIL/CUIT";
            this.ColumnaCUIL.MinimumWidth = 6;
            this.ColumnaCUIL.Name = "ColumnaCUIL";
            this.ColumnaCUIL.ReadOnly = true;
            // 
            // ColumnaEMAIL
            // 
            this.ColumnaEMAIL.HeaderText = "EMAIL";
            this.ColumnaEMAIL.MinimumWidth = 6;
            this.ColumnaEMAIL.Name = "ColumnaEMAIL";
            this.ColumnaEMAIL.ReadOnly = true;
            // 
            // ColumnaZona
            // 
            this.ColumnaZona.HeaderText = "Zona";
            this.ColumnaZona.MinimumWidth = 6;
            this.ColumnaZona.Name = "ColumnaZona";
            this.ColumnaZona.ReadOnly = true;
            // 
            // ColumnaPreventista
            // 
            this.ColumnaPreventista.HeaderText = "Preventista Asignado";
            this.ColumnaPreventista.MinimumWidth = 6;
            this.ColumnaPreventista.Name = "ColumnaPreventista";
            this.ColumnaPreventista.ReadOnly = true;
            // 
            // ColumnaModificar
            // 
            this.ColumnaModificar.HeaderText = "Dar de Baja";
            this.ColumnaModificar.MinimumWidth = 6;
            this.ColumnaModificar.Name = "ColumnaModificar";
            this.ColumnaModificar.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dar de Alta";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBajaCliente";
            this.Text = "FormBajaCliente";
            this.Load += new System.EventHandler(this.FormBajaCliente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBajaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRegistrarCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLetraApellido;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.TextBox txtBuscarCuilCuit;
        private System.Windows.Forms.TextBox txtBusacarEmail;
        private System.Windows.Forms.ComboBox comboBoxBuscarClienteZona;
        private System.Windows.Forms.ComboBox comboBoxBuscarClientePreventista;
        private System.Windows.Forms.Button btnBuscarTodosClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewBajaCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCUIL;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnaEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPreventista;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaModificar;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}