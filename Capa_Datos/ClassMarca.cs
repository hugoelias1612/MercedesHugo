using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;


namespace Capa_Datos
{
    public class ClassMarca
    {
        
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //obtener todas las marcas
        public List<MARCA> ObtenerTodasLasMarcas()
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.MARCA.ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener las marcas: " + ex.Message);
                return new List<MARCA>();
            }
        }
        //obtener marca por id
        public MARCA ObtenerMarcaPorId(int id_marca)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.MARCA.FirstOrDefault(m => m.id_marca == id_marca);
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener la marca: " + ex.Message);
                return null;
            }
        }
    }
}
