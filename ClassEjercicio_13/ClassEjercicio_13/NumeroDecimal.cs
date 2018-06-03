using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_13
{
    class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(string numeroBinario, double numeroDecimal)
        {
            
            return Conversor.BinarioDecimal(numeroBinario) + numeroDecimal;
        }

        public static double operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double Binario = Conversor.BinarioDecimal(numeroBinario.numero);

            double resta = Binario - numeroDecimal.numero;

            return resta;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            bool retorno = false;

            double Binario = Conversor.BinarioDecimal(numeroBinario.numero);

            if (Binario == numeroDecimal.numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            bool retorno = false;

            double Binario = Conversor.BinarioDecimal(numeroBinario.numero);

            if (Binario != numeroDecimal.numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            NumeroDecimal objDecimal;
            return objDecimal = new NumeroDecimal(numero);
        }
    }
}
