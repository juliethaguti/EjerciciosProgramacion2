using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int altura;

            Console.WriteLine("Ingrese la altura de la piramide: ");
            int.TryParse(Console.ReadLine(), out altura);

            for ( i = 0; i < altura; i++)
            {
                for (j = 0; j <= (altura-i); j++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
