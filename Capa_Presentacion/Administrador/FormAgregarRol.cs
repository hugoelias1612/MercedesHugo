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

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como retroceso) y no mas de 25 caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar) || textBoxDescripcion.Text.Length >= 25)
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxDescripcion, "Solo se permiten letras y espacios. Máximo 25 caracteres.");
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            //validar que el campo no este vacio
            if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar textBoxDescripcion
            textBoxDescripcion.Clear();
            errorProvider1.Clear();
            textBoxDescripcion.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //si selecciono una fila
            if (dgvRoles.SelectedRows.Count > 0)
            {
                //preguntar si esta seguro de eliminar
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el rol seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //eliminar rol
                    int idRol = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["id_rol"].Value);
                    //llamar al metodo eliminar rol
                    //EliminarRol(idRol);
                    MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
