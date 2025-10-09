namespace ArimaERP.Administrador
{
    partial class FormUsuarios
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
            this.dataGridViewUsuariosRol = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuariosRol
            // 
            this.dataGridViewUsuariosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuariosRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewUsuariosRol.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuariosRol.Name = "dataGridViewUsuariosRol";
            this.dataGridViewUsuariosRol.RowHeadersWidth = 51;
            this.dataGridViewUsuariosRol.RowTemplate.Height = 24;
            this.dataGridViewUsuariosRol.Size = new System.Drawing.Size(800, 353);
            this.dataGridViewUsuariosRol.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(547, 397);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewUsuariosRol);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios según rol";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuariosRol;
        private System.Windows.Forms.Button btnVolver;
    }
}