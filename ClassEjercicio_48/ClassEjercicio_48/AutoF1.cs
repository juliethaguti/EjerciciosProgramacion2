using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_30
{
    public class AutoF1 : VehiculoDeCarrera
    {
        //private short cantidadCombustible;
        //private bool enCompetencia;
        //private string escuderia;
        //private short numero;
        //private short vueltaRestante;
        private short caballosDeFuerza;

        #region Propiedades
        public short CaballosDeFuerza 
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballoDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region Método
        public override string MostrarDatos()
        {
            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.Append(base.MostrarDatos());
            myStringBuilder.AppendLine("CABALLOS DE FUERZA: " + this.CaballosDeFuerza);

            return myStringBuilder.ToString();
        }
        #endregion

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1.CaballosDeFuerza == a2.CaballosDeFuerza && (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2)
            {
                retorno = true;
            }

            return retorno;
        }
        
    }
}
