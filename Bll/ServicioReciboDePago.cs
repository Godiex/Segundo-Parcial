using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
namespace Bll
{
    public class ServicioReciboDePago
    {
        private RepositorioReciboDePago repositorioReciboDePago = new RepositorioReciboDePago();
        public string Guardar(ReciboDePago reciboDePago)
        {
            try
            {
                ReciboDePago reciboDePagoBuscado = repositorioReciboDePago.Buscar(reciboDePago.IdReciboPago, reciboDePago.EntidadServicio);
                if (reciboDePagoBuscado == null)
                {
                    repositorioReciboDePago.Guardar(reciboDePago);
                    return $"Datos del recibo de pago Guardados con exito";
                }
                return $"El recibo de pago con identificacion :{reciboDePago.IdReciboPago }, perteneciente a {reciboDePago.EntidadServicio} ya se encuentra registrado";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos:  { e.Message }";
            }
        }
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            respuestaConsulta.Error = false;
            try
            {
                respuestaConsulta = ObtenerRespuetaConsulta(respuestaConsulta);
                return respuestaConsulta;
            }
            catch (Exception e)
            {
                respuestaConsulta.Error = true;
                respuestaConsulta.Mensaje = $"Error : {e.Message}";
                return respuestaConsulta;
            }
        }
        public RespuestaConsulta ObtenerRespuetaConsulta(RespuestaConsulta respuetaConsulta)
        {
            respuetaConsulta.RecibosDePago = repositorioReciboDePago.Consultar();
            if (respuetaConsulta.RecibosDePago.Count > 0)
            {
                respuetaConsulta.Mensaje = $"Registro de recibo de pago";
                return respuetaConsulta;
            }
            else
            {
                respuetaConsulta.Mensaje = $"No se encuentran recibos de pagos  resgistrados";
                return respuetaConsulta;
            }
        }
        public int CantidadRecibosDePago()
        {
            return repositorioReciboDePago.CantidadRecibosDePago();
        }
        public IList<ReciboDePago> ConsultaPorFecha(DateTime fecha)
        {
            return repositorioReciboDePago.ConsultaPorFecha(fecha);
        }
        public IList<ReciboDePago> ConsultarPorFechaYEntidad(string entidadServicio, DateTime fecha)
        {
            return repositorioReciboDePago.ConsultarPorFechaYEntidad(entidadServicio,fecha);
        }
        public int CantidadPorFechaYEntidad(string entidadServicio, DateTime fecha)
        {
            return repositorioReciboDePago.CantidadPorFechaYEntidad(entidadServicio,fecha);
        }
        public decimal ObtenerRecaudoPorFechaYEntidad(string entidadServicio, DateTime fecha)
        {
            return repositorioReciboDePago.ObtenerRecaudoPorFechaYEntidad(entidadServicio,fecha);
        }
        public decimal ObtenerRecaudoGeneral()
        {
            return repositorioReciboDePago.ObtenerRecaudoGeneral();
        }
    }
    public class Respuesta
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        
    }
    public class RespuestaConsulta :Respuesta
    {
        public IList<ReciboDePago> RecibosDePago { get; set; }
    }

}
