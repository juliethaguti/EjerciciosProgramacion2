using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        #region Propiedades
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

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        #endregion

        #region Métodos 
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" DESTINO:"+this.NroDestino);
            sb.AppendLine(" ORIGEN:" + this.NroOrigen);
            sb.AppendLine(" DURACION:"+this.Duracion);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            bool retorno = false;
            if(llamadaUno.Equals(llamadaDos) && llamadaUno.NroDestino == llamadaDos.NroDestino
                && llamadaUno.NroOrigen == llamadaDos.NroOrigen)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }
        #endregion
    }
}
