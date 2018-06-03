using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        #region Propiedades
        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento 
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (this.ValidarDocumentacion(value))
                    {
                        this.documento = value;
                    }
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
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }
        #endregion

        #region Métodos
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: " + this.Nombre);
            sb.AppendLine("APELLIDO: " + this.Apellido);
            sb.AppendLine("DOCUMENTO: " + this.Documento);

            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);
        #endregion
    }
}
