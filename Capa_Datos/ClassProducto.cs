using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class ClassProducto
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //obtener producto_presentacion por cod_producto
        public producto_presentacion ObtenerProductoPresentacionPorCodigo(int cod_producto)
        {
            try
                {
                using (var context = new ArimaERPEntities())
                {
                    return context.producto_presentacion.FirstOrDefault(p => p.cod_producto == cod_producto);
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add(ex.Message);
                return null;
            }
        }
        //obtener producto por id_producto
        public PRODUCTO ObtenerProductoPorId(int id_producto)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.PRODUCTO.FirstOrDefault(p => p.id_producto == id_producto);
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add(ex.Message);
                return null;
            }
        }
        //obtener  PRESENTACION por id_presentacion
        public PRESENTACION ObtenerPresentacionPorId(int id_presentacion)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.PRESENTACION.FirstOrDefault(p => p.ID_presentacion == id_presentacion);
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add(ex.Message);
                return null;
            }
        }
        //obtener objeto stock por id_producto y id_presentacion
        public stock ObtenerStockPorProductoYPresentacion(int id_producto, int id_presentacion)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    return context.stock.FirstOrDefault(s => s.id_producto == id_producto && s.ID_presentacion == id_presentacion);
                }
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
