using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
namespace Dal
{
    public class RepositorioReciboDePago
    {
        private IList<ReciboDePago> recibosDePago;
        public string Ruta = @"RecibosDePago.txt";
        public RepositorioReciboDePago()
        {
            recibosDePago = new List<ReciboDePago>();
        }
        public void Guardar(ReciboDePago reciboDePago)
        {
            Almacenar almacenar = new Almacenar();
            almacenar.Guardar(reciboDePago.ToString(), Ruta);
        }
        public IList<ReciboDePago> Consultar()
        {
            recibosDePago.Clear();
            FileStream flujoDelFichero = new FileStream(Ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(flujoDelFichero);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                ReciboDePago reciboDePago = MapearReciboDePago(linea);
                recibosDePago.Add(reciboDePago);
            }
            lector.Close();
            flujoDelFichero.Close();
            return recibosDePago;
        }
        public ReciboDePago MapearReciboDePago(string linea)
        {
            string[] datos = linea.Split(';');
            string idEntidad = datos[0];
            string entidadServicio = datos[1];
            DateTime fechaDePago = DateTime.Parse(datos[2]);
            decimal valorPagado = decimal.Parse(datos[3]);
            ReciboDePago reciboDePago = new ReciboDePago(idEntidad, entidadServicio, fechaDePago, valorPagado);
            return reciboDePago;
        }
        public ReciboDePago Buscar(string idReciboDePago, string entidadServicio)
        {
            recibosDePago = Consultar();
            foreach (var item in recibosDePago)
            {
                if (idReciboDePago.Equals(item.IdReciboPago) && entidadServicio.Equals(item.EntidadServicio))
                {
                    return item;
                }
            }
            return null;
        }
        public IList<ReciboDePago> ConsultarPorEntidad(string entidadServicio)
        {
            return recibosDePago.Where(Rp => Rp.EntidadServicio.Equals(entidadServicio)).ToList();
        }
        public int CantidadRecibosDePago()
        {
            return Consultar().Count();
        }
        public IList<ReciboDePago> ConsultaPorFecha( DateTime Fecha)
        {
            return recibosDePago.Where(Rp => 
            Rp.FechaPago.Year.Equals(Fecha.Year)
            && Rp.FechaPago.Month.Equals(Fecha.Month) &&  Rp.FechaPago.DayOfYear.Equals(Fecha.DayOfYear)).ToList();
        }
        public IList<ReciboDePago> ConsultarPorFechaYEntidad(string entidadServicio , DateTime fecha)
        {
            IList<ReciboDePago> recibosDePagoPorFecha = ConsultaPorFecha(fecha);
            return recibosDePagoPorFecha.Where(Rp => Rp.EntidadServicio.Equals(entidadServicio)).ToList();
        }
        public int CantidadPorFechaYEntidad(string entidadServicio, DateTime fecha)
        {
           return  ConsultarPorFechaYEntidad(entidadServicio,fecha).Count();
        }
        public decimal ObtenerRecaudoPorFechaYEntidad(string entidadServicio, DateTime fecha)
        {
            return ConsultarPorFechaYEntidad(entidadServicio, fecha).Sum(Rp => Rp.ValorPagado);
        }
        public decimal ObtenerRecaudoGeneral()
        {
            return Consultar().Sum(Rp => Rp.ValorPagado);
        }
    }
}
