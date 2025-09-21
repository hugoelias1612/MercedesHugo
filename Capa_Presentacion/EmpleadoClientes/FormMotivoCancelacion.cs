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
    public partial class FormMotivoCancelacion : Form
    {
        public string DatoIngresado { get; private set; }
        public FormMotivoCancelacion()
        {
            InitializeComponent();
        }

        private void FormMotivoCancelacion_Load(object sender, EventArgs e)
        {
            txtDato.Focus();
            //Crear un textbox para ingresar el motivo de la cancelación
            txtDato.Text = "";

        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            DatoIngresado = txtDato.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
