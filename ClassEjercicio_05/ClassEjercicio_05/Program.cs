using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumaAnteriorNumero;
            int sumaPosteriorNumero;
            int i,j,k;
            string entrada;

            Console.WriteLine("Ingrese un numero: ");
            entrada = Console.ReadLine();

            int.TryParse(entrada,out numero);

            for (k = 2; k <= numero; k++)
            {
                sumaAnteriorNumero = 0;
                sumaPosteriorNumero = 0;
                for (i = 1; i < k; i++)
                {
                    sumaAnteriorNumero = sumaAnteriorNumero + i;
                }
                for (j = k + 1; sumaPosteriorNumero < sumaAnteriorNumero; j++)
                {
                    sumaPosteriorNumero = sumaPosteriorNumero + j;
                }
                if(sumaAnteriorNumero == sumaPosteriorNumero)
                {
                    Console.WriteLine("Numero centrico: {0}",k);
                    Console.ReadLine();
                }
            }
        }
    }
}
