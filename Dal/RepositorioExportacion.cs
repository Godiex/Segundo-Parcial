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
        public void ExportarContenido(IList<ReciboDePago> datosReciboDePago,string nombre)
        {
            Almacenar almacenar = new Almacenar();
            string ruta = ObtenerNombreArchivoExportado(nombre);
            foreach (var item in datosReciboDePago)
            {
                almacenar.Guardar(item.DatosExportacion(), ruta);
            }
            
        }
        public void ExportarEncabezado(string datosReciboDePago, string nombre)
        {
            Almacenar almacenar = new Almacenar();
            string ruta = ObtenerNombreArchivoExportado(nombre);
            almacenar.Guardar(datosReciboDePago, ruta);
        }

        public string ObtenerNombreArchivoExportado(string nombre)
        {
              return $"{nombre}.Txt";
        }
    }
}
