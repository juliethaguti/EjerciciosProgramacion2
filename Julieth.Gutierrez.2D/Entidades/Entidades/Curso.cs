using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        #region Propiedades
        public string AnioDivision 
        {
            get
            {

                return String.Format("{0}º{1}",this.anio,this.division).ToString();
            }
        }
        #endregion

        #region Constructores
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        #endregion

        #region Sobrecargas
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AÑO-DIVISION:" + c.AnioDivision);
            sb.AppendLine("PROFESOR: "+c.profesor.ExponerDatos());
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine(alumno.ExponerDatos());
            }
            return sb.ToString();
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;

            if (a.AnioDivision == c.AnioDivision)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
