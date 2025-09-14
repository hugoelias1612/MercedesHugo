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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iD_rolLabel;
            this.rOLDataGridView = new System.Windows.Forms.DataGridView();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iD_rolTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblAltaRolUsuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            iD_rolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rOLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(489, 228);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(82, 16);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripción:";
            // 
            // iD_rolLabel
            // 
            iD_rolLabel.AutoSize = true;
            iD_rolLabel.Location = new System.Drawing.Point(491, 203);
            iD_rolLabel.Name = "iD_rolLabel";
            iD_rolLabel.Size = new System.Drawing.Size(41, 16);
            iD_rolLabel.TabIndex = 4;
            iD_rolLabel.Text = "ID rol:";
            // 
            // rOLDataGridView
            // 
            this.rOLDataGridView.AllowUserToAddRows = false;
            this.rOLDataGridView.AllowUserToDeleteRows = false;
            this.rOLDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rOLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rOLDataGridView.Location = new System.Drawing.Point(25, 123);
            this.rOLDataGridView.Name = "rOLDataGridView";
            this.rOLDataGridView.ReadOnly = true;
            this.rOLDataGridView.RowHeadersVisible = false;
            this.rOLDataGridView.RowHeadersWidth = 51;
            this.rOLDataGridView.RowTemplate.Height = 24;
            this.rOLDataGridView.Size = new System.Drawing.Size(363, 220);
            this.rOLDataGridView.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(598, 225);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(183, 22);
            this.descripcionTextBox.TabIndex = 3;
            this.descripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcionTextBox_KeyPress);
            // 
            // iD_rolTextBox
            // 
            this.iD_rolTextBox.Location = new System.Drawing.Point(598, 197);
            this.iD_rolTextBox.Name = "iD_rolTextBox";
            this.iD_rolTextBox.Size = new System.Drawing.Size(183, 22);
            this.iD_rolTextBox.TabIndex = 5;
            this.iD_rolTextBox.TextChanged += new System.EventHandler(this.iD_rolTextBox_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(515, 123);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 50);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(690, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 50);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(688, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(515, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 50);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblAltaRolUsuario
            // 
            this.lblAltaRolUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAltaRolUsuario.AutoSize = true;
            this.lblAltaRolUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaRolUsuario.Location = new System.Drawing.Point(376, 32);
            this.lblAltaRolUsuario.Name = "lblAltaRolUsuario";
            this.lblAltaRolUsuario.Size = new System.Drawing.Size(288, 28);
            this.lblAltaRolUsuario.TabIndex = 10;
            this.lblAltaRolUsuario.Text = "ALTA/BAJA ROL DE USUARIO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(932, 475);
            this.Controls.Add(this.lblAltaRolUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(iD_rolLabel);
            this.Controls.Add(this.iD_rolTextBox);
            this.Controls.Add(this.rOLDataGridView);
            this.Name = "FormAgregarRol";
            this.Text = "Alta_Baja Roles de Usuario";
            
            ((System.ComponentModel.ISupportInitialize)(this.rOLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView rOLDataGridView;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iD_rolTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAltaRolUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}