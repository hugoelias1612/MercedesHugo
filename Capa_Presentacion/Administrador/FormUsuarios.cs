using Capa_Entidades;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.Administrador
{
    public partial class FormUsuarios : Form
    {       
        private ClassUsuarioLogica usuarioLog = new ClassUsuarioLogica();
        //obtener todos los roles
        private ClassRolLogica rolLogica = new ClassRolLogica();        

        private int rolActual;
        public FormUsuarios(int id_rol)
        {
            InitializeComponent();
            rolActual = id_rol;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            // Cargar los usuarios con el rolActual en el dataGridViewUsuariosRol
            try
            {
                // Obtener la lista de usuarios con el rol actual
                List<USUARIOS> listaUsuarios = usuarioLog.ObtenerUsuariosPorRol(rolActual);
                
                // Limpiar el DataGridView antes de cargar nuevos datos
                dataGridViewUsuariosRol.Rows.Clear();
                dataGridViewUsuariosRol.Columns.Clear();

                // Configurar columnas (puede ajustarse según tus propiedades)
                dataGridViewUsuariosRol.Columns.Add("Nombre", "Nombre");
                dataGridViewUsuariosRol.Columns.Add("Estado", "Estado");
                dataGridViewUsuariosRol.Columns.Add("Rol", "Rol");

                List<ROL> roles = ClassRolLogica.ListarRoles();
                // Cargar los datos
                foreach (var usuario in listaUsuarios)
                {
                    string nombre = usuario.nombre;
                    string estado = usuario.estado ? "Activo" : "Inactivo";
                    // traer descripcion de cada rol en el dataGrid
                    string  descripcionRol = roles.FirstOrDefault(r => r.id_rol == usuario.id_rol)?.descripcion ?? "Rol desconocido";

                    dataGridViewUsuariosRol.Rows.Add(usuario.nombre, estado, descripcionRol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
