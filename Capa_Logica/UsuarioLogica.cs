using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Logica
{
    public class UsuarioLogica
    {
        private UsuarioDatos datos = new UsuarioDatos();

        public USUARIO AutenticarUsuario(string nombre, string contraseñaPlano)
        {
            return datos.AutenticarUsuario(nombre, contraseñaPlano);
        }
    }
}
