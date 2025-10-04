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
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsuarios.HideSelection = false;
            this.listViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(800, 450);
            this.listViewUsuarios.TabIndex = 0;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios según rol";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsuarios;
    }
}