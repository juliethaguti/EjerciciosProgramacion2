using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEjercicio_51;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float _costo;
        private string rutaDeArchivo;

        #region Propieades
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
                return CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("COSTO: " + this.CostoLlamada);

            return sb.ToString();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
