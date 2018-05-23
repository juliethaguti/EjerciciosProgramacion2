using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaLibrary
{
    class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region Propiedades
        public Exception ExcepcionInterna
        {
            get
            {
                ;
            }
        }
        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }
        #endregion

        #region Constructores
        public CentralitaException(string mensaje, string metodo)
            : this(mensaje, metodo, null)
        {

        }

        public CentralitaException(string mensaje, string metodo, Exception innerException)
            : base(mensaje,innerException)
        {

        }
    }
}
