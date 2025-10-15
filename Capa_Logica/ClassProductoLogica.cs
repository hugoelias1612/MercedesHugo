using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Logica
{
    public class ClassProductoLogica
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();
        //instanciar ClassProducto
        ClassProducto classProducto = new Capa_Datos.ClassProducto();
        //obtener producto_presentacion por cod_producto
        public producto_presentacion ObtenerProductoPresentacionPorCodigo(int cod_producto)
        {
            var productoPresentacion = classProducto.ObtenerProductoPresentacionPorCodigo(cod_producto);
            if (productoPresentacion == null)
            {
                ErroresValidacion = classProducto.ErroresValidacion;
            }
            return productoPresentacion;
        }
        //obtener producto por id_producto
        public PRODUCTO ObtenerProductoPorId(int id_producto)
        {
            var producto = classProducto.ObtenerProductoPorId(id_producto);
            if (producto == null)
            {
                ErroresValidacion = classProducto.ErroresValidacion;
            }
            return producto;
        }
        //obtener  PRESENTACION por id_presentacion
        public PRESENTACION ObtenerPresentacionPorId(int id_presentacion)
        {
            var presentacion = classProducto.ObtenerPresentacionPorId(id_presentacion);
            if (presentacion == null)
            {
                ErroresValidacion = classProducto.ErroresValidacion;
            }
            return presentacion;
        }
        //obtener objeto stock por id_producto y id_presentacion
        public stock ObtenerStockPorProductoYPresentacion(int id_producto, int id_presentacion)
        {
            var stock = classProducto.ObtenerStockPorProductoYPresentacion(id_producto, id_presentacion);
            if (stock == null)
            {
                ErroresValidacion = classProducto.ErroresValidacion;
            }
            return stock;
        }
    }
}
