using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;

        }

        public float Duracion 
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino 
        {
            get
            {
                return this._nroDestino;
            }            
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public string Mostrar()//virtual
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION: "+this.Duracion.ToString()+" DESTINO: "+this.NroDestino+
                " ORIGEN: "+this.NroOrigen);

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1 != null && llamada2 != null)
            {
                if (llamada1.Duracion > llamada2.Duracion)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = -1;
                }
            }
            return retorno;
        }

        public enum TipoLlammada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
