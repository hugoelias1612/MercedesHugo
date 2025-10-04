using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassRol
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        // Devuelve lista de roles
        public static List<ROL> ListarRoles()
        {
            using (var context = new ArimaERPEntities())
            {
                return context.ROL.ToList();
            }
        }
        //agregar nuevo rol
        public Boolean SalvarRol(ROL rol)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    context.ROL.Add(rol);
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
        //actualizar estado del rol
        public static ROL UpdateRol(ROL rol)
        {           
                using (var context = new ArimaERPEntities())
                {
                    var existingRol = context.ROL.Find(rol.id_rol);
                    if (existingRol != null)
                    {
                        context.Entry(existingRol).CurrentValues.SetValues(rol);
                        context.SaveChanges();
                    }
                    return existingRol;
                }
            }
            
        }

    }

