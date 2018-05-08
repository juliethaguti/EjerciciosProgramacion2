using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2ParcialLaboratorio2
{
    abstract class Persona
    {
        private string apellido;
        private string nombre;

        #region Propiedades
        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        protected abstract string FichaTecnica();
        protected virtual string NombreCompleto()
        {
            string retorno = String.Format("{0} {1}",this.Nombre,this.Apellido);

            return retorno;
        }

    }
}
