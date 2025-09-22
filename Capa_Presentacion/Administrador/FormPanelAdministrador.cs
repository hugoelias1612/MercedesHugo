using ArimaERP.EmpleadoClientes;
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
    public partial class FormPanelAdministrador : Form
    {
        public FormPanelAdministrador()
        {
            InitializeComponent();
        }

        private void FormPanelAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //volver al login
            this.Close();
          

        }

        private void gbxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //abrir formulario clientes
            MDIClientes mDIClientes = new MDIClientes();
            mDIClientes.StartPosition = FormStartPosition.CenterScreen; 
            mDIClientes.Show();
            this.Hide();
        }
    }
}