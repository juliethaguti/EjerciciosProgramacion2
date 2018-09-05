using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_21
{
    public class Kelvin
    {
        private double temperatura;

        #region Constructores
        static Kelvin()
        { }
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator Kelvin(double k)
        {
            return new Kelvin(k);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            double fahrenheit = (k.temperatura * 9 / 5) - 459.67;
            return new Fahrenheit(fahrenheit);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            double celsius = ((Fahrenheit)k).GetTemperatura() * (9 / 5) + 32;
            return new Celsius(celsius);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            bool retorno = false;
            Kelvin fahrenheit = (Kelvin)f;
            if (k.temperatura == fahrenheit.temperatura)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator == (Kelvin k, Celsius c)
        {
            bool retorno = false;

            if(k.temperatura == ((Kelvin)c).temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool retorno = false;
            if(k1.temperatura == k2.temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return k.temperatura + ((Kelvin)f).temperatura;
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return k.temperatura + ((Kelvin)c).temperatura;
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return k.temperatura - ((Kelvin)f).temperatura;
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return k.temperatura - ((Kelvin)c).temperatura;
        }
        #endregion
    }
}
