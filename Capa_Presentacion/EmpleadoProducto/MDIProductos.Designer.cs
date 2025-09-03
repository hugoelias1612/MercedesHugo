namespace ArimaERP.EmpleadoProducto
{
    partial class MDIProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFMP = new System.Windows.Forms.Button();
            this.btnABM = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.pnlVista = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlVista.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnFMP);
            this.panel1.Controls.Add(this.btnABM);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnAlerta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 112);
            this.panel1.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(659, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 25);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(659, 40);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(42, 25);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol:";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(659, 8);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 25);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = global::ArimaERP.Properties.Resources.salir_reducido;
            this.btnSalir.Location = new System.Drawing.Point(1150, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 110);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(448, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 15, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 110);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnFMP
            // 
            this.btnFMP.BackColor = System.Drawing.SystemColors.Window;
            this.btnFMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFMP.Image = ((System.Drawing.Image)(resources.GetObject("btnFMP.Image")));
            this.btnFMP.Location = new System.Drawing.Point(336, 0);
            this.btnFMP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFMP.Name = "btnFMP";
            this.btnFMP.Size = new System.Drawing.Size(112, 110);
            this.btnFMP.TabIndex = 3;
            this.btnFMP.UseVisualStyleBackColor = false;
            // 
            // btnABM
            // 
            this.btnABM.BackColor = System.Drawing.SystemColors.Window;
            this.btnABM.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnABM.Image = ((System.Drawing.Image)(resources.GetObject("btnABM.Image")));
            this.btnABM.Location = new System.Drawing.Point(224, 0);
            this.btnABM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(112, 110);
            this.btnABM.TabIndex = 2;
            this.btnABM.UseVisualStyleBackColor = false;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.SystemColors.Window;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.Location = new System.Drawing.Point(112, 0);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(112, 110);
            this.btnStock.TabIndex = 1;
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnAlerta
            // 
            this.btnAlerta.BackColor = System.Drawing.SystemColors.Window;
            this.btnAlerta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlerta.Image = global::ArimaERP.Properties.Resources.alerta_reducido;
            this.btnAlerta.Location = new System.Drawing.Point(0, 0);
            this.btnAlerta.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(112, 110);
            this.btnAlerta.TabIndex = 0;
            this.btnAlerta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlerta.UseVisualStyleBackColor = false;
            this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
            // 
            // pnlVista
            // 
            this.pnlVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.pnlVista.Controls.Add(this.pnlContent);
            this.pnlVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVista.Location = new System.Drawing.Point(0, 112);
            this.pnlVista.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVista.Name = "pnlVista";
            this.pnlVista.Size = new System.Drawing.Size(1264, 569);
            this.pnlVista.TabIndex = 4;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1264, 569);
            this.pnlContent.TabIndex = 2;
            // 
            // MDIProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlVista);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIProductos";
            this.Text = "MDIProductos";
            this.Load += new System.EventHandler(this.MDIProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFMP;
        private System.Windows.Forms.Button btnABM;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlVista;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRol;
    }
}