using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Logica;

namespace ArimaERP.Administrador
{
    public partial class FormAgregarRol : Form
    {
        //INSTANCIAR LOGICA
        ClassRolLogica logicaRol = new ClassRolLogica();
        ClassUsuarioLogica usuarioLog = new ClassUsuarioLogica();
        public FormAgregarRol()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", 9F);
            ConfigurarDataGridView();
            //cargar roles en el datagridview
            CargarRoles();
        }

        private void ConfigurarDataGridView()
        {
            // Configuraciones básicas del DataGridView
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.ReadOnly = false;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.BackgroundColor = Color.White;
            dgvRoles.BorderStyle = BorderStyle.Fixed3D;
            dgvRoles.AutoGenerateColumns = false;

            // Limpiar columnas existentes
            dgvRoles.Columns.Clear();

            // Crear y agregar columna ID
            DataGridViewTextBoxColumn colIdRol = new DataGridViewTextBoxColumn();
            colIdRol.Name = "id_rol";
            colIdRol.HeaderText = "ID";
            colIdRol.DataPropertyName = "id_rol";
            colIdRol.FillWeight = 20;
            colIdRol.ReadOnly = true; // Hacer que la columna ID sea de solo lectura
            dgvRoles.Columns.Add(colIdRol);

            // Crear y agregar columna Descripción
            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.Name = "descripcion";
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.DataPropertyName = "descripcion";
            colDescripcion.FillWeight = 60;
            colDescripcion.ReadOnly = false; // Hacer que la columna Descripción sea de solo lectura
            dgvRoles.Columns.Add(colDescripcion);

            // Columna Estado
            DataGridViewCheckBoxColumn colEstado = new DataGridViewCheckBoxColumn();
            colEstado.Name = "estado";
            colEstado.HeaderText = "Activo";
            colEstado.DataPropertyName = "estado";
            colEstado.FillWeight = 20;
            colEstado.ReadOnly = false; // Hacer que la columna sea editable
            dgvRoles.Columns.Add(colEstado);
            //ocultar columna USUARIOS
            if (dgvRoles.Columns.Contains("USUARIOS"))
            {
                dgvRoles.Columns["USUARIOS"].Visible = false;
            }
        }
        private void CargarRoles()
        {
            List<ROL> listaRoles = ClassRolLogica.ListarRoles();
            dgvRoles.DataSource = listaRoles;
        }
        //cargar id_rol siguiente en textBoxIdRol para agregar un nuevo rol
        private void CargarSiguienteIdRol()
        {
            List<ROL> listaRoles = ClassRolLogica.ListarRoles();
            int siguienteId = 1;
            if (listaRoles.Count > 0)
            {
                siguienteId = listaRoles.Max(r => r.id_rol) + 1;
            }
            textBoxIdROL.Text = siguienteId.ToString();
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
            //descripcion debe ser unico
            List<ROL> listaRoles = ClassRolLogica.ListarRoles();
            if (listaRoles.Any(r => r.descripcion.Equals(textBoxDescripcion.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un rol con esa descripción. Por favor, ingrese una descripción diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //llamar al metodo agregar rol

            if (logicaRol.SalvarRol(textBoxDescripcion.Text.Trim(), "True"))
            {
                MessageBox.Show("Rol agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //recargar datagridview
                CargarRoles();
                //cargar siguiente id_rol
                CargarSiguienteIdRol();
                //limpiar textBoxDescripcion
                textBoxDescripcion.Clear();
                errorProvider1.Clear();
                textBoxDescripcion.Focus();
            }
            else
            {
                // Si ocurre un error al guardar, mostrar mensaje de error

                foreach (var error in logicaRol.ErroresValidacion)
                {
                    MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            //si selecciono una opcion del comboBoxCargarRoles
            if (comboBoxCargarRoles.SelectedIndex != -1)
            {
                int idRol = (int)comboBoxCargarRoles.SelectedValue;
                //preguntar si esta seguro de eliminar el rol
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el rol seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //desativar el rol
                    ROL rolDesactivado = logicaRol.UpdateRol(idRol, comboBoxCargarRoles.Text, "False");
                    if (rolDesactivado != null)
                    {
                        MessageBox.Show("Rol desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //recargar datagridview
                        CargarRoles();
                        //recargar comboBoxCargarRoles
                        List<ROL> listaRoles = ClassRolLogica.ListarRoles().Where(r => r.estado == true).ToList();
                        comboBoxCargarRoles.DataSource = listaRoles;
                        comboBoxCargarRoles.DisplayMember = "descripcion";
                        comboBoxCargarRoles.ValueMember = "id_rol";
                        comboBoxCargarRoles.SelectedIndex = -1; // No seleccionar ningún elemento al cargar
                    }
                    else
                    {
                        // Si ocurre un error al guardar, mostrar mensaje de error
                        foreach (var error in logicaRol.ErroresValidacion)
                        {
                            MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void FormAgregarRol_Load(object sender, EventArgs e)
        {
            //cargar siguiente id_rol
            CargarSiguienteIdRol();
            //cargar roles en comboBoxCargarRoles con estado true
            List<ROL> listaRoles = ClassRolLogica.ListarRoles().Where(r => r.estado == true).ToList();
            comboBoxCargarRoles.DataSource = listaRoles;
            comboBoxCargarRoles.DisplayMember = "descripcion";
            comboBoxCargarRoles.ValueMember = "id_rol";
            comboBoxCargarRoles.SelectedIndex = -1; // No seleccionar ningún elemento al cargar
        }

        private void btnGuardarCAmbios_Click(object sender, EventArgs e)
        {
            //guardar cambios realizados en la fila del focus
            if (dgvRoles.CurrentRow != null)
            {
                int idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["id_rol"].Value);
                string descripcion = dgvRoles.CurrentRow.Cells["descripcion"].Value.ToString();
                string estado = dgvRoles.CurrentRow.Cells["estado"].Value.ToString();
                //validar que el campo no este vacio
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("El campo Descripción no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //descripcion debe ser unico
                List<ROL> listaRoles = ClassRolLogica.ListarRoles();
                if (listaRoles.Any(r => r.descripcion.Equals(descripcion.Trim(), StringComparison.OrdinalIgnoreCase) && r.id_rol != idRol))
                {
                    MessageBox.Show("Ya existe un rol con esa descripción. Por favor, ingrese una descripción diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //llamar al metodo actualizar rol
                ROL rolActualizado = logicaRol.UpdateRol(idRol, descripcion, estado);
                if (rolActualizado != null)
                {
                    MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //recargar datagridview
                    CargarRoles();
                    //recargar comboBoxCargarRoles
                    List<ROL> listaRolesCombo = ClassRolLogica.ListarRoles().Where(r => r.estado == true).ToList();
                    comboBoxCargarRoles.DataSource = listaRolesCombo;
                    comboBoxCargarRoles.DisplayMember = "descripcion";
                    comboBoxCargarRoles.ValueMember = "id_rol";
                    comboBoxCargarRoles.SelectedIndex = -1; // No seleccionar ningún elemento al cargar
                }
                else
                {
                    // Si ocurre un error al guardar, mostrar mensaje de error
                    foreach (var error in logicaRol.ErroresValidacion)
                    {
                        MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada para guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnVerUsuarios_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCargarRoles.SelectedIndex != -1)
            {
                int idRol = Convert.ToInt32(comboBoxCargarRoles.SelectedValue);

                // Verificar si hay usuarios antes de abrir el formulario
                List<USUARIOS> usuarios = usuarioLog.ObtenerUsuariosPorRol(idRol);
                if (usuarios.Count == 0)
                {
                    MessageBox.Show("No hay usuarios con este rol.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Si hay usuarios, abrir el formulario
                FormUsuarios formUsuarios = new FormUsuarios(idRol);
                formUsuarios.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol del menú desplegable para ver sus usuarios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

