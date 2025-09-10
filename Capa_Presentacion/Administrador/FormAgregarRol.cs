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
        }

        private void rOLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallerProgramacionIIDataSet);

        }

        private void FormaAgregarRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallerProgramacionIIDataSet.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.tallerProgramacionIIDataSet.ROL);

        }

        private void iD_rolTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (completoCampos())
            {
                try
                {
                    rOLBindingSource.EndEdit();
                    rOLTableAdapter.Update(tallerProgramacionIIDataSet.ROL);
                    desbloqueo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message, "Atención");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Atención");
            }
        }
        private bool completoCampos()
        {
            if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)

        {   
            bloqueo();
            // Agregar una nueva fila al BindingSource
            rOLBindingSource.AddNew();
            // Habilitar edición del TextBox de descripción
            descripcionTextBox.ReadOnly = false;
            descripcionTextBox.Text = "";
            descripcionTextBox.Focus();
           

            // Generar automáticamente el siguiente ID_rol (ejemplo: máximo + 1)
            int nuevoId = 1;
            if (tallerProgramacionIIDataSet.ROL.Rows.Count > 0)
            {
                nuevoId = Convert.ToInt32(tallerProgramacionIIDataSet.ROL.AsEnumerable()
                    .Max(row => row.Field<int>("ID_rol"))) + 1;
            }
            iD_rolTextBox.Text = nuevoId.ToString();
            iD_rolTextBox.ReadOnly = true; // Mantener solo lectura si así lo deseas
        
    }
        private void bloqueo()
        {
            rOLDataGridView.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
        }
        private void desbloqueo()
        {
            rOLDataGridView.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rOLBindingSource.CancelEdit();
            desbloqueo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            rOLDataGridView.Enabled = true;
            if (rOLBindingSource.Current != null)
            {
                var result = MessageBox.Show("¿Está seguro que desea eliminar este rol?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        rOLBindingSource.RemoveCurrent();
                        rOLTableAdapter.Update(tallerProgramacionIIDataSet.ROL);
                        MessageBox.Show("Rol eliminado correctamente.", "Información");
                        this.rOLTableAdapter.Fill(this.tallerProgramacionIIDataSet.ROL);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el rol: " + ex.Message, "Atención");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningún rol seleccionado para eliminar.", "Atención");
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convertir a mayúsculas
            e.KeyChar = char.ToUpper(e.KeyChar);
            // Permitir solo letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(descripcionTextBox, "Solo se permiten letras y espacios.");
            }
            else
            {
                errorProvider1.SetError(descripcionTextBox, "");
            }
        }
    }
}
