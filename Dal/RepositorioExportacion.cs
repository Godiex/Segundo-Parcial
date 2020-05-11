using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dal
{
    public class RepositorioExportacion
    {
        public void Exportar(string datosReciboDePago,string nombre)
        {
            Almacenar almacenar = new Almacenar();
            string ruta = ObtenerNombreArchivoExportado(nombre);
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            almacenar.Guardar(datosReciboDePago,ruta);
        }
        public string ObtenerNombreArchivoExportado(string nombre)
        {
              return $"{nombre}.Txt";
        }
    }
}
