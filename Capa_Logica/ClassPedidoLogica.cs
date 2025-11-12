using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Logica
{
    public class ClassPedidoLogica
    {
        private ClassPedido pedido = new ClassPedido();
        public List<string> ErroresValidacion => pedido.ErroresValidacion;
        //Obtener siguiente id pedido
        public int ObtenerSiguienteIdPedido()
        {
            return pedido.ObtenerSiguienteIdPedido();
        }

        //Guardar pedido
        public Boolean GuardarPedido(DateTime fecha_creacion, DateTime fecha_entrega, string id_cliente, string id_estado, string total, string numero_factura)
        {
            try
            {
                PEDIDO nuevoPedido = new PEDIDO
                {
                    fecha_creacion = fecha_creacion,
                    fecha_entrega = fecha_entrega,
                    id_cliente = Convert.ToInt32(id_cliente),
                    id_estado = Convert.ToInt32(id_estado),
                    total = Convert.ToDecimal(total),
                    numero_factura = Convert.ToInt32(numero_factura)
                };
                return pedido.GuardarPedido(nuevoPedido);
            }
            catch (Exception ex)
            {
                pedido.ErroresValidacion.Clear();
                pedido.ErroresValidacion.Add("Error al agregar el pedido: " + ex.Message);
                return false;
            }
        }
        //guardar detallepedido
        public Boolean GuardarDetallePedido(string cantidad, string descuento, string ID_detalle_pedido, string id_pedido, string id_producto, string ID_presentacion, string cantidad_bultos, string precio_unitario)
        {
            try
            {
                DETALLE_PEDIDO nuevoDetallePedido = new DETALLE_PEDIDO()
                {
                    cantidad = Convert.ToInt32(cantidad),
                    descuento = Convert.ToDecimal(descuento),
                    ID_detalle_pedido = Convert.ToInt32(ID_detalle_pedido),
                    id_pedido = Convert.ToInt32(id_pedido),
                    id_producto = Convert.ToInt32(id_producto),
                    ID_presentacion = Convert.ToInt32(ID_presentacion),
                    cantidad_bultos = Convert.ToInt32(cantidad_bultos),
                    precio_unitario = Convert.ToDecimal(precio_unitario)
                };
                return pedido.GuardarDetallePedido(nuevoDetallePedido);
            }
            catch (Exception ex)
            {
                pedido.ErroresValidacion.Clear();
                pedido.ErroresValidacion.Add("Error al agregar el detalle del pedido: " + ex.Message);
                return false;
            }
        }

        public bool GuardarPedidoCompleto(PEDIDO nuevoPedido, IEnumerable<DETALLE_PEDIDO> detalles, PAGO pago, pedido_pago pedidoPago)
        {
            return pedido.GuardarPedidoCompleto(nuevoPedido, detalles, pago, pedidoPago);
        }
    }
} 

