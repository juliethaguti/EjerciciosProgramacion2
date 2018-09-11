using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_21
{
    public class Fahrenheit
    {
        private double temperatura;

        #region Constructores
        static Fahrenheit()
        { }
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            double celsius = f.temperatura * (9 / 5) + 32;
            return new Celsius(celsius);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            double kelvin = (f.temperatura + 459.67) * 5 / 9;
            return new Kelvin(kelvin);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool retorno = false;

            if (f.temperatura == ((Fahrenheit)k).temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool retorno = false;

            if(f.temperatura == ((Fahrenheit)c).temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            bool retorno = false;
            if (f1.temperatura == f2.temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

    public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
    {
      return f.temperatura + ((Fahrenheit)k).GetTemperatura();
    }

    public static Fahrenheit operator +(Fahrenheit f, Celsius c)
    {
      return f.temperatura + ((Fahrenheit)c).GetTemperatura();
    }

    public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
    {
      return f.temperatura - ((Fahrenheit)k).GetTemperatura();
    }

    public static Fahrenheit operator -(Fahrenheit f, Celsius c)
    {
      return f.temperatura - ((Fahrenheit)c).GetTemperatura();
    }
        #endregion

        #region Métodos
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        # endregion
    }
}
