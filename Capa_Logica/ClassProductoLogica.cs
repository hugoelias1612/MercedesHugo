using System;
using System.Collections.Generic;
using Capa_Entidades;
using Capa_Entidades.DTOs;
using Capa_Datos;

namespace Capa_Logica
{
    public class ClassProductoLogica
    {
        public List<string> ErroresValidacion { get; private set; } = new List<string>();

        private readonly ClassProducto classProducto = new ClassProducto();

        //obtener producto_presentacion por cod_producto
        public producto_presentacion ObtenerProductoPresentacionPorCodigo(int cod_producto)
        {
            var productoPresentacion = classProducto.ObtenerProductoPresentacionPorCodigo(cod_producto);
            ErroresValidacion = classProducto.ErroresValidacion;
            return productoPresentacion;
        }

        //obtener producto por id_producto
        public PRODUCTO ObtenerProductoPorId(int id_producto)
        {
            var producto = classProducto.ObtenerProductoPorId(id_producto);
            ErroresValidacion = classProducto.ErroresValidacion;
            return producto;
        }

        //obtener PRESENTACION por id_presentacion
        public PRESENTACION ObtenerPresentacionPorId(int id_presentacion)
        {
            var presentacion = classProducto.ObtenerPresentacionPorId(id_presentacion);
            ErroresValidacion = classProducto.ErroresValidacion;
            return presentacion;
        }

        public List<PRESENTACION> ObtenerPresentacionesPorRango(int idDesde, int idHasta)
        {
            var presentaciones = classProducto.ObtenerPresentacionesPorRango(idDesde, idHasta);
            ErroresValidacion = classProducto.ErroresValidacion;
            return presentaciones;
        }

        //obtener objeto stock por id_producto y id_presentacion
        public stock ObtenerStockPorProductoYPresentacion(int id_producto, int id_presentacion)
        {
            var stockProducto = classProducto.ObtenerStockPorProductoYPresentacion(id_producto, id_presentacion);
            ErroresValidacion = classProducto.ErroresValidacion;
            return stockProducto;
        }

        //validar disponibilidad del código de producto
        public bool EsCodigoDeProductoDisponible(int codigo, int? idProductoExcluir = null, int? idPresentacionExcluir = null)
        {
            var disponible = classProducto.EsCodigoDeProductoDisponible(codigo, idProductoExcluir, idPresentacionExcluir);
            ErroresValidacion = classProducto.ErroresValidacion;
            return disponible;
        }

        //crear producto y su presentación asociada
        public bool CrearProducto(string nombre, int idFamilia, int idMarca, int codigoProducto, decimal precioLista, int unidadesPorBulto, int idPresentacion, int stockInicial, int umbralStock, bool activo = true)
        {
            try
            {
                var producto = new PRODUCTO
                {
                    nombre = nombre,
                    id_familia = idFamilia,
                    id_marca = idMarca
                };

                var presentacion = new producto_presentacion
                {
                    ID_presentacion = idPresentacion,
                    cod_producto = codigoProducto,
                    precioLista = precioLista,
                    unidades_bulto = unidadesPorBulto,
                    activo = activo
                };

                var stock = new stock
                {
                    stock_actual = stockInicial,
                    umbral_stock = umbralStock
                };

                var resultado = classProducto.CrearProductoConPresentacionYStock(producto, presentacion, stock);
                ErroresValidacion = classProducto.ErroresValidacion;
                return resultado;
            }
            catch (Exception ex)
            {
                ErroresValidacion = new List<string> { "Error al crear el producto: " + ex.Message };
                return false;
            }
        }

        //actualizar datos del producto y de su presentación
        public bool ActualizarProducto(int idProducto, string nombre, int idFamilia, int idMarca, int idPresentacion, int codigoProducto, decimal precioLista, int unidadesPorBulto, bool activo)
        {
            try
            {
                var producto = new PRODUCTO
                {
                    id_producto = idProducto,
                    nombre = nombre,
                    id_familia = idFamilia,
                    id_marca = idMarca
                };

                var presentacion = new producto_presentacion
                {
                    id_producto = idProducto,
                    ID_presentacion = idPresentacion,
                    cod_producto = codigoProducto,
                    precioLista = precioLista,
                    unidades_bulto = unidadesPorBulto,
                    activo = activo
                };

                var resultado = classProducto.ActualizarProductoCompleto(producto, presentacion);
                ErroresValidacion = classProducto.ErroresValidacion;
                return resultado;
            }
            catch (Exception ex)
            {
                ErroresValidacion = new List<string> { "Error al actualizar el producto: " + ex.Message };
                return false;
            }
        }

        //actualizar el precio de un producto
        public bool ActualizarPrecioProducto(int idProducto, int idPresentacion, decimal nuevoPrecio)
        {
            var resultado = classProducto.ActualizarPrecioProducto(idProducto, idPresentacion, nuevoPrecio);
            ErroresValidacion = classProducto.ErroresValidacion;
            return resultado;
        }

        //cambiar el estado activo/inactivo de una presentación
        public bool CambiarEstadoProducto(int idProducto, int idPresentacion, bool activo)
        {
            var resultado = classProducto.CambiarEstadoProducto(idProducto, idPresentacion, activo);
            ErroresValidacion = classProducto.ErroresValidacion;
            return resultado;
        }

        //establecer stock actual y umbral
        public bool EstablecerStock(int idProducto, int idPresentacion, int stockActual, int umbralStock)
        {
            var resultado = classProducto.EstablecerStock(idProducto, idPresentacion, stockActual, umbralStock);
            ErroresValidacion = classProducto.ErroresValidacion;
            return resultado;
        }

        //ajustar stock actual en base a un movimientoS
        public bool AjustarStock(int idProducto, int idPresentacion, int cantidad)
        {
            var resultado = classProducto.AjustarStock(idProducto, idPresentacion, cantidad);
            ErroresValidacion = classProducto.ErroresValidacion;
            return resultado;
        }

        //obtener catálogo de productos
        public List<ProductoCatalogoDto> ObtenerCatalogoProductos(bool incluirInactivos = false)
        {
            var productos = classProducto.ObtenerCatalogoProductos(incluirInactivos);
            ErroresValidacion = classProducto.ErroresValidacion;
            return productos;
        }

        //buscar productos con filtros
        public List<ProductoCatalogoDto> BuscarCatalogoProductos(string termino, int? idFamilia, int? idMarca, int? idProveedor, bool? activo)
        {
            var productos = classProducto.BuscarCatalogoProductos(termino, idFamilia, idMarca, idProveedor, activo);
            ErroresValidacion = classProducto.ErroresValidacion;
            return productos;
        }

        //obtener productos con stock crítico
        public List<ProductoCatalogoDto> ObtenerProductosConStockCritico(
               int? idFamilia = null,
               int? idProveedor = null,
               int? stockMaximo = null,
               bool soloStockInsuficiente = false)
        {
            var productos = classProducto.ObtenerProductosConStockCritico(
                idFamilia,
                idProveedor,
                stockMaximo,
                soloStockInsuficiente);
            ErroresValidacion = classProducto.ErroresValidacion;
            return productos;
        }

        //obtener productos más vendidos
        public List<ProductoVentaDto> ObtenerProductosMasVendidos(DateTime? fechaInicio, DateTime? fechaFin, int limite = 10)
        {
            var productos = classProducto.ObtenerProductosMasVendidos(fechaInicio, fechaFin, limite);
            ErroresValidacion = classProducto.ErroresValidacion;
            return productos;
        }
    }
}