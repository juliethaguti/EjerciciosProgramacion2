using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_52
{
    class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        #region Propiedades
        public ConsoleColor Color 
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        #endregion

        #region Constructor
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }
        #endregion
        
        #region Métodos
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura - (texto.Length * (float)0.3);
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura + (float)unidades;
            return true;
        } 
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("BOLIGRAFO");
            sb.AppendLine("COLOR: " + this.Color);
            sb.AppendLine("NIVEL DE TINTA: " + this.UnidadesDeEscritura);

            return sb.ToString();
        }
        #endregion
    }
}
