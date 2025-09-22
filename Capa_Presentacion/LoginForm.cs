using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArimaERP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            
            //convertir TCorreo a int
            int rol = int.Parse(TCorreo.Text);
            //validar campo vacios
            if (string.IsNullOrEmpty(TCorreo.Text) || string.IsNullOrEmpty(TContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                //switch case para abrir el formulario segun el rol del TCorreo
                switch (rol)
                {
                    case 1:
                        
                        //abrir formulario administrador
                        Administrador.FormPanelAdministrador mdiAdmin = new Administrador.FormPanelAdministrador();
                        //Centrar formulario
                        mdiAdmin.StartPosition = FormStartPosition.CenterScreen;
                        FormClosedEventHandler value1 = (s, args) => this.Show();
                        FormClosedEventHandler value = value1;
                        mdiAdmin.FormClosed += value;
                        mdiAdmin.Show();
                        //limpiar login
                        TCorreo.Clear();
                        TContrasena.Clear();
                        this.Hide();
                        break;
                    case 2:
                        //abrir formulario preventista
                        Preventista.MDIPreventista mdiPreventista = new Preventista.MDIPreventista();
                        mdiPreventista.StartPosition = FormStartPosition.CenterScreen;
                        FormClosedEventHandler val1 = (s, args) => this.Show();
                        FormClosedEventHandler valu = val1;
                        mdiPreventista.FormClosed += valu;
                        mdiPreventista.Show();
                        TCorreo.Clear();
                        TContrasena.Clear();
                        this.Hide();
                        break;
                    case 3:
                        //abrir formulario empleado de productos
                        EmpleadoProducto.MDIProductos mdiProductos = new EmpleadoProducto.MDIProductos();
                        mdiProductos.StartPosition = FormStartPosition.CenterScreen;
                        FormClosedEventHandler value2 = (s, args) => this.Show();
                        FormClosedEventHandler val = value2;
                        mdiProductos.FormClosed += val;
                        mdiProductos.Show();
                        TCorreo.Clear();
                        TContrasena.Clear();
                        this.Hide();
                        break;
                    case 4:
                        //abrir formulario empleado de clientes
                        EmpleadoClientes.MDIClientes mdiClientes = new EmpleadoClientes.MDIClientes();
                        FormClosedEventHandler value3 = (s, args) => this.Show();
                        FormClosedEventHandler va = value3;
                        mdiClientes.FormClosed += va;
                        mdiClientes.Show();
                        TCorreo.Clear();
                        TContrasena.Clear();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Rol no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
                
    }
}
