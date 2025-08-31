using System.Windows.Forms;

namespace ArimaERP.Empleado_Producto
{
    public partial class MDIProductos : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIProductos));
            this.TLPBody = new System.Windows.Forms.TableLayoutPanel();
            this.TLPBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BPerfil = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BComprar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BStock = new System.Windows.Forms.Button();
            this.BABM = new System.Windows.Forms.Button();
            this.BAlerta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TLPBody.SuspendLayout();
            this.TLPBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPBody
            // 
            this.TLPBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TLPBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TLPBody.ColumnCount = 1;
            this.TLPBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBody.Controls.Add(this.TLPBotones, 0, 0);
            this.TLPBody.Controls.Add(this.panel1, 0, 1);
            this.TLPBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBody.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLPBody.Location = new System.Drawing.Point(0, 0);
            this.TLPBody.Margin = new System.Windows.Forms.Padding(0);
            this.TLPBody.Name = "TLPBody";
            this.TLPBody.RowCount = 2;
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06902F));
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.93098F));
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLPBody.Size = new System.Drawing.Size(1685, 838);
            this.TLPBody.TabIndex = 0;
            this.TLPBody.Paint += new System.Windows.Forms.PaintEventHandler(this.TLPBody_Paint);
            // 
            // TLPBotones
            // 
            this.TLPBotones.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TLPBotones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TLPBotones.ColumnCount = 12;
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.31354F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.234363F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.TLPBotones.Controls.Add(this.BPerfil, 10, 0);
            this.TLPBotones.Controls.Add(this.BSalir, 11, 0);
            this.TLPBotones.Controls.Add(this.BComprar, 5, 0);
            this.TLPBotones.Controls.Add(this.BBuscar, 4, 0);
            this.TLPBotones.Controls.Add(this.BAgregar, 3, 0);
            this.TLPBotones.Controls.Add(this.BStock, 2, 0);
            this.TLPBotones.Controls.Add(this.BABM, 1, 0);
            this.TLPBotones.Controls.Add(this.BAlerta, 0, 0);
            this.TLPBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBotones.Location = new System.Drawing.Point(0, 12);
            this.TLPBotones.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.TLPBotones.Name = "TLPBotones";
            this.TLPBotones.RowCount = 1;
            this.TLPBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBotones.Size = new System.Drawing.Size(1685, 97);
            this.TLPBotones.TabIndex = 0;
            // 
            // BPerfil
            // 
            this.BPerfil.BackColor = System.Drawing.SystemColors.Window;
            this.BPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BPerfil.BackgroundImage")));
            this.BPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPerfil.Location = new System.Drawing.Point(1402, 3);
            this.BPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BPerfil.Name = "BPerfil";
            this.BPerfil.Size = new System.Drawing.Size(133, 91);
            this.BPerfil.TabIndex = 20;
            this.BPerfil.UseVisualStyleBackColor = false;
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.SystemColors.Window;
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(1543, 5);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(137, 87);
            this.BSalir.TabIndex = 16;
            this.BSalir.UseVisualStyleBackColor = false;
            // 
            // BComprar
            // 
            this.BComprar.BackColor = System.Drawing.SystemColors.Window;
            this.BComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BComprar.BackgroundImage")));
            this.BComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BComprar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprar.Location = new System.Drawing.Point(704, 3);
            this.BComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BComprar.Name = "BComprar";
            this.BComprar.Size = new System.Drawing.Size(133, 91);
            this.BComprar.TabIndex = 8;
            this.BComprar.UseVisualStyleBackColor = false;
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.BBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscar.BackgroundImage")));
            this.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.Location = new System.Drawing.Point(564, 3);
            this.BBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(133, 91);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.BAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAgregar.BackgroundImage")));
            this.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Location = new System.Drawing.Point(424, 3);
            this.BAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(133, 91);
            this.BAgregar.TabIndex = 3;
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BStock
            // 
            this.BStock.BackColor = System.Drawing.SystemColors.Window;
            this.BStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BStock.BackgroundImage")));
            this.BStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BStock.Location = new System.Drawing.Point(284, 3);
            this.BStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BStock.Name = "BStock";
            this.BStock.Size = new System.Drawing.Size(133, 91);
            this.BStock.TabIndex = 2;
            this.BStock.UseVisualStyleBackColor = false;
            this.BStock.Click += new System.EventHandler(this.BStock_Click);
            // 
            // BABM
            // 
            this.BABM.BackColor = System.Drawing.SystemColors.Window;
            this.BABM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BABM.BackgroundImage")));
            this.BABM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BABM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BABM.Location = new System.Drawing.Point(144, 3);
            this.BABM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BABM.Name = "BABM";
            this.BABM.Size = new System.Drawing.Size(133, 91);
            this.BABM.TabIndex = 1;
            this.BABM.UseVisualStyleBackColor = false;
            // 
            // BAlerta
            // 
            this.BAlerta.BackColor = System.Drawing.SystemColors.Window;
            this.BAlerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAlerta.BackgroundImage")));
            this.BAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAlerta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAlerta.Location = new System.Drawing.Point(4, 3);
            this.BAlerta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAlerta.Name = "BAlerta";
            this.BAlerta.Size = new System.Drawing.Size(133, 91);
            this.BAlerta.TabIndex = 0;
            this.BAlerta.Text = "\r\n";
            this.BAlerta.UseVisualStyleBackColor = false;
            this.BAlerta.Click += new System.EventHandler(this.BAlerta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 717);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // MDIProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.TLPBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MDIProductos";
            this.Text = "Arima ERP - Empleado Productos";
            this.Load += new System.EventHandler(this.MDIProducto_Load);
            this.TLPBody.ResumeLayout(false);
            this.TLPBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPBody;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Timer timer1;
        private Panel panel1;
        private TableLayoutPanel TLPBotones;
        private Button BPerfil;
        private Button BSalir;
        private Button BComprar;
        private Button BBuscar;
        private Button BAgregar;
        private Button BStock;
        private Button BABM;
        private Button BAlerta;
    }
}