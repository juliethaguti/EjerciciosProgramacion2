using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_21
{
    public class Farenheit
    {
        private double temperatura;

        #region Propiedades
        public double Temperatura 
        {
            get
            {
                return this.temperatura;
            }
        }
        #endregion

        #region Constructores
        public Farenheit()
        {
            this.temperatura = 0;
        }

        public Farenheit(double farenheit)
            : this()
        {
            this.temperatura = farenheit;
        }
        #endregion
    }
}
