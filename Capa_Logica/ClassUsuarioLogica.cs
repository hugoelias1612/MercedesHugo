using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Logica
{ 
    
    public class ClassUsuarioLogica
    {
        private ClassUsuarios usuario = new ClassUsuarios();
        //obtener usuarios por rol
        public List<USUARIOS> ObtenerUsuariosPorRol(int id_rol)
        {
            return usuario.ObtenerUsuariosPorRol(id_rol);
        }
    }
}
