using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassPedido
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //Obtener siguiente id pedido
        public int ObtenerSiguienteIdPedido()
        {
            using (var context = new ArimaERPEntities())
            {
                int maxId = context.PEDIDO.Any() ? context.PEDIDO.Max(p => p.id_pedido) : 0;
                return maxId + 1;
            }
        }
        //Guardar pedido
        public bool GuardarPedido(PEDIDO pedido)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    context.PEDIDO.Add(pedido);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add(ex.Message);
                return false;
            }
        }
        //guardar detalle pedido
        public Boolean GuardarDetallePedido(DETALLE_PEDIDO detallePedido)
        {
        
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    context.DETALLE_PEDIDO.Add(detallePedido);
                    context.SaveChanges();
                }
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                ErroresValidacion.Clear();
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var error in validationErrors.ValidationErrors)
                    {
                        string mensaje = $"Entidad: {validationErrors.Entry.Entity.GetType().Name}, Campo: {error.PropertyName}, Error: {error.ErrorMessage}";
                        ErroresValidacion.Add(mensaje);

                    }
                }
                return false;
            }
        }
    }
}

