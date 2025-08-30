using System;
using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class MDIProductos : Form
    {
        public MDIProductos()
        {
            InitializeComponent();
        }

        private void TLPBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BStock_Click(object sender, EventArgs e)
        {

        }

        private void BAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BComprar_Click(object sender, EventArgs e)
        {

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {

        }

        private void MDIProducto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void CargarFormEnPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            PContent.Controls.Clear();
            PContent.Controls.Add(frm);
            frm.Show();
        }

        private void BAlerta_Click(object sender, EventArgs e)
        {
            CargarFormEnPanel(new EmpleadoProducto.FormAlerta());
        }
    }
}
