using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = true;
            pnlPedidos.Visible = false;
            pnlPreventistas.Visible = false;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            pnlPedidos.Visible = true;
            pnlPreventistas.Visible = false;
        }

        private void btnPreventista_Click(object sender, EventArgs e)
        {
            pnlPedidos.Visible = false;
            pnlClientes.Visible = false;
            pnlPreventistas.Visible = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar nuevo contenido
            pnlVistaMenuSecundario.Controls.Clear();

            // Instanciar el formulario
            FormCliente formCliente = new FormCliente();

            // Configurar como control embebido
            formCliente.TopLevel = false;
            formCliente.FormBorderStyle = FormBorderStyle.None;
            formCliente.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            pnlVistaMenuSecundario.Controls.Add(formCliente);
            formCliente.Show();
        }

        private void btnModificacion_Click_1(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar nuevo contenido
            pnlVistaMenuSecundario.Controls.Clear();
            // Instanciar el formulario
            FormModificacionCliente formModificacionCliente = new FormModificacionCliente();
            // Configurar como control embebido
            formModificacionCliente.TopLevel = false;
            formModificacionCliente.FormBorderStyle = FormBorderStyle.None;
            formModificacionCliente.Dock = DockStyle.Fill;
            // Agregar al panel y mostrar
            pnlVistaMenuSecundario.Controls.Add(formModificacionCliente);
            formModificacionCliente.Show();
        }

        private void btnBajaPreventistas_Click(object sender, EventArgs e)
        {
            // Limpiar el panel antes de agregar nuevo contenido
            pnlVistaMenuSecundario.Controls.Clear();
            // Instanciar el formulario
            FormModificacionCliente formModificacionCliente = new FormModificacionCliente();
            // Configurar como control embebido
            formModificacionCliente.TopLevel = false;
            formModificacionCliente.FormBorderStyle = FormBorderStyle.None;
            formModificacionCliente.Dock = DockStyle.Fill;
            // Agregar al panel y mostrar
            pnlVistaMenuSecundario.Controls.Add(formModificacionCliente);
            formModificacionCliente.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            {
                // Limpiar el panel antes de agregar nuevo contenido
                pnlVistaMenuSecundario.Controls.Clear();
                // Instanciar el formulario
                FormBajaCliente formBajaCliente = new FormBajaCliente();
                // Configurar como control embebido
                formBajaCliente.TopLevel = false;
                formBajaCliente.FormBorderStyle = FormBorderStyle.None;
                formBajaCliente.Dock = DockStyle.Fill;
                // Agregar al panel y mostrar
                pnlVistaMenuSecundario.Controls.Add(formBajaCliente);
                formBajaCliente.Show();
            }
        }
    }
}
