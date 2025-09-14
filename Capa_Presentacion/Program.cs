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
<<<<<<< HEAD

            //Application.Run(new EmpleadoProducto.MDIProductos());
           Application.Run(new EmpleadoClientes.MDIClientes());
=======
            Application.Run(new EmpleadoProducto.MDIProductos());
           //Application.Run(new EmpleadoClientes.MDIClientes());
>>>>>>> 73f7ea7dcd751b002305568bb7a124eb9b8385b8
           // Application.Run(new Administrador.FormRegistrarUsuario());
           //Application.Run(new Administrador.FormAgregarRol());
            //Application.Run(new FormRegistrarUsuario());

        }
    }
}