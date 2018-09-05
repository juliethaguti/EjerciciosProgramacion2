using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_21
{
    public class Celsius
    {
        private double temperatura;

        #region Constructores
        static Celsius()
        { }
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion

        #region sobrecargas
        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            double fahrenheit = c.temperatura * (9 / 5) + 32;
            return new Fahrenheit(fahrenheit);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            double kelvin = (((Fahrenheit)c).GetTemperatura() + 459.67) * 5 / 9;
            return new Kelvin(kelvin);
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool retorno = false;

            if(c1 == c2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool retorno = false;
            Celsius fahrenheit = (Celsius)f;
            if(c.temperatura == fahrenheit.temperatura)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool retorno = false;

            if(c.temperatura == ((Celsius)k).temperatura)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return c.temperatura + ((Celsius)f).GetTemperatura();
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return c.temperatura + ((Celsius)k).GetTemperatura();
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return c.temperatura - ((Celsius)f).GetTemperatura();
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return c.temperatura - ((Celsius)k).GetTemperatura();
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
