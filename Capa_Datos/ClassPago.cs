using Capa_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace Capa_Datos
{
    public class ClassPago
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();

        public List<METODO_PAGO> ListarMetodosPago()
        {
            using (var context = new ArimaERPEntities())
            {
                return context.METODO_PAGO
                    .OrderBy(m => m.descripcion)
                    .ToList();
            }
        }

        public PAGO GuardarPago(PAGO pago)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    context.PAGO.Add(pago);
                    context.SaveChanges();
                    return pago;
                }
            }
            catch (DbEntityValidationException ex)
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
                return null;
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add(ex.Message);
                return null;
            }
        }
    }
}
