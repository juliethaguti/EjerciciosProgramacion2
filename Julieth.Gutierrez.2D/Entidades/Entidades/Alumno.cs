using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        #region Propiedades
        public string AnioDivision 
        {
            get
            {

                return String.Format("{0}º{1}",this.anio,this.division).ToString();
            }
        }
        #endregion

        #region Constructor
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        #endregion

        #region Métodos
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("AÑO-DIVISION: " + this.AnioDivision);
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            string patron = "^\\d{2}-\\d{4}-\\d{1}$";
            if (Regex.IsMatch(doc, patron))
            {
                retorno =true;
            }
            return retorno;
        }
        #endregion
    }
}
