using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;
namespace Dal
{
    public class RepositorioExportacion
    {
        public IList<ReciboDePago> RecibosDePago { get; set; }

        public RepositorioExportacion()
        {
        }
        public void Exportar()
        {
            Almacenar almacenar = new Almacenar();
            FileStream flujoFichero = new FileStream(Ruta,FileMode.Create);
            flujoFichero.Close();
            almacenar.Guardar(PrimeraLinea,Ruta);
            almacenar.Guardar(SegundaLinea(), Ruta);
            foreach (var item in RecibosDePago)
            {
                almacenar.Guardar(item.DatosExportacion(),Ruta);
            }
        }
        public string Ruta
        {
            get
            {
                ReciboDePago reciboDePago = RecibosDePago.First();
                string PrimeraLinea = $"{reciboDePago.EntidadServicio}{ObtenerFecha(reciboDePago)}.Txt";
                return PrimeraLinea;
            }
        }
        public string ObtenerFecha(ReciboDePago reciboDePago)
        {
            return $"{reciboDePago.FechaPago.Year}{reciboDePago.FechaPago.Month}{reciboDePago.FechaPago.Day}";
        }
        public string PrimeraLinea
        {
            get 
            {
                ReciboDePago reciboDePago = RecibosDePago.First();
                string PrimeraLinea = $"{reciboDePago.EntidadServicio};{reciboDePago.FechaPago.ToShortDateString()}";
                return PrimeraLinea;
            }
        }
        public string SegundaLinea()
        {
            return $"{RecaudoRecibo};{CantidadRecibo}";
        }
        public decimal RecaudoRecibo
        {
            get
            {
               return RecibosDePago.Sum(Rp => Rp.ValorPagado);
            }
        }
        public int CantidadRecibo
        {
            get
            {
                return RecibosDePago.Count();
            }
        }
        public void GenerarSegundaLinea()
        {
            ReciboDePago reciboDePago = RecibosDePago.First();
            string PrimeraLinea = $"{reciboDePago.EntidadServicio};{reciboDePago.FechaPago.ToString()}";
        }
        public string ObtenerNombreArchivoExportado(string nombre)
        {
              return $"{nombre}.Txt";
        }
    }
}
