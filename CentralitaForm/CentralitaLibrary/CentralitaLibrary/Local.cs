using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        #region Propiedades
        public override float CostoLlamada 
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("LLAMADA LOCAL");
            sb.AppendLine("COSTO DE LA LLAMADA:" + this.CostoLlamada);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
