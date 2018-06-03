using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Pesos()
        {
            
        }

          public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public static explicit operator Dolar (Pesos p)
        {
            double dolares = p.cantidad/17.55;
             return new Dolar(dolares);
        }

        public static explicit operator Euro(Pesos p)
        {
            double euros = (p.cantidad / 17.55) / 1.3642;
            return new Euro(euros);
        }
        public static implicit operator Pesos(double d)
        {
            Pesos retValue = new Pesos(d);
            return retValue;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            bool retorno = false;
            Pesos dolares = (Pesos)d;

            if (p.cantidad != dolares.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            bool retorno = false;
            Pesos euros = (Pesos)e;

            if (p.cantidad != euros.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if (p1.cantidad != p2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return retorno;
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return retorno;
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return retorno;
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return retorno;
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;
            Pesos dolares = (Pesos)d;

            if (p.cantidad == dolares.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;
            Pesos euros = (Pesos)e;

            if (p.cantidad == euros.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if (p1.cantidad == p2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
    }
    class Euro
    {
        private double cantidad;
        private float cotizRespectoDolar;

        Euro()
        {
            this.cantidad = 0;
        }
        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion) : this (cantidad)
        {     
            this.cotizRespectoDolar = cotizacion;
        }
        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro e)
        {
            double dolares = e.cantidad * 1.3642;
            return new Dolar(dolares);
        }
        public static explicit operator Pesos(Euro e)
        {
            double pesos = e.cantidad * 1.3642 * 17.55;
            return new Pesos(pesos);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            bool retorno = false;
            Euro dolares = (Euro)d;

            if (e.cantidad != dolares.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            bool retorno = false;
            Euro pesos = (Euro)p;

            if (e.cantidad != pesos.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)d).cantidad);
            return retorno;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)p).cantidad);
            return retorno;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)d).cantidad);
            return retorno;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)p).cantidad);
            return retorno;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            Euro dolares = (Euro)d;

            if (e.cantidad == dolares.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;
            Euro pesos = (Euro)p;

            if (e.cantidad == pesos.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1.cantidad == e2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1.cantidad != e2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
    }
    class Dolar
    {
        private double cantidad;
        private float cotizRespectoDolar;

        Dolar()
        {
            this.cantidad = 0;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }
        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad / 1.3642));
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos((d.cantidad * 17.55));
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            bool retorno = false;
            Dolar pesos = (Dolar)p;

            if (d.cantidad != pesos.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = false;
            Dolar euros = (Dolar)e;

            if (d.cantidad != euros.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.cantidad != d2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return retorno;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return retorno;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;
            Dolar pesos = (Dolar)p;

            if (d.cantidad == pesos.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            Dolar euros = (Dolar)e;

            if (d.cantidad == euros.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.cantidad == d2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
