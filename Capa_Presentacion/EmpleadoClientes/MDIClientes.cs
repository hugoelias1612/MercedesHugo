using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoClientes
{
    public partial class MDIClientes : Form
    {
        public MDIClientes()
        {
            InitializeComponent();
        }

        private void MDIClientes_Load(object sender, EventArgs e)
        {
            // Obtener el área de trabajo del monitor principal (sin la barra de tareas)
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            // Establecer el tamaño y posición del formulario
            this.Location = areaTrabajo.Location;
            this.Size = areaTrabajo.Size;
    }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
