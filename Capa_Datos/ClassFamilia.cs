using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassFamilia
    {        
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //obtener todas las familias
        public List<FAMILIA> ObtenerTodasLasFamilias()
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.FAMILIA.ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener las familias: " + ex.Message);
                return new List<FAMILIA>();
            }
        }
    }
}
