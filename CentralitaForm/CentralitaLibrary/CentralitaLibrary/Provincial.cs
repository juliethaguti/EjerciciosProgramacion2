using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        protected Franja _franjaHoraria;
        public string rutaDeArchivo;

        public enum Franja
        {
            Franja_1 = 99, 
            Franja_2 = 125, 
            Franja_3 = 66
        }
        #region Propiedades
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }
        public override float CostoLlamada 
        { 
            get
            {
                return this.CalcularCosto();
            } 
        }
        #endregion
        
        #region Constructores
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

        #region Métodos
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
         protected override string Mostrar()
         {
             StringBuilder sb = new StringBuilder();

             sb.Append(base.Mostrar());
             sb.AppendLine("COSTO DE LA LLAMADA:" + this.CostoLlamada);
             sb.AppendLine("FRANJA HORARIA"+this._franjaHoraria);

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

         public bool Guardar()
         {
             throw new NotImplementedException();
         }

         public Provincial Leer()
         {
             throw new NotImplementedException();
         }
        #endregion
    }
}
