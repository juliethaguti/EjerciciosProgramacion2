using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        protected bool ValidarArchivo(string ruta)
        {
            bool retorno = false;

            if(File.Exists(ruta))
            {
                retorno = true;
            }
            else
            {
                throw new FileNotFoundException();
            }
            return retorno;
        }
    }
}
