using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Capa_Utilidades;

namespace Capa_Datos
{
    public class UsuarioDatos
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ArimaERP"]?.ConnectionString
            ?? throw new InvalidOperationException("Falta la cadena de conexión 'ArimaERP' en App.config.");

        public USUARIO ObtenerUsuarioPorNombre(string nombre)
        {
            USUARIO usuario = null;
            string query = @"SELECT u.nombre, u.contraseña, u.estado, u.id_rol, r.descripcion 
                             FROM USUARIOS u 
                             JOIN ROL r ON u.id_rol = r.id_rol 
                             WHERE u.nombre = @nombre AND u.estado = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new USUARIO
                            {
                                nombre = reader["nombre"].ToString(),
                                contraseña = reader["contraseña"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"]),
                                id_rol = Convert.ToInt32(reader["id_rol"]),
                                rol_descripcion = reader["descripcion"].ToString()
                            };
                        }
                    }
                }
            }
            catch (SqlException)
            {
                // Loguear ex.Number / ex.Message aquí según tu logger y rethrow o manejar.
                throw;
            }

            return usuario;
        }

        public USUARIO AutenticarUsuario(string nombre, string contraseñaPlano)
        {
            USUARIO usuario = ObtenerUsuarioPorNombre(nombre);

            if (usuario != null && PasswordHasher.VerifyPassword(contraseñaPlano, usuario.contraseña))
            {
                return usuario;
            }

            return null;
        }
    }
}

