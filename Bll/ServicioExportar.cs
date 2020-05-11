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
        RepositorioExportacion repositorioExportacion = new RepositorioExportacion();

        public string  ExportarEncabezado (string datosReciboDePago ,string nombre)
        {
            try
            {
                repositorioExportacion.ExportarEncabezado(datosReciboDePago,nombre);
                return "exportacion realizada con exito";
            }
            catch (Exception e)
            {

                return $"error : {e.Message}";
            }
        }
        public string ExportarContenido(IList<ReciboDePago> datosReciboDePago, string nombre)
        {
            try
            {
                repositorioExportacion.ExportarContenido(datosReciboDePago, nombre);
                return "exportacion realizada con exito";
            }
            catch (Exception e)
            {

                return $"error : {e.Message}";
            }
        }
    }
}
