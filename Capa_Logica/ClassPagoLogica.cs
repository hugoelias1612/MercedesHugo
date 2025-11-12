using System;
using System.Collections.Generic;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Logica
{
    public class ClassPagoLogica
    {
        private readonly ClassPago pago = new ClassPago();

        public List<string> ErroresValidacion => pago.ErroresValidacion;

        public List<METODO_PAGO> ObtenerMetodosPago()
        {
            return pago.ListarMetodosPago();
        }
    }
}