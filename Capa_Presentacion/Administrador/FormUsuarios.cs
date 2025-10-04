using Capa_Entidades;
using Capa_Logica;
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
    public partial class FormUsuarios : Form
    {       
        private ClassUsuarioLogica usuarioLog = new ClassUsuarioLogica();
        private int rolActual;
        public FormUsuarios(int id_rol)
        {
            InitializeComponent();
            rolActual = id_rol;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // Cargar los usuarios con el rol actual en el listViewUsuarios
            CargarUsuarios();
        }
       //cargar usuarios si hay usuarios
        private void CargarUsuarios()
        {
            listViewUsuarios.Items.Clear();

            List<USUARIOS> usuarios = usuarioLog.ObtenerUsuariosPorRol(rolActual);

            // Si no hay usuarios, no mostrar mensaje (ya se validó antes de abrir el formulario)
            if (usuarios == null || usuarios.Count == 0)
                return;

            foreach (var usuario in usuarios)
            {
                var item = new ListViewItem(usuario.nombre ?? "Sin nombre");

                item.SubItems.Add(usuario.estado ? "Activo" : "Inactivo");

                string descripcionRol = usuario.ROL?.descripcion ?? "N/A";
                item.SubItems.Add(descripcionRol);

                listViewUsuarios.Items.Add(item);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
