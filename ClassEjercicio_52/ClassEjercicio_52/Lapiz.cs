using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_52
{
    class Lapiz : IAcciones
    {
        private float tamanioMina;

        #region Propiedades
        public ConsoleColor Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        #endregion

        #region Constructor
        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }
        #endregion

        #region Métodos
        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura - (texto.Length * 0.1f);
            return new EscrituraWrapper(texto, this.Color);
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LAPIZ");
            sb.AppendLine("COLOR: " + this.Color);
            sb.AppendLine("TAMAÑO MINA: " + this.UnidadesDeEscritura);

            return sb.ToString();
        }
        #endregion
    }
}
