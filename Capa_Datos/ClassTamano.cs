using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassTamano
    {
        //Devuelve lista de tamaños
        public static List<TAMAÑO_NEGOCIO> ListarTamanos()
        {
            using (var context = new ArimaERPEntities())
            {
                return context.TAMAÑO_NEGOCIO.ToList();
            }
        }
        // Obtiene un tamaño por su ID
        public static TAMAÑO_NEGOCIO ObtenerTamanoPorId(int id)
        {
            using (var context = new ArimaERPEntities())
            {
                return context.TAMAÑO_NEGOCIO.FirstOrDefault(t => t.id_tamano == id);
            }
        }
        // Actualiza un tamaño existente
        public static TAMAÑO_NEGOCIO UpdateTamano(TAMAÑO_NEGOCIO tamano)
        {
            using (var context = new ArimaERPEntities())
            {
                var existingTamano = context.TAMAÑO_NEGOCIO.Find(tamano.id_tamano);
                if (existingTamano != null)
                {
                    context.Entry(existingTamano).CurrentValues.SetValues(tamano);
                    context.SaveChanges();
                }
                return existingTamano;
            }
        }
        //     Agregar un nuevo tamaño
        public Boolean SalvarTamano(TAMAÑO_NEGOCIO tamano)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    context.TAMAÑO_NEGOCIO.Add(tamano);
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
    }
}
