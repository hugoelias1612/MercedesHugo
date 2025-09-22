using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;


namespace Capa_Datos
{
    public class ClassCliente
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        public Boolean SalvarCliente(CLIENTE cliente)
        {
            try
            {
                using (var context = new ArimaERPEntities1())
                {
                    context.CLIENTE.Add(cliente);
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
        //Devuelve lista de clientes
        public static List<CLIENTE> ListarClientes()
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.CLIENTE.ToList();
            }
        }
        // Obtiene un cliente por su ID
        public static CLIENTE ObtenerClientePorId(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.CLIENTE.FirstOrDefault(c => c.id_cliente == id);
            }
        }
        // Actualiza un cliente existente
        public static CLIENTE UpdateCliente(CLIENTE cliente)
        {
            using (var context = new ArimaERPEntities1())
            {
                var existingCliente = context.CLIENTE.Find(cliente.id_cliente);
                if (existingCliente != null)
                {
                    context.Entry(existingCliente).CurrentValues.SetValues(cliente);
                    context.SaveChanges();
                }
                return existingCliente;
            }
        }
        //Inactiva un cliente
        public static bool InactivarCliente(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                var cliente = context.CLIENTE.Find(id);
                if (cliente != null)
                {
                    cliente.estado = false; // Asumiendo que 'estado' es un campo booleano
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        //Activa un cliente
        public static bool ActivarCliente(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                var cliente = context.CLIENTE.Find(id);
                if (cliente != null)
                {
                    cliente.estado = true; // Asumiendo que 'estado' es un campo booleano
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        //Existe un cliente por su id
        public static bool ExisteCliente(int id)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.CLIENTE.Any(c => c.id_cliente == id);
            }
        }
        //Buscar cliente por dni, previa conversion a int
        public static CLIENTE BuscarClientePorDNI(string dni)
        {
            using (var context = new ArimaERPEntities1())
            {
                if (int.TryParse(dni, out int dniInt))
                {
                    return context.CLIENTE.FirstOrDefault(c => c.dni == dniInt);
                }
                return null; // Retorna null si la conversión falla
            }

        }
        //existe cliente por dni, previa conversion a int
        public static bool ExisteClientePorDNI(string dni)
        {
            using (var context = new ArimaERPEntities1())
            {
                if (int.TryParse(dni, out int dniInt))
                {
                    return context.CLIENTE.Any(c => c.dni == dniInt);
                }
                return false; // Retorna false si la conversión falla
            }
        }
        //Existe cliente por cuit/cuil, previa conversion a long
        public static bool ExisteClientePorCUIT_CUIL(string cuit_cuil)
        {
            using (var context = new ArimaERPEntities1())
            {
                if (long.TryParse(cuit_cuil, out long cuitCuilLong))
                {
                    return context.CLIENTE.Any(c => c.cuil_cuit == cuitCuilLong);
                }
                return false; // Retorna false si la conversión falla
            }
        }
        //Existe cliente por email
        public static bool ExisteClientePorEmail(string email)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.CLIENTE.Any(c => c.email == email);
            }
        }
        //clientes por zona
        public static List<CLIENTE> ClientesPorZona(int id_zona)
        {
            using (var context = new ArimaERPEntities1())
            {
                return context.CLIENTE.Where(c => c.id_zona == id_zona).ToList();
            }
        }
    }
}
