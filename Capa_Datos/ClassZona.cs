using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassZona
    {
        //Devuelve lista de zonas
        public static List<ZONA> ListarZonas()
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.ZONA.ToList();
            }
        }

        // Obtiene una zona por su ID
        public static ZONA ObtenerZonaPorId(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.ZONA.FirstOrDefault(z => z.id_zona == id);
            }
        }
        // Actualiza una zona existente
        public static ZONA UpdateZona(ZONA zona)
        {
            using (var context = new ArimaERPEntities1())
            {
                var existingZona = context.ZONA.Find(zona.id_zona);
                if (existingZona != null)
                {
                    context.Entry(existingZona).CurrentValues.SetValues(zona);
                    context.SaveChanges();
                }
                return existingZona;
            }
        }
        //     Agregar una nueva zona
        public Boolean SalvarZona(ZONA zona)
        {
            try
            {
                using (var context = new ArimaERPEntities1())
                {
                    context.ZONA.Add(zona);
                    context.SaveChanges();
                }
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                // Manejar errores de validación aquí si es necesario
                return false;
            }
        }
        // Eliminar una zona por su ID
        public static bool EliminarZona(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                var zona = context.ZONA.Find(id);
                if (zona != null)
                {
                    context.ZONA.Remove(zona);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        //Existe zona por ID
        public static bool ExisteZona(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.ZONA.Any(z => z.id_zona == id);
            }


        }
    }
}