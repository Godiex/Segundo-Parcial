using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReciboDePago
    {
        public string IdReciboPago { get; set; }
        public string EntidadServicio { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ValorPagado { get; set; }

        public ReciboDePago(string idReciboPago, string entidadServicio, DateTime fechaPago, decimal valorPagado)
        {
            IdReciboPago = idReciboPago;
            EntidadServicio = entidadServicio;
            FechaPago = fechaPago;
            ValorPagado = valorPagado;
        }
        public override string ToString()
        {
            return $"{IdReciboPago};{EntidadServicio};{FechaPago};{ValorPagado}";
        }
        public string DatosExportacion()
        {
            return $"{IdReciboPago};{FechaPago.ToShortDateString()};{ValorPagado}";
        }

    }
}
