using System;
using System.Collections.Generic;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Logica
{
    public class ClassMarcaLogica
    {
        ClassMarca marca = new Capa_Datos.ClassMarca();
        public List<string> ErroresValidacion => marca.ErroresValidacion;
        //obtener todas las marcas
        public List<MARCA> ObtenerTodasLasMarcas()
        {
            try
            {
                var marcas = marca.ObtenerTodasLasMarcas();
                return marcas;
            }
            catch (Exception ex)
            {
                marca.ErroresValidacion.Clear();
                marca.ErroresValidacion.Add("Error al obtener las marcas: " + ex.Message);
                return new List<MARCA>();
            }
        }
        //obtener marca por id
        public MARCA ObtenerMarcaPorId(int id_marca)
        {
            try
            {
                var marcaObj = marca.ObtenerMarcaPorId(id_marca);
                return marcaObj;
            }
            catch (Exception ex)
            {
                marca.ErroresValidacion.Clear();
                marca.ErroresValidacion.Add("Error al obtener la marca: " + ex.Message);
                return null;
            }
        }

        public MARCA CrearMarca(MARCA nuevaMarca)
        {
            var marcaCreada = marca.CrearMarca(nuevaMarca);
            return marcaCreada;
        }
    }
}