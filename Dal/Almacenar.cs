using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dal
{
    public class Almacenar
    {
        private FileStream flujoDelFichero;
        public void Guardar(string datosReciboDePago,string ruta)
        {
            flujoDelFichero = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(flujoDelFichero);
            escritor.WriteLine(datosReciboDePago);
            escritor.Close();
            flujoDelFichero.Close();
        }
    }
}
