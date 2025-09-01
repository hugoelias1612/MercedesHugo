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

            // Cambia el formulario de inicio:
<<<<<<< HEAD
            Application.Run(new EmpleadoClientes.MDIClientes());
=======
            Application.Run(new EmpleadoProducto.MDIProductos());
>>>>>>> ae148a34cce8d430b156c9a1a11bba668fd465d9
        }
    }
}