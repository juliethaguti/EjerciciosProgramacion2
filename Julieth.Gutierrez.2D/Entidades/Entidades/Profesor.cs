using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        #region Propiedades
        public int Antiguedad 
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                
                return (fechaActual - fechaIngreso).Days;
            }
        }
        #endregion

        #region Constructores
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        #endregion

        #region Métodos
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("ANTIGÜEDAD: " + this.Antiguedad);
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            var charDoc = doc.ToCharArray();

            if (charDoc.Length == 8)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
