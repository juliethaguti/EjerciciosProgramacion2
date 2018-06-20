using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Propiedades
        public abstract float CostoLlamada
        {
            get;
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
        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._nroOrigen = nroOrigen;
            this._nroDestino = nroDestino;
            this._duracion = duracion;
        }
        #endregion

        #region Métodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION: " + this.Duracion);
            sb.AppendLine("DESTINO: " + this.NroDestino);
            sb.AppendLine("ORIGEN: " + this.NroOrigen);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Sobrercargas
        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            bool retorno = false;
            if (llamadaUno.Equals(llamadaDos) && llamadaUno.NroDestino == llamadaDos.NroDestino
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
