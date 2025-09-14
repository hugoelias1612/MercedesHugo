using ArimaERP.Administrador;
using System;
using System.Windows.Forms;



namespace ArimaERP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new EmpleadoProducto.MDIProductos());
           Application.Run(new EmpleadoClientes.MDIClientes());
           // Application.Run(new Administrador.FormRegistrarUsuario());
           //Application.Run(new Administrador.FormAgregarRol());
            //Application.Run(new FormRegistrarUsuario());

        }
    }
}