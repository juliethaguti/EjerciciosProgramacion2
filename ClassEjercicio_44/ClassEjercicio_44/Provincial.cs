using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    #region Enumeraciones
    public enum Franja
    {
        Franja_1 = 99,
        Franja_2 = 125,
        Franja_3 = 66
    }
    #endregion
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        #region Contructores

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)Franja.Franja_1 / 100;
                    break;
                case Franja.Franja_2:
                    costo = base.Duracion * (float)Franja.Franja_2 / 100;
                    break;
                case Franja.Franja_3:
                    costo = base.Duracion * (float)Franja.Franja_3 / 100;
                    break;
            }
            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("COSTO: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        #endregion
    }
}
