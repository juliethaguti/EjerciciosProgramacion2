using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_30
{
    public class Motocross : VehiculoDeCarrera
    {
        private short cilindrada;

        #region Propiedad
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        #endregion

        #region Constructores
        public Motocross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }
        public Motocross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion

        #region Metodo
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CILINDRADA: " + this.Cilindrada);

            return sb.ToString();
        }
        #endregion

        #region sobrecarga
        public static bool operator ==(Motocross a1, Motocross a2)
        {
            bool retorno = false;

            if (a1.Cilindrada == a2.Cilindrada && (VehiculoDeCarrera)a1 ==(VehiculoDeCarrera)a2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Motocross a1, Motocross a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
