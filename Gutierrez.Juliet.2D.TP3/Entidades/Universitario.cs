using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Propiedades
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
        }
        #endregion
        #region Constructores
        public static Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Métodos
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("LEGAJO: {0}", this.legajo);
            sb.AppendFormat("\nNOMBRE: {0}", this.Nombre);
            sb.AppendFormat("\nAPELLIDO: {0}", this.Apellido);
            sb.AppendFormat("\nDNI: {0}", this.StringToDNI);
            sb.AppendFormat("\nNACIONALIDAD: {0}", this.Nacionalidad);

            return sb.ToString();

        }

        protected abstract string ParticiparEnClase();
        #endregion

        #region sobrecargas de Operadores
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;

            if(pg1.GetType() == pg2.GetType() && pg1.legajo == pg2.legajo && pg1.StringToDNI == pg2.StringToDNI)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
