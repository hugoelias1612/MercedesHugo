using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class USUARIO
        {
            public string nombre { get; set; }
            public string contraseña { get; set; }
            public bool estado { get; set; }
            public int id_rol { get; set; }
            public string rol_descripcion { get; set; }
        }

    }

