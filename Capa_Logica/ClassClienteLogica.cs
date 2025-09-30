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
        //devolver si existe un cliente por su dni
        public bool ExisteClientePorDni(string dni)
        {
            return ClassCliente.ExisteClientePorDNI(dni);
        }
        //existe cliente por su cuit_cuil
        public bool ExisteClientePorCuitCuil(string cuit_cuil)
        {
            return ClassCliente.ExisteClientePorCUIT_CUIL(cuit_cuil);
        }
        //Existe cliente por su email
        public bool ExisteClientePorEmail(string email)
        {
            return ClassCliente.ExisteClientePorEmail(email);
        }
        //clientes por zona
        public List<CLIENTE> ClientesPorZona(int id_zona)
        {
            return ClassCliente.ClientesPorZona(id_zona);
        }


        public Boolean AgregarCliente(string nombre, string apellido, string id_tamano, string id_zona, DateTime fecha_alta, string email, string telefono, string dni, string cuit_cuil, string calle, string numero, string ciudad, string provincia, string razon_social, bool estado, bool confiable, string condicion_frenteIVA, string cod_postal)
        {
            try
            {
                cliente.nombre = nombre;
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
        }
        //Existe otro cliente con mismo email
        public bool ExisteOtroClienteConMismoEmail(int id_cliente, string email)
        {
            return ClassCliente.ExisteEmailDeOtroCliente(id_cliente, email);
        }
        //Actualizar cliente
        public CLIENTE ActualizarCliente(int id_cliente, string nombre, string apellido, string id_tamano, string id_zona, DateTime fecha_alta, string email, string telefono, string dni, string cuit_cuil, string calle, string numero, string ciudad, string provincia, string razon_social, bool estado, bool confiable, string condicion_frenteIVA, string cod_postal)
        {
            try
            {
                cliente.id_cliente = id_cliente;
                cliente.nombre = nombre;
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
                return ClassCliente.UpdateCliente(cliente);
            }
            catch (Exception ex)
            {
                client.ErroresValidacion.Clear();
                client.ErroresValidacion.Add("Error al actualizar el cliente: " + ex.Message);
                return null;
            }
        }
    }
}

