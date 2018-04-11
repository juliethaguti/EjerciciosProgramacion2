using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random cargaNumeros = new Random();
            int[] numerosEnteros = new int[20];
            int i;


            for (i = 0; i < 20; i++)
            {
                numerosEnteros[i] = (int)cargaNumeros.Next(-100,100);
                Console.WriteLine(numerosEnteros[i]);
                
            }
            Console.WriteLine("Numeros ordenados");
            for (int j = 19; j >= 0; j--)
            {
                Array.Sort(numerosEnteros);
                if (numerosEnteros[j] > 0)
                {
                    Console.WriteLine(numerosEnteros[j]);
                }
            }
            for (int k = 0; k < 20; k++)
            {
                //Array.Sort(numerosEnteros);
                if (numerosEnteros[k] < 0)
                {
                    Console.WriteLine(numerosEnteros[k]);
                }
            }
            Console.ReadLine();
        }
    }
}
