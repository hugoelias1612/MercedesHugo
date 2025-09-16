namespace ArimaERP.Administrador
{
    partial class FormPanelAdministrador
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
            this.TLPMAIN = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMDIiClientes = new System.Windows.Forms.GroupBox();
            this.gbxMDIProductos = new System.Windows.Forms.GroupBox();
            this.gbxMDIPreventista = new System.Windows.Forms.GroupBox();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPreventista = new System.Windows.Forms.Button();
            this.Accion1 = new System.Windows.Forms.Button();
            this.Accion2 = new System.Windows.Forms.Button();
            this.Accion3 = new System.Windows.Forms.Button();
            this.Accion4 = new System.Windows.Forms.Button();
            this.TLPHeader = new System.Windows.Forms.TableLayoutPanel();
            this.TLPFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblDerechos = new System.Windows.Forms.Label();
            this.lblSoporte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TLPMAIN.SuspendLayout();
            this.gbxMDIiClientes.SuspendLayout();
            this.gbxMDIProductos.SuspendLayout();
            this.gbxMDIPreventista.SuspendLayout();
            this.gbxAdmin.SuspendLayout();
            this.TLPHeader.SuspendLayout();
            this.TLPFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMAIN
            // 
            this.TLPMAIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TLPMAIN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TLPMAIN.ColumnCount = 2;
            this.TLPMAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMAIN.Controls.Add(this.gbxAdmin, 1, 1);
            this.TLPMAIN.Controls.Add(this.gbxMDIPreventista, 0, 1);
            this.TLPMAIN.Controls.Add(this.gbxMDIProductos, 1, 0);
            this.TLPMAIN.Controls.Add(this.gbxMDIiClientes, 0, 0);
            this.TLPMAIN.Location = new System.Drawing.Point(131, 139);
            this.TLPMAIN.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TLPMAIN.Name = "TLPMAIN";
            this.TLPMAIN.RowCount = 2;
            this.TLPMAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMAIN.Size = new System.Drawing.Size(1000, 453);
            this.TLPMAIN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración Central.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxMDIiClientes
            // 
            this.gbxMDIiClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxMDIiClientes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxMDIiClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxMDIiClientes.Controls.Add(this.btnClientes);
            this.gbxMDIiClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMDIiClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxMDIiClientes.Location = new System.Drawing.Point(71, 21);
            this.gbxMDIiClientes.Name = "gbxMDIiClientes";
            this.gbxMDIiClientes.Size = new System.Drawing.Size(357, 184);
            this.gbxMDIiClientes.TabIndex = 2;
            this.gbxMDIiClientes.TabStop = false;
            this.gbxMDIiClientes.Text = "Ir a MDI Clientes";
            // 
            // gbxMDIProductos
            // 
            this.gbxMDIProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxMDIProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxMDIProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxMDIProductos.Controls.Add(this.btnProductos);
            this.gbxMDIProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMDIProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxMDIProductos.Location = new System.Drawing.Point(571, 21);
            this.gbxMDIProductos.Name = "gbxMDIProductos";
            this.gbxMDIProductos.Size = new System.Drawing.Size(357, 184);
            this.gbxMDIProductos.TabIndex = 3;
            this.gbxMDIProductos.TabStop = false;
            this.gbxMDIProductos.Text = "Ir a MDI Productos";
            // 
            // gbxMDIPreventista
            // 
            this.gbxMDIPreventista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxMDIPreventista.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxMDIPreventista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxMDIPreventista.Controls.Add(this.btnPreventista);
            this.gbxMDIPreventista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMDIPreventista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxMDIPreventista.Location = new System.Drawing.Point(71, 247);
            this.gbxMDIPreventista.Name = "gbxMDIPreventista";
            this.gbxMDIPreventista.Size = new System.Drawing.Size(357, 184);
            this.gbxMDIPreventista.TabIndex = 3;
            this.gbxMDIPreventista.TabStop = false;
            this.gbxMDIPreventista.Text = "Ir a MDI Preventista";
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAdmin.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAdmin.Controls.Add(this.Accion4);
            this.gbxAdmin.Controls.Add(this.Accion3);
            this.gbxAdmin.Controls.Add(this.Accion2);
            this.gbxAdmin.Controls.Add(this.Accion1);
            this.gbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxAdmin.Location = new System.Drawing.Point(571, 230);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(357, 218);
            this.gbxAdmin.TabIndex = 4;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "Funciones Administrador";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Navy;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(101, 65);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(152, 61);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Acceder";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Navy;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.Location = new System.Drawing.Point(102, 62);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(152, 61);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Acceder";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnPreventista
            // 
            this.btnPreventista.BackColor = System.Drawing.Color.Navy;
            this.btnPreventista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreventista.Location = new System.Drawing.Point(102, 62);
            this.btnPreventista.Name = "btnPreventista";
            this.btnPreventista.Size = new System.Drawing.Size(152, 61);
            this.btnPreventista.TabIndex = 1;
            this.btnPreventista.Text = "Acceder";
            this.btnPreventista.UseVisualStyleBackColor = false;
            // 
            // Accion1
            // 
            this.Accion1.BackColor = System.Drawing.Color.DarkCyan;
            this.Accion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accion1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accion1.Location = new System.Drawing.Point(37, 30);
            this.Accion1.Name = "Accion1";
            this.Accion1.Size = new System.Drawing.Size(289, 35);
            this.Accion1.TabIndex = 0;
            this.Accion1.Text = "Registrar Usuario";
            this.Accion1.UseVisualStyleBackColor = false;
            // 
            // Accion2
            // 
            this.Accion2.BackColor = System.Drawing.Color.DarkCyan;
            this.Accion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accion2.Location = new System.Drawing.Point(37, 71);
            this.Accion2.Name = "Accion2";
            this.Accion2.Size = new System.Drawing.Size(289, 35);
            this.Accion2.TabIndex = 1;
            this.Accion2.Text = "Completar";
            this.Accion2.UseVisualStyleBackColor = false;
            // 
            // Accion3
            // 
            this.Accion3.BackColor = System.Drawing.Color.DarkCyan;
            this.Accion3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accion3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accion3.Location = new System.Drawing.Point(37, 112);
            this.Accion3.Name = "Accion3";
            this.Accion3.Size = new System.Drawing.Size(289, 35);
            this.Accion3.TabIndex = 3;
            this.Accion3.Text = "Completar";
            this.Accion3.UseVisualStyleBackColor = false;
            // 
            // Accion4
            // 
            this.Accion4.BackColor = System.Drawing.Color.DarkCyan;
            this.Accion4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accion4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accion4.Location = new System.Drawing.Point(37, 153);
            this.Accion4.Name = "Accion4";
            this.Accion4.Size = new System.Drawing.Size(289, 35);
            this.Accion4.TabIndex = 4;
            this.Accion4.Text = "Completar";
            this.Accion4.UseVisualStyleBackColor = false;
            // 
            // TLPHeader
            // 
            this.TLPHeader.BackColor = System.Drawing.Color.Beige;
            this.TLPHeader.ColumnCount = 2;
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPHeader.Controls.Add(this.label2, 0, 1);
            this.TLPHeader.Controls.Add(this.label4, 1, 1);
            this.TLPHeader.Controls.Add(this.label3, 1, 0);
            this.TLPHeader.Controls.Add(this.button1, 0, 0);
            this.TLPHeader.Location = new System.Drawing.Point(0, 0);
            this.TLPHeader.Name = "TLPHeader";
            this.TLPHeader.RowCount = 2;
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPHeader.Size = new System.Drawing.Size(1265, 73);
            this.TLPHeader.TabIndex = 4;
            // 
            // TLPFooter
            // 
            this.TLPFooter.BackColor = System.Drawing.Color.Beige;
            this.TLPFooter.ColumnCount = 2;
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPFooter.Controls.Add(this.lblDerechos, 0, 0);
            this.TLPFooter.Controls.Add(this.lblSoporte, 1, 0);
            this.TLPFooter.Location = new System.Drawing.Point(0, 643);
            this.TLPFooter.Name = "TLPFooter";
            this.TLPFooter.RowCount = 1;
            this.TLPFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPFooter.Size = new System.Drawing.Size(1265, 40);
            this.TLPFooter.TabIndex = 5;
            // 
            // lblDerechos
            // 
            this.lblDerechos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDerechos.AutoSize = true;
            this.lblDerechos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechos.Location = new System.Drawing.Point(31, 5);
            this.lblDerechos.Name = "lblDerechos";
            this.lblDerechos.Size = new System.Drawing.Size(569, 29);
            this.lblDerechos.TabIndex = 3;
            this.lblDerechos.Text = "© 2025 ArimaERP - Todos los derechos reservados";
            // 
            // lblSoporte
            // 
            this.lblSoporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoporte.AutoSize = true;
            this.lblSoporte.BackColor = System.Drawing.Color.Transparent;
            this.lblSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoporte.Location = new System.Drawing.Point(662, 7);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Size = new System.Drawing.Size(573, 25);
            this.lblSoporte.TabIndex = 4;
            this.lblSoporte.Text = "Soporte técnico: soporte@arimaerp.com | (011) 4444-5555";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido, Administrador (ID: admin01)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(780, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Optimizando tu gestión cada día";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Martes, 16 de septiembre de 2025 - 10:34 AM";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(19, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(19, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver al Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormPanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TLPFooter);
            this.Controls.Add(this.TLPHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLPMAIN);
            this.MaximizeBox = false;
            this.Name = "FormPanelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRADOR";
            this.Load += new System.EventHandler(this.FormPanelAdministrador_Load);
            this.TLPMAIN.ResumeLayout(false);
            this.gbxMDIiClientes.ResumeLayout(false);
            this.gbxMDIProductos.ResumeLayout(false);
            this.gbxMDIPreventista.ResumeLayout(false);
            this.gbxAdmin.ResumeLayout(false);
            this.TLPHeader.ResumeLayout(false);
            this.TLPHeader.PerformLayout();
            this.TLPFooter.ResumeLayout(false);
            this.TLPFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMAIN;
        private System.Windows.Forms.GroupBox gbxMDIPreventista;
        private System.Windows.Forms.GroupBox gbxMDIProductos;
        private System.Windows.Forms.GroupBox gbxMDIiClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAdmin;
        private System.Windows.Forms.Button Accion4;
        private System.Windows.Forms.Button Accion3;
        private System.Windows.Forms.Button Accion2;
        private System.Windows.Forms.Button Accion1;
        private System.Windows.Forms.Button btnPreventista;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TableLayoutPanel TLPHeader;
        private System.Windows.Forms.TableLayoutPanel TLPFooter;
        private System.Windows.Forms.Label lblDerechos;
        private System.Windows.Forms.Label lblSoporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}