using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltaRestante;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltaRestante;
            }
            set
            {
                this.vueltaRestante = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.Append("ESCUDERIA: " + this.escuderia + "NUMERO: " + this.numero + "EN COMPETENCIA: " + this.enCompetencia +
                "CANTIDAD DE COMBUSTIBLE: " + this.cantidadCombustible + "VUELTA RESTANTE: " + this.vueltaRestante);

            return myStringBuilder.ToString();
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if ((a1.numero != a2.numero) && (a1.escuderia != a2.escuderia))
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if ((a1.numero == a2.numero) && (a1.escuderia == a2.escuderia))
            {
                retorno = true;
            }

            return retorno;
        }
        
    }
}
