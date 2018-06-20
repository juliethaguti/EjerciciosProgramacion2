using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class PuntoDat : Archivo, IArchivos<T>
    {
        private string contenido;

        #region Propiedades
        public string Contenido 
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        #endregion

        #region Métodos
        public bool Guardar(PuntoDat ruta)
        {
            bool retorno = false;
            return retorno;
        }

        private PuntoDat Leer(string ruta)
        {

        }

        protected bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            return retorno;
        }
        #endregion
    }
}
