using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada 
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }

        private float CalcularCosto()
        {
            return base.Duracion * this.CostoLlamada;
             
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION: "+base.Duracion.ToString()+"DESTINO: "+base.NroDestino+"ORIGEN: "+base.NroOrigen
                +"COSTO: "+this.CostoLlamada.ToString());

            return sb.ToString();
        }
    }
}
