using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dal;

namespace Bll
{
    public class ServicioExportar
    {
        public IList<ReciboDePago> RecibosDePago { get; set; }
        RepositorioExportacion repositorioExportacion = new RepositorioExportacion();

        public string Exportar(IList<ReciboDePago> reciboDePago)
        {
            try
            {
                repositorioExportacion.RecibosDePago = reciboDePago;
                repositorioExportacion.Exportar();
                return $"datos exportados con exito";
            }
            catch (Exception e)
            {

                return $"error : {e.Message}";
            }
        }
    }
}
