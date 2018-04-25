using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        #region Contructores

        public Provincial(Franja miFranja, Llamada llamada) :this(llamada.NroOrigen, miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        #endregion

        public float CostoLlamada 
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)Franja.Franja_1/100; 
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION: " + base.Duracion.ToString() + "DESTINO: " + base.NroDestino + "ORIGEN: " + base.NroOrigen
                + "COSTO: " + this.CostoLlamada.ToString());

            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }
    }
}
