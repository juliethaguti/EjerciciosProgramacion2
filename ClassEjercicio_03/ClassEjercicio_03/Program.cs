using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int numero;
            string auxiliar;

            Console.Title("Ejercicio Nro 03");
            Console.WriteLine("Ingrese un numero");
            auxiliar = Console.ReadLine();
            int.TryParse(auxiliar, out numero);

            for (i = 2; i <= numero; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine("{0} es primo",i);
                }
            }
            Console.ReadLine();
        }
    }
}
