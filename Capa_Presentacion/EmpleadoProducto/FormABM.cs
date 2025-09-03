using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class FormABM : Form
    {
        public FormABM()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private enum Vista { Alta, Baja, Modificacion }

        private void MostrarVista(Vista v)
        {
            // Aseguramos que solo 1 vista esté visible
            PAlta.Visible = (v == Vista.Alta);
            PBaja.Visible = (v == Vista.Baja);
           // PModLista.Visible = (v == Vista.Modificacion);

            // Y traemos al frente la vista activa
            switch (v)
            {
                case Vista.Alta: PAlta.BringToFront(); break;
                case Vista.Baja: PBaja.BringToFront(); break;
                //case Vista.Modificacion: PModLista.BringToFront(); break;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Alta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Baja);
        }
    }
}
