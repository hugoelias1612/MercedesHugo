namespace ArimaERP.EmpleadoProducto
{
    partial class FormAlerta
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
            this.TLPBase = new System.Windows.Forms.TableLayoutPanel();
            this.TLPHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TLPFooter = new System.Windows.Forms.TableLayoutPanel();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BComprar = new System.Windows.Forms.Button();
            this.TLPBody = new System.Windows.Forms.TableLayoutPanel();
            this.CBFamilia = new System.Windows.Forms.ComboBox();
            this.LFamilia = new System.Windows.Forms.Label();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.LAgotados = new System.Windows.Forms.Label();
            this.LCriterio = new System.Windows.Forms.Label();
            this.TLPFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.CBCriterio = new System.Windows.Forms.ComboBox();
            this.NStockMax = new System.Windows.Forms.NumericUpDown();
            this.CBAgotados = new System.Windows.Forms.CheckBox();
            this.TBNombreContiene = new System.Windows.Forms.TextBox();
            this.TLPBase.SuspendLayout();
            this.TLPHeader.SuspendLayout();
            this.TLPFooter.SuspendLayout();
            this.TLPBody.SuspendLayout();
            this.TLPFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NStockMax)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPBase
            // 
            this.TLPBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPBase.ColumnCount = 1;
            this.TLPBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBase.Controls.Add(this.TLPHeader, 0, 0);
            this.TLPBase.Controls.Add(this.TLPFooter, 0, 2);
            this.TLPBase.Controls.Add(this.TLPBody, 0, 1);
            this.TLPBase.Location = new System.Drawing.Point(0, 0);
            this.TLPBase.Name = "TLPBase";
            this.TLPBase.RowCount = 3;
            this.TLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPBase.Size = new System.Drawing.Size(1264, 582);
            this.TLPBase.TabIndex = 0;
            // 
            // TLPHeader
            // 
            this.TLPHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TLPHeader.ColumnCount = 3;
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPHeader.Controls.Add(this.label2, 1, 0);
            this.TLPHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPHeader.Location = new System.Drawing.Point(0, 0);
            this.TLPHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TLPHeader.Name = "TLPHeader";
            this.TLPHeader.RowCount = 1;
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPHeader.Size = new System.Drawing.Size(1264, 58);
            this.TLPHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(409, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Control de Stock Bajo 📦";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TLPFooter
            // 
            this.TLPFooter.AutoSize = true;
            this.TLPFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TLPFooter.ColumnCount = 5;
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.TLPFooter.Controls.Add(this.BLimpiar, 2, 0);
            this.TLPFooter.Controls.Add(this.BBuscar, 1, 0);
            this.TLPFooter.Controls.Add(this.BComprar, 3, 0);
            this.TLPFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPFooter.Location = new System.Drawing.Point(0, 523);
            this.TLPFooter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TLPFooter.Name = "TLPFooter";
            this.TLPFooter.RowCount = 1;
            this.TLPFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPFooter.Size = new System.Drawing.Size(1264, 59);
            this.TLPFooter.TabIndex = 1;
            // 
            // BBuscar
            // 
            this.BBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.BBuscar.Location = new System.Drawing.Point(432, 15);
            this.BBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(100, 28);
            this.BBuscar.TabIndex = 0;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            // 
            // BLimpiar
            // 
            this.BLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.BLimpiar.Location = new System.Drawing.Point(580, 15);
            this.BLimpiar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(100, 28);
            this.BLimpiar.TabIndex = 2;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            // 
            // BComprar
            // 
            this.BComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BComprar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BComprar.Enabled = false;
            this.BComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprar.ForeColor = System.Drawing.SystemColors.Window;
            this.BComprar.Location = new System.Drawing.Point(725, 16);
            this.BComprar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BComprar.Name = "BComprar";
            this.BComprar.Size = new System.Drawing.Size(105, 27);
            this.BComprar.TabIndex = 3;
            this.BComprar.Text = "Comprar";
            this.BComprar.UseVisualStyleBackColor = false;
            // 
            // TLPBody
            // 
            this.TLPBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPBody.ColumnCount = 1;
            this.TLPBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBody.Controls.Add(this.TLPFiltros, 0, 0);
            this.TLPBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBody.Location = new System.Drawing.Point(0, 58);
            this.TLPBody.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TLPBody.Name = "TLPBody";
            this.TLPBody.RowCount = 2;
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04301F));
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.95699F));
            this.TLPBody.Size = new System.Drawing.Size(1264, 465);
            this.TLPBody.TabIndex = 2;
            // 
            // CBFamilia
            // 
            this.CBFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFamilia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CBFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFamilia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFamilia.FormattingEnabled = true;
            this.CBFamilia.Location = new System.Drawing.Point(255, 28);
            this.CBFamilia.Name = "CBFamilia";
            this.CBFamilia.Size = new System.Drawing.Size(120, 21);
            this.CBFamilia.TabIndex = 1;
            // 
            // LFamilia
            // 
            this.LFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LFamilia.AutoSize = true;
            this.LFamilia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFamilia.Location = new System.Drawing.Point(279, 0);
            this.LFamilia.Name = "LFamilia";
            this.LFamilia.Size = new System.Drawing.Size(71, 22);
            this.LFamilia.TabIndex = 0;
            this.LFamilia.Text = "Familia";
            // 
            // LProveedor
            // 
            this.LProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.Location = new System.Drawing.Point(391, 0);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(99, 22);
            this.LProveedor.TabIndex = 3;
            this.LProveedor.Text = "Proveedor";
            // 
            // LNombre
            // 
            this.LNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(524, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(86, 22);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre contiene";
            // 
            // LStock
            // 
            this.LStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(647, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(92, 22);
            this.LStock.TabIndex = 5;
            this.LStock.Text = "StockMax";
            // 
            // LAgotados
            // 
            this.LAgotados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgotados.AutoSize = true;
            this.LAgotados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgotados.Location = new System.Drawing.Point(773, 0);
            this.LAgotados.Name = "LAgotados";
            this.LAgotados.Size = new System.Drawing.Size(92, 22);
            this.LAgotados.TabIndex = 6;
            this.LAgotados.Text = "Agotados";
            // 
            // LCriterio
            // 
            this.LCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LCriterio.AutoSize = true;
            this.LCriterio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCriterio.Location = new System.Drawing.Point(909, 0);
            this.LCriterio.Name = "LCriterio";
            this.LCriterio.Size = new System.Drawing.Size(71, 22);
            this.LCriterio.TabIndex = 7;
            this.LCriterio.Text = "Familia";
            // 
            // TLPFiltros
            // 
            this.TLPFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TLPFiltros.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TLPFiltros.ColumnCount = 8;
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPFiltros.Controls.Add(this.CBCriterio, 6, 1);
            this.TLPFiltros.Controls.Add(this.CBProveedor, 2, 1);
            this.TLPFiltros.Controls.Add(this.LCriterio, 6, 0);
            this.TLPFiltros.Controls.Add(this.LAgotados, 5, 0);
            this.TLPFiltros.Controls.Add(this.LStock, 4, 0);
            this.TLPFiltros.Controls.Add(this.LNombre, 3, 0);
            this.TLPFiltros.Controls.Add(this.LProveedor, 2, 0);
            this.TLPFiltros.Controls.Add(this.LFamilia, 1, 0);
            this.TLPFiltros.Controls.Add(this.CBFamilia, 1, 1);
            this.TLPFiltros.Controls.Add(this.NStockMax, 4, 1);
            this.TLPFiltros.Controls.Add(this.CBAgotados, 5, 1);
            this.TLPFiltros.Controls.Add(this.TBNombreContiene, 3, 1);
            this.TLPFiltros.Location = new System.Drawing.Point(0, 0);
            this.TLPFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.TLPFiltros.Name = "TLPFiltros";
            this.TLPFiltros.RowCount = 2;
            this.TLPFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLPFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLPFiltros.Size = new System.Drawing.Size(1264, 56);
            this.TLPFiltros.TabIndex = 3;
            // 
            // CBProveedor
            // 
            this.CBProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProveedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(381, 28);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(120, 21);
            this.CBProveedor.TabIndex = 11;
            // 
            // CBCriterio
            // 
            this.CBCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBCriterio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CBCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCriterio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCriterio.FormattingEnabled = true;
            this.CBCriterio.Location = new System.Drawing.Point(885, 28);
            this.CBCriterio.Name = "CBCriterio";
            this.CBCriterio.Size = new System.Drawing.Size(120, 21);
            this.CBCriterio.TabIndex = 15;
            // 
            // NStockMax
            // 
            this.NStockMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NStockMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NStockMax.Location = new System.Drawing.Point(633, 28);
            this.NStockMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NStockMax.Name = "NStockMax";
            this.NStockMax.Size = new System.Drawing.Size(120, 22);
            this.NStockMax.TabIndex = 16;
            this.NStockMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CBAgotados
            // 
            this.CBAgotados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBAgotados.AutoSize = true;
            this.CBAgotados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAgotados.Location = new System.Drawing.Point(770, 28);
            this.CBAgotados.Name = "CBAgotados";
            this.CBAgotados.Size = new System.Drawing.Size(98, 21);
            this.CBAgotados.TabIndex = 17;
            this.CBAgotados.Text = "Solo stock 0";
            this.CBAgotados.UseVisualStyleBackColor = true;
            // 
            // TBNombreContiene
            // 
            this.TBNombreContiene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNombreContiene.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreContiene.Location = new System.Drawing.Point(509, 28);
            this.TBNombreContiene.Name = "TBNombreContiene";
            this.TBNombreContiene.Size = new System.Drawing.Size(115, 22);
            this.TBNombreContiene.TabIndex = 18;
            // 
            // FormAlerta
            // 
            this.AcceptButton = this.BBuscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 582);
            this.Controls.Add(this.TLPBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAlerta";
            this.Load += new System.EventHandler(this.FormAlerta_Load);
            this.TLPBase.ResumeLayout(false);
            this.TLPBase.PerformLayout();
            this.TLPHeader.ResumeLayout(false);
            this.TLPHeader.PerformLayout();
            this.TLPFooter.ResumeLayout(false);
            this.TLPBody.ResumeLayout(false);
            this.TLPFiltros.ResumeLayout(false);
            this.TLPFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NStockMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPBase;
        private System.Windows.Forms.TableLayoutPanel TLPHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel TLPFooter;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BComprar;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.TableLayoutPanel TLPBody;
        private System.Windows.Forms.TableLayoutPanel TLPFiltros;
        private System.Windows.Forms.ComboBox CBCriterio;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label LCriterio;
        private System.Windows.Forms.Label LAgotados;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LFamilia;
        private System.Windows.Forms.ComboBox CBFamilia;
        private System.Windows.Forms.NumericUpDown NStockMax;
        private System.Windows.Forms.CheckBox CBAgotados;
        private System.Windows.Forms.TextBox TBNombreContiene;
    }
}