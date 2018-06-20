﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_54
{
    class FallaLogException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region Propiedades
        public Exception ExcepcionInterna
        {
            get
            {
                return this.InnerException;
            }
        }
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

        #region Constructores
        public FallaLogException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {

        }

        public FallaLogException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion
    }
}
