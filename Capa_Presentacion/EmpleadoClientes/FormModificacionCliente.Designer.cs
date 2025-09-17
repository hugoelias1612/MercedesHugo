namespace ArimaERP.EmpleadoClientes
{
    partial class FormModificacionCliente
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
            this.comboBoxLetraApellido = new System.Windows.Forms.ComboBox();
            this.TLPHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLetraApellido = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.txtBuscarCuilCuit = new System.Windows.Forms.TextBox();
            this.txtBusacarEmail = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarClienteZona = new System.Windows.Forms.ComboBox();
            this.comboBoxBuscarClientePreventista = new System.Windows.Forms.ComboBox();
            this.btnBuscarTodosClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEMAIL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnaZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPreventista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLPHeader.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLetraApellido
            // 
            this.comboBoxLetraApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLetraApellido.FormattingEnabled = true;
            this.comboBoxLetraApellido.Location = new System.Drawing.Point(40, 33);
            this.comboBoxLetraApellido.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLetraApellido.Name = "comboBoxLetraApellido";
            this.comboBoxLetraApellido.Size = new System.Drawing.Size(123, 21);
            this.comboBoxLetraApellido.TabIndex = 2;
            // 
            // TLPHeader
            // 
            this.TLPHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TLPHeader.ColumnCount = 1;
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLPHeader.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.TLPHeader.Controls.Add(this.label2, 0, 0);
            this.TLPHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPHeader.Location = new System.Drawing.Point(0, 0);
            this.TLPHeader.Margin = new System.Windows.Forms.Padding(0);
            this.TLPHeader.Name = "TLPHeader";
            this.TLPHeader.RowCount = 2;
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.TLPHeader.Size = new System.Drawing.Size(967, 111);
            this.TLPHeader.TabIndex = 1;
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
            this.tableLayoutPanel2.Controls.Add(this.comboBoxLetraApellido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarDni, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscarCuilCuit, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBusacarEmail, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBuscarClienteZona, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxBuscarClientePreventista, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarTodosClientes, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.26087F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.73913F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(967, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblLetraApellido
            // 
            this.lblLetraApellido.AutoSize = true;
            this.lblLetraApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLetraApellido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraApellido.Location = new System.Drawing.Point(40, 0);
            this.lblLetraApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetraApellido.Name = "lblLetraApellido";
            this.lblLetraApellido.Size = new System.Drawing.Size(123, 30);
            this.lblLetraApellido.TabIndex = 4;
            this.lblLetraApellido.Text = "Letra Apellido";
            this.lblLetraApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDni.Location = new System.Drawing.Point(167, 34);
            this.txtBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(123, 20);
            this.txtBuscarDni.TabIndex = 21;
            this.txtBuscarDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDni_KeyDown);
            // 
            // txtBuscarCuilCuit
            // 
            this.txtBuscarCuilCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCuilCuit.Location = new System.Drawing.Point(294, 34);
            this.txtBuscarCuilCuit.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCuilCuit.Name = "txtBuscarCuilCuit";
            this.txtBuscarCuilCuit.Size = new System.Drawing.Size(123, 20);
            this.txtBuscarCuilCuit.TabIndex = 23;
            // 
            // txtBusacarEmail
            // 
            this.txtBusacarEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusacarEmail.Location = new System.Drawing.Point(421, 34);
            this.txtBusacarEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusacarEmail.Name = "txtBusacarEmail";
            this.txtBusacarEmail.Size = new System.Drawing.Size(123, 20);
            this.txtBusacarEmail.TabIndex = 25;
            // 
            // comboBoxBuscarClienteZona
            // 
            this.comboBoxBuscarClienteZona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarClienteZona.FormattingEnabled = true;
            this.comboBoxBuscarClienteZona.Location = new System.Drawing.Point(548, 33);
            this.comboBoxBuscarClienteZona.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarClienteZona.Name = "comboBoxBuscarClienteZona";
            this.comboBoxBuscarClienteZona.Size = new System.Drawing.Size(123, 21);
            this.comboBoxBuscarClienteZona.TabIndex = 27;
            // 
            // comboBoxBuscarClientePreventista
            // 
            this.comboBoxBuscarClientePreventista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarClientePreventista.FormattingEnabled = true;
            this.comboBoxBuscarClientePreventista.Location = new System.Drawing.Point(675, 32);
            this.comboBoxBuscarClientePreventista.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarClientePreventista.Name = "comboBoxBuscarClientePreventista";
            this.comboBoxBuscarClientePreventista.Size = new System.Drawing.Size(123, 21);
            this.comboBoxBuscarClientePreventista.TabIndex = 29;
            // 
            // btnBuscarTodosClientes
            // 
            this.btnBuscarTodosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTodosClientes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTodosClientes.Location = new System.Drawing.Point(802, 2);
            this.btnBuscarTodosClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarTodosClientes.Name = "btnBuscarTodosClientes";
            this.btnBuscarTodosClientes.Size = new System.Drawing.Size(123, 26);
            this.btnBuscarTodosClientes.TabIndex = 30;
            this.btnBuscarTodosClientes.Text = "TODOS";
            this.btnBuscarTodosClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "CUIL/CUIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "EMAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "ZONA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "PREVENTISTA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaDNI,
            this.ColumnaCUIL,
            this.ColumnaEMAIL,
            this.ColumnaZona,
            this.ColumnaPreventista,
            this.ColumnaModificar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(967, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.ColumnaModificar.HeaderText = "Acción";
            this.ColumnaModificar.MinimumWidth = 6;
            this.ColumnaModificar.Name = "ColumnaModificar";
            this.ColumnaModificar.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 84);
            this.panel1.TabIndex = 3;
            // 
            // FormModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TLPHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModificacionCliente";
            this.Text = "FormModificacionCliente";
            this.Load += new System.EventHandler(this.FormModificacionCliente_Load);
            this.TLPHeader.ResumeLayout(false);
            this.TLPHeader.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxLetraApellido;
        private System.Windows.Forms.TableLayoutPanel TLPHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.TextBox txtBuscarCuilCuit;
        private System.Windows.Forms.TextBox txtBusacarEmail;
        private System.Windows.Forms.ComboBox comboBoxBuscarClienteZona;
        private System.Windows.Forms.ComboBox comboBoxBuscarClientePreventista;
        private System.Windows.Forms.Button btnBuscarTodosClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCUIL;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnaEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPreventista;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLetraApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}