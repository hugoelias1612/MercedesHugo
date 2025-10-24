using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Capa_Entidades;
using Capa_Entidades.DTOs;

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
                    ErroresValidacion.Clear();
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
                    ErroresValidacion.Clear();
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

        //obtener PRESENTACION por id_presentacion
        public PRESENTACION ObtenerPresentacionPorId(int id_presentacion)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();
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
                    ErroresValidacion.Clear();
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

        //validar disponibilidad del código de producto
        public bool EsCodigoDeProductoDisponible(int codigo, int? idProductoExcluir = null, int? idPresentacionExcluir = null)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();
                    var query = context.producto_presentacion.AsQueryable();

                    if (idProductoExcluir.HasValue && idPresentacionExcluir.HasValue)
                    {
                        int productoId = idProductoExcluir.Value;
                        int presentacionId = idPresentacionExcluir.Value;
                        query = query.Where(pp => !(pp.id_producto == productoId && pp.ID_presentacion == presentacionId));
                    }
                    else if (idProductoExcluir.HasValue)
                    {
                        int productoId = idProductoExcluir.Value;
                        query = query.Where(pp => pp.id_producto != productoId);
                    }

                    return !query.Any(pp => pp.cod_producto == codigo);
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al validar el código del producto: " + ex.Message);
                return false;
            }
        }

        //crear producto, presentación y stock inicial
        public bool CrearProductoConPresentacionYStock(PRODUCTO nuevoProducto, producto_presentacion nuevaPresentacion, stock stockInicial)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    if (!context.PRESENTACION.Any(p => p.ID_presentacion == nuevaPresentacion.ID_presentacion))
                    {
                        ErroresValidacion.Add("La presentación indicada no existe.");
                        return false;
                    }

                    if (context.producto_presentacion.Any(pp => pp.cod_producto == nuevaPresentacion.cod_producto))
                    {
                        ErroresValidacion.Add("El código de producto ya está asignado a otra presentación.");
                        return false;
                    }

                    if (stockInicial != null)
                    {
                        if (stockInicial.stock_actual < 0)
                        {
                            ErroresValidacion.Add("El stock inicial no puede ser negativo.");
                            return false;
                        }

                        if (stockInicial.umbral_stock < 0)
                        {
                            ErroresValidacion.Add("El umbral de stock no puede ser negativo.");
                            return false;
                        }
                    }

                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.PRODUCTO.Add(nuevoProducto);
                            context.SaveChanges();

                            nuevaPresentacion.id_producto = nuevoProducto.id_producto;
                            context.producto_presentacion.Add(nuevaPresentacion);
                            context.SaveChanges();

                            if (stockInicial != null)
                            {
                                stockInicial.id_producto = nuevoProducto.id_producto;
                                stockInicial.ID_presentacion = nuevaPresentacion.ID_presentacion;
                                context.stock.Add(stockInicial);
                                context.SaveChanges();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al crear el producto: " + ex.Message);
                return false;
            }
        }

        //actualizar datos del producto y su presentación
        public bool ActualizarProductoCompleto(PRODUCTO datosProducto, producto_presentacion datosPresentacion)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var productoExistente = context.PRODUCTO.FirstOrDefault(p => p.id_producto == datosProducto.id_producto);
                    if (productoExistente == null)
                    {
                        ErroresValidacion.Add("No se encontró el producto indicado.");
                        return false;
                    }

                    var presentacionExistente = context.producto_presentacion.FirstOrDefault(pp => pp.id_producto == datosPresentacion.id_producto && pp.ID_presentacion == datosPresentacion.ID_presentacion);
                    if (presentacionExistente == null)
                    {
                        ErroresValidacion.Add("No se encontró la presentación asociada al producto.");
                        return false;
                    }

                    bool codigoDuplicado = context.producto_presentacion.Any(pp =>
                        pp.cod_producto == datosPresentacion.cod_producto &&
                        !(pp.id_producto == datosPresentacion.id_producto && pp.ID_presentacion == datosPresentacion.ID_presentacion));

                    if (codigoDuplicado)
                    {
                        ErroresValidacion.Add("El código de producto ya está asignado a otra presentación.");
                        return false;
                    }

                    productoExistente.nombre = datosProducto.nombre;
                    productoExistente.id_familia = datosProducto.id_familia;
                    productoExistente.id_marca = datosProducto.id_marca;

                    presentacionExistente.cod_producto = datosPresentacion.cod_producto;
                    presentacionExistente.precioLista = datosPresentacion.precioLista;
                    presentacionExistente.unidades_bulto = datosPresentacion.unidades_bulto;
                    presentacionExistente.activo = datosPresentacion.activo;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al actualizar el producto: " + ex.Message);
                return false;
            }
        }

        //actualizar precio de lista
        public bool ActualizarPrecioProducto(int idProducto, int idPresentacion, decimal nuevoPrecio)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    if (nuevoPrecio < 0)
                    {
                        ErroresValidacion.Add("El precio no puede ser negativo.");
                        return false;
                    }

                    var presentacion = context.producto_presentacion.FirstOrDefault(pp => pp.id_producto == idProducto && pp.ID_presentacion == idPresentacion);
                    if (presentacion == null)
                    {
                        ErroresValidacion.Add("No se encontró la presentación indicada.");
                        return false;
                    }

                    presentacion.precioLista = nuevoPrecio;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al actualizar el precio del producto: " + ex.Message);
                return false;
            }
        }

        //cambiar estado activo/inactivo de la presentación
        public bool CambiarEstadoProducto(int idProducto, int idPresentacion, bool activo)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var presentacion = context.producto_presentacion.FirstOrDefault(pp => pp.id_producto == idProducto && pp.ID_presentacion == idPresentacion);
                    if (presentacion == null)
                    {
                        ErroresValidacion.Add("No se encontró la presentación indicada.");
                        return false;
                    }

                    presentacion.activo = activo;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al actualizar el estado del producto: " + ex.Message);
                return false;
            }
        }

        //establecer stock actual y umbral
        public bool EstablecerStock(int idProducto, int idPresentacion, int stockActual, int umbralStock)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    if (stockActual < 0)
                    {
                        ErroresValidacion.Add("El stock no puede ser negativo.");
                        return false;
                    }

                    if (umbralStock < 0)
                    {
                        ErroresValidacion.Add("El umbral de stock no puede ser negativo.");
                        return false;
                    }

                    var presentacion = context.producto_presentacion.FirstOrDefault(pp => pp.id_producto == idProducto && pp.ID_presentacion == idPresentacion);
                    if (presentacion == null)
                    {
                        ErroresValidacion.Add("No se encontró la presentación asociada al producto.");
                        return false;
                    }

                    var registroStock = context.stock.FirstOrDefault(s => s.id_producto == idProducto && s.ID_presentacion == idPresentacion);
                    if (registroStock == null)
                    {
                        registroStock = new stock
                        {
                            id_producto = idProducto,
                            ID_presentacion = idPresentacion
                        };
                        context.stock.Add(registroStock);
                    }

                    registroStock.stock_actual = stockActual;
                    registroStock.umbral_stock = umbralStock;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al actualizar el stock del producto: " + ex.Message);
                return false;
            }
        }

        //ajustar stock actual en base a un movimiento (positivo o negativo)
        public bool AjustarStock(int idProducto, int idPresentacion, int cantidad)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var registroStock = context.stock.FirstOrDefault(s => s.id_producto == idProducto && s.ID_presentacion == idPresentacion);
                    if (registroStock == null)
                    {
                        ErroresValidacion.Add("No existe un registro de stock para el producto indicado.");
                        return false;
                    }

                    int nuevoStock = registroStock.stock_actual + cantidad;
                    if (nuevoStock < 0)
                    {
                        ErroresValidacion.Add("El ajuste de stock dejaría el stock en negativo.");
                        return false;
                    }

                    registroStock.stock_actual = nuevoStock;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al ajustar el stock del producto: " + ex.Message);
                return false;
            }
        }

        //buscar productos con filtros flexibles
        public List<ProductoCatalogoDto> BuscarCatalogoProductos(string termino, int? idFamilia, int? idMarca, bool? activo)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var query = from pp in context.producto_presentacion
                                join producto in context.PRODUCTO on pp.id_producto equals producto.id_producto
                                join familia in context.FAMILIA on producto.id_familia equals familia.id_familia
                                join marca in context.MARCA on producto.id_marca equals marca.id_marca
                                join presentacion in context.PRESENTACION on pp.ID_presentacion equals presentacion.ID_presentacion
                                join stockRegistro in context.stock on new { pp.id_producto, pp.ID_presentacion } equals new { stockRegistro.id_producto, stockRegistro.ID_presentacion } into stockJoin
                                from stockRegistro in stockJoin.DefaultIfEmpty()
                                select new { pp, producto, familia, marca, presentacion, stockRegistro };

                    if (activo.HasValue)
                    {
                        bool estado = activo.Value;
                        query = query.Where(x => x.pp.activo == estado);
                    }

                    if (idFamilia.HasValue)
                    {
                        int familiaId = idFamilia.Value;
                        query = query.Where(x => x.producto.id_familia == familiaId);
                    }

                    if (idMarca.HasValue)
                    {
                        int marcaId = idMarca.Value;
                        query = query.Where(x => x.producto.id_marca == marcaId);
                    }

                    if (!string.IsNullOrWhiteSpace(termino))
                    {
                        string terminoNormalizado = termino.Trim().ToLower();
                        int codigoBuscado;
                        bool terminoEsNumero = int.TryParse(termino.Trim(), out codigoBuscado);

                        query = query.Where(x =>
                            x.producto.nombre.ToLower().Contains(terminoNormalizado) ||
                            x.marca.nombre.ToLower().Contains(terminoNormalizado) ||
                            x.familia.descripcion.ToLower().Contains(terminoNormalizado) ||
                            x.presentacion.descripcion.ToLower().Contains(terminoNormalizado) ||
                            (terminoEsNumero && x.pp.cod_producto == codigoBuscado));
                    }

                    return query
                        .OrderBy(x => x.producto.nombre)
                        .ThenBy(x => x.presentacion.descripcion)
                        .Select(x => new ProductoCatalogoDto
                        {
                            IdProducto = x.pp.id_producto,
                            IdPresentacion = x.pp.ID_presentacion,
                            Codigo = x.pp.cod_producto,
                            Nombre = x.producto.nombre,
                            Marca = x.marca.nombre,
                            Familia = x.familia.descripcion,
                            Presentacion = x.presentacion.descripcion,
                            PrecioLista = x.pp.precioLista,
                            UnidadesPorBulto = x.pp.unidades_bulto,
                            Activo = x.pp.activo,
                            StockActual = x.stockRegistro != null ? x.stockRegistro.stock_actual : 0,
                            UmbralStock = x.stockRegistro != null ? x.stockRegistro.umbral_stock : 0
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al buscar productos: " + ex.Message);
                return new List<ProductoCatalogoDto>();
            }
        }

        //obtener catálogo completo o solo activos
        public List<ProductoCatalogoDto> ObtenerCatalogoProductos(bool incluirInactivos = false)
        {
            return BuscarCatalogoProductos(null, null, null, incluirInactivos ? (bool?)null : true);
        }

        //obtener productos con stock crítico
        public List<ProductoCatalogoDto> ObtenerProductosConStockCritico()
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var query = from stockRegistro in context.stock
                                join pp in context.producto_presentacion on new { stockRegistro.id_producto, stockRegistro.ID_presentacion } equals new { pp.id_producto, pp.ID_presentacion }
                                join producto in context.PRODUCTO on stockRegistro.id_producto equals producto.id_producto
                                join familia in context.FAMILIA on producto.id_familia equals familia.id_familia
                                join marca in context.MARCA on producto.id_marca equals marca.id_marca
                                join presentacion in context.PRESENTACION on stockRegistro.ID_presentacion equals presentacion.ID_presentacion
                                where stockRegistro.stock_actual <= stockRegistro.umbral_stock
                                select new ProductoCatalogoDto
                                {
                                    IdProducto = producto.id_producto,
                                    IdPresentacion = presentacion.ID_presentacion,
                                    Codigo = pp.cod_producto,
                                    Nombre = producto.nombre,
                                    Marca = marca.nombre,
                                    Familia = familia.descripcion,
                                    Presentacion = presentacion.descripcion,
                                    PrecioLista = pp.precioLista,
                                    UnidadesPorBulto = pp.unidades_bulto,
                                    Activo = pp.activo,
                                    StockActual = stockRegistro.stock_actual,
                                    UmbralStock = stockRegistro.umbral_stock
                                };

                    return query
                        .OrderBy(x => x.StockActual - x.UmbralStock)
                        .ThenBy(x => x.Nombre)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener los productos con stock crítico: " + ex.Message);
                return new List<ProductoCatalogoDto>();
            }
        }

        //obtener productos más vendidos en un período
        public List<ProductoVentaDto> ObtenerProductosMasVendidos(DateTime? fechaInicio, DateTime? fechaFin, int limite)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();

                    var detalles = context.DETALLE_PEDIDO.Include(d => d.PEDIDO).AsQueryable();

                    if (fechaInicio.HasValue)
                    {
                        DateTime inicio = fechaInicio.Value.Date;
                        detalles = detalles.Where(d => d.PEDIDO.fecha_creacion >= inicio);
                    }

                    if (fechaFin.HasValue)
                    {
                        DateTime fin = fechaFin.Value.Date;
                        detalles = detalles.Where(d => d.PEDIDO.fecha_creacion <= fin);
                    }

                    var query = from detalle in detalles
                                join pp in context.producto_presentacion on new { detalle.id_producto, detalle.ID_presentacion } equals new { pp.id_producto, pp.ID_presentacion }
                                join producto in context.PRODUCTO on detalle.id_producto equals producto.id_producto
                                join marca in context.MARCA on producto.id_marca equals marca.id_marca
                                join presentacion in context.PRESENTACION on detalle.ID_presentacion equals presentacion.ID_presentacion
                                group new { detalle, pp, producto, marca, presentacion } by new
                                {
                                    detalle.id_producto,
                                    detalle.ID_presentacion,
                                    producto.nombre,
                                    Marca = marca.nombre,
                                    Presentacion = presentacion.descripcion,
                                    Codigo = pp.cod_producto
                                }
                        into agrupado
                                select new ProductoVentaDto
                                {
                                    IdProducto = agrupado.Key.id_producto,
                                    IdPresentacion = agrupado.Key.ID_presentacion,
                                    Codigo = agrupado.Key.Codigo,
                                    Nombre = agrupado.Key.nombre,
                                    Marca = agrupado.Key.Marca,
                                    Presentacion = agrupado.Key.Presentacion,
                                    TotalUnidadesVendidas = agrupado.Sum(x => x.detalle.cantidad) ?? 0,
                                    TotalBultosVendidos = agrupado.Sum(x => x.detalle.cantidad_bultos) ?? 0,
                                    TotalIngresos = agrupado.Sum(x => x.detalle.precio_unitario * (x.detalle.cantidad ?? 0))
                                };

                    query = query
                        .OrderByDescending(x => x.TotalUnidadesVendidas)
                        .ThenByDescending(x => x.TotalIngresos);

                    if (limite > 0)
                    {
                        query = query.Take(limite);
                    }

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener los productos más vendidos: " + ex.Message);
                return new List<ProductoVentaDto>();
            }
        }

        public List<PRESENTACION> ObtenerPresentacionesPorRango(int desde, int hasta)
        {
            try
            {
                using (var context = new ArimaERPEntities())
                {
                    ErroresValidacion.Clear();
                    return context.PRESENTACION
                                  .Where(p => p.ID_presentacion >= desde && p.ID_presentacion <= hasta)
                                  .OrderBy(p => p.ID_presentacion)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                ErroresValidacion.Clear();
                ErroresValidacion.Add("Error al obtener las presentaciones: " + ex.Message);
                return new List<PRESENTACION>();
            }
        }
    }
}