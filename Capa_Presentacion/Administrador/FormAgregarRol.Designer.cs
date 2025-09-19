namespace ArimaERP.Administrador
{
    partial class FormAgregarRol
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxListaRoles = new System.Windows.Forms.GroupBox();
            this.tlpDataAcciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.tlpBotonesAlcance = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlcance = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGestion = new System.Windows.Forms.GroupBox();
            this.tlpGestion = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdRol = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxEliminar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxListaRoles.SuspendLayout();
            this.tlpDataAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.tlpBotonesAlcance.SuspendLayout();
            this.gbxGestion.SuspendLayout();
            this.tlpGestion.SuspendLayout();
            this.gbxEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.gbxListaRoles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxGestion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxListaRoles
            // 
            this.gbxListaRoles.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxListaRoles.Controls.Add(this.tlpDataAcciones);
            this.gbxListaRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxListaRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaRoles.Location = new System.Drawing.Point(3, 3);
            this.gbxListaRoles.Name = "gbxListaRoles";
            this.gbxListaRoles.Size = new System.Drawing.Size(378, 380);
            this.gbxListaRoles.TabIndex = 0;
            this.gbxListaRoles.TabStop = false;
            this.gbxListaRoles.Text = "Lista de Roles";
            // 
            // tlpDataAcciones
            // 
            this.tlpDataAcciones.ColumnCount = 1;
            this.tlpDataAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDataAcciones.Controls.Add(this.dgvRoles, 0, 0);
            this.tlpDataAcciones.Controls.Add(this.tlpBotonesAlcance, 0, 1);
            this.tlpDataAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataAcciones.Location = new System.Drawing.Point(3, 22);
            this.tlpDataAcciones.Name = "tlpDataAcciones";
            this.tlpDataAcciones.RowCount = 2;
            this.tlpDataAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDataAcciones.Size = new System.Drawing.Size(372, 355);
            this.tlpDataAcciones.TabIndex = 0;
            // 
            // dgvRoles
            // 
            this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rol,
            this.Descripcion,
            this.Estado});
            this.dgvRoles.Location = new System.Drawing.Point(3, 3);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(366, 295);
            this.dgvRoles.TabIndex = 0;
            // 
            // tlpBotonesAlcance
            // 
            this.tlpBotonesAlcance.ColumnCount = 2;
            this.tlpBotonesAlcance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.16393F));
            this.tlpBotonesAlcance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.83607F));
            this.tlpBotonesAlcance.Controls.Add(this.btnVerUsuarios, 1, 0);
            this.tlpBotonesAlcance.Controls.Add(this.btnAlcance, 0, 0);
            this.tlpBotonesAlcance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotonesAlcance.Location = new System.Drawing.Point(3, 304);
            this.tlpBotonesAlcance.Name = "tlpBotonesAlcance";
            this.tlpBotonesAlcance.RowCount = 1;
            this.tlpBotonesAlcance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesAlcance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotonesAlcance.Size = new System.Drawing.Size(366, 48);
            this.tlpBotonesAlcance.TabIndex = 1;
            // 
            // btnAlcance
            // 
            this.btnAlcance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlcance.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAlcance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlcance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlcance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlcance.Location = new System.Drawing.Point(3, 9);
            this.btnAlcance.Name = "btnAlcance";
            this.btnAlcance.Size = new System.Drawing.Size(140, 29);
            this.btnAlcance.TabIndex = 0;
            this.btnAlcance.Text = "Ver Alcance";
            this.btnAlcance.UseVisualStyleBackColor = false;
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerUsuarios.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerUsuarios.Location = new System.Drawing.Point(159, 10);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(193, 28);
            this.btnVerUsuarios.TabIndex = 1;
            this.btnVerUsuarios.Text = "Ver Usuarios con este Rol";
            this.btnVerUsuarios.UseVisualStyleBackColor = false;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "Id del Rol";
            this.id_rol.Name = "id_rol";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // gbxGestion
            // 
            this.gbxGestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGestion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gbxGestion.Controls.Add(this.button1);
            this.gbxGestion.Controls.Add(this.gbxEliminar);
            this.gbxGestion.Controls.Add(this.tlpGestion);
            this.gbxGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGestion.Location = new System.Drawing.Point(387, 3);
            this.gbxGestion.Name = "gbxGestion";
            this.gbxGestion.Size = new System.Drawing.Size(309, 380);
            this.gbxGestion.TabIndex = 1;
            this.gbxGestion.TabStop = false;
            this.gbxGestion.Text = "Gestion de Roles";
            // 
            // tlpGestion
            // 
            this.tlpGestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpGestion.ColumnCount = 2;
            this.tlpGestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tlpGestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpGestion.Controls.Add(this.textBox2, 1, 1);
            this.tlpGestion.Controls.Add(this.lblIdRol, 0, 0);
            this.tlpGestion.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpGestion.Controls.Add(this.textBox1, 1, 0);
            this.tlpGestion.Controls.Add(this.btnAgregarRol, 1, 3);
            this.tlpGestion.Controls.Add(this.btnLimpiar, 0, 3);
            this.tlpGestion.Location = new System.Drawing.Point(6, 25);
            this.tlpGestion.Name = "tlpGestion";
            this.tlpGestion.RowCount = 4;
            this.tlpGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGestion.Size = new System.Drawing.Size(297, 133);
            this.tlpGestion.TabIndex = 0;
            // 
            // lblIdRol
            // 
            this.lblIdRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Location = new System.Drawing.Point(39, 7);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(54, 20);
            this.lblIdRol.TabIndex = 0;
            this.lblIdRol.Text = "ID Rol";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(159, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(136, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarRol.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarRol.Location = new System.Drawing.Point(136, 97);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(158, 28);
            this.btnAgregarRol.TabIndex = 4;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 93);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 37);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // gbxEliminar
            // 
            this.gbxEliminar.BackColor = System.Drawing.Color.Aquamarine;
            this.gbxEliminar.Controls.Add(this.btnEliminar);
            this.gbxEliminar.Controls.Add(this.label1);
            this.gbxEliminar.Controls.Add(this.comboBox1);
            this.gbxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEliminar.Location = new System.Drawing.Point(0, 176);
            this.gbxEliminar.Name = "gbxEliminar";
            this.gbxEliminar.Size = new System.Drawing.Size(324, 155);
            this.gbxEliminar.TabIndex = 1;
            this.gbxEliminar.TabStop = false;
            this.gbxEliminar.Text = "Eliminar Rol Existente";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el rol a eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.Location = new System.Drawing.Point(76, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Rol";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(64, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar Cambios.";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormAgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(699, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAgregarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_Baja Roles de Usuario";
            this.Load += new System.EventHandler(this.FormAgregarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxListaRoles.ResumeLayout(false);
            this.tlpDataAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.tlpBotonesAlcance.ResumeLayout(false);
            this.gbxGestion.ResumeLayout(false);
            this.tlpGestion.ResumeLayout(false);
            this.tlpGestion.PerformLayout();
            this.gbxEliminar.ResumeLayout(false);
            this.gbxEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxListaRoles;
        private System.Windows.Forms.TableLayoutPanel tlpDataAcciones;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesAlcance;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnAlcance;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox gbxGestion;
        private System.Windows.Forms.TableLayoutPanel tlpGestion;
        private System.Windows.Forms.GroupBox gbxEliminar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblIdRol;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}