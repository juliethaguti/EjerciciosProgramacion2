using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int suma;
            int cantidad = 0;
            int numero = 2;

            do
            {
                suma = 0;
                for (i = 1; i < numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        suma = suma + i;

                        if (suma > numero)
                            break;
                    }
                }
                if (suma == numero)
                {
                    Console.WriteLine("Numero Perfecto: {0}", numero);
                    cantidad++;
                }
                numero++;
            } while (cantidad < 4);
            Console.ReadLine();
        }
    }
}
