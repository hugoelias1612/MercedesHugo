using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArimaERP
{
    public static class UsuarioSesion
    {        
        public static string Nombre { get; private set; }
        public static string Apellido { get; private set; }
        public static string Email { get; private set; }
        public static int IdRol { get; private set; }
        public static string RolDescripcion { get; private set; }

        public static void IniciarSesion(string nombre, int idRol, string rolDescripcion)
        {
            
            Nombre = nombre;
            IdRol = idRol;
            RolDescripcion = rolDescripcion;
        }

        public static void CerrarSesion()
        {
            
            Nombre = null;                       
            IdRol = 0;
            RolDescripcion = null;
        }

        // Validación rápida de rol
        public static bool EsAdministrador => IdRol == 8;
        public static bool EsPreventista => IdRol == 5;
        public static bool EsEmpleadoClientes => IdRol == 6;
        public static bool EsEmpleadoProductos => IdRol == 7;           
        
    }
}

