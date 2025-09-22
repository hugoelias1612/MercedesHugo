using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.Administrador
{
    public partial class FormAgregarRol : Form
    {
        public FormAgregarRol()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", 9F);
            ConfigurarDataGridView();
        }

     

        

        private void iD_rolTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)

        {   
           
    }
        private void bloqueo()
        {
    
        }
        private void desbloqueo()
        {
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

       

        private void descripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void FormAgregarRol_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarDataGridView()
        {
            // Configuraciones básicas del DataGridView
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.ReadOnly = true;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.BackgroundColor = Color.White;
            dgvRoles.BorderStyle = BorderStyle.Fixed3D;

            // Limpiar columnas existentes
            dgvRoles.Columns.Clear();

            // Crear y agregar columna ID
            DataGridViewTextBoxColumn colIdRol = new DataGridViewTextBoxColumn();
            colIdRol.Name = "id_rol";
            colIdRol.HeaderText = "ID";
            colIdRol.DataPropertyName = "id_rol";
            colIdRol.FillWeight = 20;
            dgvRoles.Columns.Add(colIdRol);

            // Crear y agregar columna Descripción
            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.Name = "descripcion";
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.FillWeight = 80;
            dgvRoles.Columns.Add(colDescripcion);
        }
    }
}
