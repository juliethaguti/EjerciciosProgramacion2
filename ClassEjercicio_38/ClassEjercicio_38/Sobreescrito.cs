using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_38
{
     class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public string MiPropiedad 
        {
            get
            {
                return this.miAtributo;
            }
        }
        public abstract string miMetodo();

        public string ToString()
        {
            return "¡Este es mi metodo Tostring sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj.GetType() == this.GetType())
            {
                retorno = true;
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
