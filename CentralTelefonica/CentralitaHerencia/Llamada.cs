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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION: "+this.Duracion.ToString()+" DESTINO: "+this.NroDestino+
                " ORIGEN: "+this.NroOrigen);

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            SortedList<>
        }
    }
}
