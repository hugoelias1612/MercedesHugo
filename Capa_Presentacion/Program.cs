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
            Application.Run(new Empleado_Producto.MDIProductos());
        }
    }
}