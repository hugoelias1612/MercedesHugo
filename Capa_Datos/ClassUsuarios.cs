using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassUsuarios
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //usuarios por rol
        public List<USUARIOS> ObtenerUsuariosPorRol(int id_rol)
        {
            using (var context = new ArimaERPEntities())
            {
                return context.USUARIOS.Where(u => u.id_rol == id_rol).ToList();
            }
        }
    }
}
