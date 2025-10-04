using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Logica
{
    public class ClassRolLogica
    {
        private ClassRol rol = new ClassRol();
        public List<string> ErroresValidacion => rol.ErroresValidacion;
        // Devuelve lista de roles
        public static List<ROL> ListarRoles()
        {
            return ClassRol.ListarRoles();
        }

        //agregar nuevo rol
        public Boolean SalvarRol(string descripcion, string estado)
        {
            ROL rol = new ROL
            {
                descripcion = descripcion,
                estado = Convert.ToBoolean(estado)
            };
            ClassRol classRol = new ClassRol();
            return classRol.SalvarRol(rol);
        }
        //actualizar estado del rol
        public ROL UpdateRol(int id_rol, string descripcion, string estado)
        {
            try
            {
                ROL rolUsuario = new ROL
                {
                    id_rol = id_rol,
                    descripcion = descripcion,
                    estado = Convert.ToBoolean(estado),
                };
                return ClassRol.UpdateRol(rolUsuario);
            }
            catch (Exception ex)
            {
                rol.ErroresValidacion.Clear();
                rol.ErroresValidacion.Add("Error al actualizar el cliente: " + ex.Message);
                return null;
            }
        }
    }
}
