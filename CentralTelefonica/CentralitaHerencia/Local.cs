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
                return this._costo;
            }
        }

        public Local(Llamada llamada, float costo)
        {

        }
        private float CalcularCosto()
        {
            Llamada llamada = new Llamada(this.Duracion,this.NroDestino,this.NroOrigen);
            if()
        }
    }
}
