using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_13
{
    class Conversor
    {
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string DecimalBinario(double numero)
        {
            //double resto;
            string binario = "";
            while(numero > 1)
            {

                if(numero % 2 == 0)
                {
                    binario = binario + "0";
                }
                else
                {
                    binario = binario + "1";

                }
             numero = (int)numero/2;   
            }
            binario += "1";
            
            return Conversor.Reverse(binario);
        }
        public static double BinarioDecimal(string numeroBinario)
        {
            char caracterBinario;
            double auxBinario;
            int i;
            double suma = 0;
            string numeroBinarioReverse = Conversor.Reverse(numeroBinario);

            for (i = numeroBinario.Length-1; i >= 0 ; i--)
            {
                auxBinario = Math.Pow(2,i);
                
                caracterBinario = numeroBinarioReverse[i];

                if(caracterBinario == '1')
                {
                    suma = auxBinario + suma;
                }              
            }
            return suma;
        }

    }
}
