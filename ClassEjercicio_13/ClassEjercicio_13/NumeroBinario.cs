using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_13
{
    class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario numeroBinario,NumeroDecimal numeroDecimal)
        {
            double Binario = Conversor.BinarioDecimal(numeroBinario.numero);

            double suma = Binario + numeroDecimal.numero;

             return Conversor.DecimalBinario(suma);
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double Binario = Conversor.BinarioDecimal(numeroBinario.numero);

            double resta = Binario - numeroDecimal.numero;

            return Conversor.DecimalBinario(resta);
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

        public static implicit operator NumeroBinario(string numero)
        {
            NumeroBinario objBinario;   
            return objBinario = new NumeroBinario(numero);
        }
    }
}
