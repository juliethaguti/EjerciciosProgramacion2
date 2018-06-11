using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_43
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region Propiedades
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
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, mensaje, null)
        {

        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }   
        #endregion

        #region Metodo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Excepción en el método {0} de la clase {1}:",this.NombreMetodo,this.NombreClase);
            sb.AppendLine(this.Message);
            Exception e = this.InnerException;
            do
            {
                sb.AppendLine("\t" + e.Message);
            } while (!ReferenceEquals(e.InnerException, null));

            return sb.ToString();
        }
        #endregion
    }
}
