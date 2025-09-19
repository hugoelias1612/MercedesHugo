using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Logica
{
    public class ClassClienteLogica
    {

        private ClassCliente client = new ClassCliente();
        private CLIENTE cliente = new CLIENTE();

        public List<string> ErroresValidacion => client.ErroresValidacion;

        //Devuelve lista de tamaños
        public List<TAMAÑO_NEGOCIO> ObtenerTamanos()
        {
            return ClassTamano.ListarTamanos();
        }
        //Devuelve lista de zonas
        public List<ZONA> ObtenerZonas()
        {
            return ClassZona.ListarZonas();
        }
        //Devuelve lista clientes
        public List<CLIENTE> ObtenerClientes()
        {
            return ClassCliente.ListarClientes();
        }
        public Boolean AgregarCliente(string nombre, string apellido, string id_tamano, string id_zona, DateTime fecha_alta, string email, string telefono, string dni, string cuit_cuil, string calle, string numero, string ciudad, string provincia, string razon_social, bool estado, bool confiable, string condicion_frenteIVA, string cod_postal)
        {
            try
            { cliente.nombre = nombre;
                cliente.apellido = apellido;
                cliente.id_tamano = Convert.ToInt32(id_tamano);
                cliente.id_zona = Convert.ToInt32(id_zona);
                cliente.fecha_alta = fecha_alta;
                cliente.email = email;
                cliente.telefono = Convert.ToInt64(telefono);
                cliente.dni = Convert.ToInt32(dni);
                cliente.cuil_cuit = Convert.ToInt64(cuit_cuil);
                cliente.calle = calle;
                cliente.numero = Convert.ToInt32(numero);
                cliente.ciudad = ciudad;
                cliente.provincia = provincia;
                cliente.razon_social = razon_social;
                cliente.estado = estado;
                cliente.confiable = confiable;
                cliente.condicion_frenteIVA = condicion_frenteIVA;
                cliente.cod_postal = Convert.ToInt32(cod_postal);
                return client.SalvarCliente(cliente);
            }
            catch (Exception ex)
            {
                client.ErroresValidacion.Clear();
                client.ErroresValidacion.Add("Error al agregar el cliente: " + ex.Message);
                return false;
            }
        } }
}

