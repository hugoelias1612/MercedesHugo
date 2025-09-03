namespace ArimaERP.EmpleadoProducto
{
    partial class FormABM
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
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PNav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PAlta = new System.Windows.Forms.Panel();
            this.tlpAlta = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnidadesIniciales = new System.Windows.Forms.Label();
            this.lblBultosIniciales = new System.Windows.Forms.Label();
            this.lblUPB = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxFamilia = new System.Windows.Forms.ComboBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.nudUPB = new System.Windows.Forms.NumericUpDown();
            this.nudBultosIniciales = new System.Windows.Forms.NumericUpDown();
            this.nudUnidadesIniciales = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioUnit = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.PBaja = new System.Windows.Forms.Panel();
            this.TLPBaja = new System.Windows.Forms.TableLayoutPanel();
            this.TLPMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PNav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.PAlta.SuspendLayout();
            this.tlpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBultosIniciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidadesIniciales)).BeginInit();
            this.PBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMain
            // 
            this.TLPMain.ColumnCount = 1;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Controls.Add(this.panel1, 0, 0);
            this.TLPMain.Controls.Add(this.PNav, 0, 1);
            this.TLPMain.Controls.Add(this.pnlContenido, 0, 2);
            this.TLPMain.Controls.Add(this.panel2, 0, 3);
            this.TLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMain.Location = new System.Drawing.Point(0, 0);
            this.TLPMain.Margin = new System.Windows.Forms.Padding(0);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 4;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TLPMain.Size = new System.Drawing.Size(1264, 569);
            this.TLPMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(341, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(565, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alta, Baja y Modificacion de Productos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PNav
            // 
            this.PNav.Controls.Add(this.tableLayoutPanel1);
            this.PNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNav.Location = new System.Drawing.Point(0, 51);
            this.PNav.Margin = new System.Windows.Forms.Padding(0);
            this.PNav.Name = "PNav";
            this.PNav.Size = new System.Drawing.Size(1264, 51);
            this.PNav.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnModificacion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBaja, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlta, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlta.Location = new System.Drawing.Point(311, 7);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(133, 36);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.TabStop = false;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaja.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBaja.Location = new System.Drawing.Point(563, 7);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(133, 36);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.TabStop = false;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificacion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificacion.Location = new System.Drawing.Point(815, 7);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(133, 36);
            this.btnModificacion.TabIndex = 4;
            this.btnModificacion.TabStop = false;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlContenido.Controls.Add(this.PBaja);
            this.pnlContenido.Controls.Add(this.PAlta);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(3, 105);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContenido.Size = new System.Drawing.Size(1258, 407);
            this.pnlContenido.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 54);
            this.panel2.TabIndex = 3;
            // 
            // PAlta
            // 
            this.PAlta.Controls.Add(this.tlpAlta);
            this.PAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAlta.Location = new System.Drawing.Point(8, 8);
            this.PAlta.Margin = new System.Windows.Forms.Padding(0);
            this.PAlta.Name = "PAlta";
            this.PAlta.Size = new System.Drawing.Size(1242, 391);
            this.PAlta.TabIndex = 0;
            // 
            // tlpAlta
            // 
            this.tlpAlta.ColumnCount = 4;
            this.tlpAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAlta.Controls.Add(this.lblUnidadesIniciales, 1, 7);
            this.tlpAlta.Controls.Add(this.lblBultosIniciales, 1, 6);
            this.tlpAlta.Controls.Add(this.lblUPB, 1, 5);
            this.tlpAlta.Controls.Add(this.lblPrecio, 1, 4);
            this.tlpAlta.Controls.Add(this.lblMarca, 1, 3);
            this.tlpAlta.Controls.Add(this.lblProveedor, 1, 2);
            this.tlpAlta.Controls.Add(this.lblFamilia, 1, 1);
            this.tlpAlta.Controls.Add(this.lblNombre, 1, 0);
            this.tlpAlta.Controls.Add(this.txtNombre, 2, 0);
            this.tlpAlta.Controls.Add(this.cbxFamilia, 2, 1);
            this.tlpAlta.Controls.Add(this.cbxProveedor, 2, 2);
            this.tlpAlta.Controls.Add(this.cbxMarca, 2, 3);
            this.tlpAlta.Controls.Add(this.nudUPB, 2, 5);
            this.tlpAlta.Controls.Add(this.nudBultosIniciales, 2, 6);
            this.tlpAlta.Controls.Add(this.nudUnidadesIniciales, 2, 7);
            this.tlpAlta.Controls.Add(this.txtPrecioUnit, 2, 4);
            this.tlpAlta.Controls.Add(this.btnCrear, 1, 8);
            this.tlpAlta.Controls.Add(this.btnLimpiar, 2, 8);
            this.tlpAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAlta.Location = new System.Drawing.Point(0, 0);
            this.tlpAlta.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAlta.Name = "tlpAlta";
            this.tlpAlta.RowCount = 9;
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAlta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAlta.Size = new System.Drawing.Size(1242, 391);
            this.tlpAlta.TabIndex = 1;
            // 
            // lblUnidadesIniciales
            // 
            this.lblUnidadesIniciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidadesIniciales.AutoSize = true;
            this.lblUnidadesIniciales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesIniciales.Location = new System.Drawing.Point(350, 274);
            this.lblUnidadesIniciales.Name = "lblUnidadesIniciales";
            this.lblUnidadesIniciales.Size = new System.Drawing.Size(230, 37);
            this.lblUnidadesIniciales.TabIndex = 52;
            this.lblUnidadesIniciales.Text = "Unidades Iniciales";
            // 
            // lblBultosIniciales
            // 
            this.lblBultosIniciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBultosIniciales.AutoSize = true;
            this.lblBultosIniciales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBultosIniciales.Location = new System.Drawing.Point(369, 235);
            this.lblBultosIniciales.Name = "lblBultosIniciales";
            this.lblBultosIniciales.Size = new System.Drawing.Size(191, 37);
            this.lblBultosIniciales.TabIndex = 29;
            this.lblBultosIniciales.Text = "Bultos Iniciales";
            // 
            // lblUPB
            // 
            this.lblUPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUPB.AutoSize = true;
            this.lblUPB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPB.Location = new System.Drawing.Point(341, 196);
            this.lblUPB.Name = "lblUPB";
            this.lblUPB.Size = new System.Drawing.Size(247, 37);
            this.lblUPB.TabIndex = 25;
            this.lblUPB.Text = "Unidades por bulto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(390, 157);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(149, 37);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio unit.";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(420, 118);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(90, 37);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(395, 79);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(139, 37);
            this.lblProveedor.TabIndex = 13;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblFamilia
            // 
            this.lblFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(414, 40);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(101, 37);
            this.lblFamilia.TabIndex = 9;
            this.lblFamilia.Text = "Familia";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(407, 1);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 37);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(632, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 20);
            this.txtNombre.TabIndex = 53;
            // 
            // cbxFamilia
            // 
            this.cbxFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia.FormattingEnabled = true;
            this.cbxFamilia.Location = new System.Drawing.Point(688, 48);
            this.cbxFamilia.Name = "cbxFamilia";
            this.cbxFamilia.Size = new System.Drawing.Size(174, 21);
            this.cbxFamilia.TabIndex = 54;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(688, 87);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(174, 21);
            this.cbxProveedor.TabIndex = 55;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(686, 126);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(178, 21);
            this.cbxMarca.TabIndex = 56;
            // 
            // nudUPB
            // 
            this.nudUPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudUPB.Location = new System.Drawing.Point(715, 204);
            this.nudUPB.Name = "nudUPB";
            this.nudUPB.Size = new System.Drawing.Size(120, 20);
            this.nudUPB.TabIndex = 57;
            // 
            // nudBultosIniciales
            // 
            this.nudBultosIniciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudBultosIniciales.Location = new System.Drawing.Point(715, 243);
            this.nudBultosIniciales.Name = "nudBultosIniciales";
            this.nudBultosIniciales.Size = new System.Drawing.Size(120, 20);
            this.nudBultosIniciales.TabIndex = 59;
            // 
            // nudUnidadesIniciales
            // 
            this.nudUnidadesIniciales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudUnidadesIniciales.Location = new System.Drawing.Point(715, 282);
            this.nudUnidadesIniciales.Name = "nudUnidadesIniciales";
            this.nudUnidadesIniciales.Size = new System.Drawing.Size(120, 20);
            this.nudUnidadesIniciales.TabIndex = 58;
            // 
            // txtPrecioUnit
            // 
            this.txtPrecioUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecioUnit.Location = new System.Drawing.Point(725, 165);
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnit.TabIndex = 60;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrear.Location = new System.Drawing.Point(398, 333);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(133, 36);
            this.btnCrear.TabIndex = 61;
            this.btnCrear.TabStop = false;
            this.btnCrear.Text = "Crear producto";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(708, 333);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 36);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // PBaja
            // 
            this.PBaja.Controls.Add(this.TLPBaja);
            this.PBaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBaja.Location = new System.Drawing.Point(8, 8);
            this.PBaja.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.PBaja.Name = "PBaja";
            this.PBaja.Size = new System.Drawing.Size(1242, 391);
            this.PBaja.TabIndex = 5;
            // 
            // TLPBaja
            // 
            this.TLPBaja.ColumnCount = 2;
            this.TLPBaja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBaja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBaja.Location = new System.Drawing.Point(0, 0);
            this.TLPBaja.Margin = new System.Windows.Forms.Padding(0);
            this.TLPBaja.Name = "TLPBaja";
            this.TLPBaja.RowCount = 1;
            this.TLPBaja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBaja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPBaja.Size = new System.Drawing.Size(1242, 391);
            this.TLPBaja.TabIndex = 0;
            // 
            // FormABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 569);
            this.Controls.Add(this.TLPMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TLPMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PNav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.PAlta.ResumeLayout(false);
            this.tlpAlta.ResumeLayout(false);
            this.tlpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBultosIniciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidadesIniciales)).EndInit();
            this.PBaja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PNav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PAlta;
        private System.Windows.Forms.TableLayoutPanel tlpAlta;
        private System.Windows.Forms.Label lblUnidadesIniciales;
        private System.Windows.Forms.Label lblBultosIniciales;
        private System.Windows.Forms.Label lblUPB;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxFamilia;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.NumericUpDown nudUPB;
        private System.Windows.Forms.NumericUpDown nudBultosIniciales;
        private System.Windows.Forms.NumericUpDown nudUnidadesIniciales;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel PBaja;
        private System.Windows.Forms.TableLayoutPanel TLPBaja;
    }
}