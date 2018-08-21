using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            string auxiliar;
            int cantidad = 0;
            int suma = 0;
            int maximo = 0;
            int minimo = 0;
            int flag = 0;
            float promedio = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entero");
                auxiliar = Console.ReadLine();
                int.TryParse(auxiliar, out numeroUno);
                suma = suma + numeroUno;

                if(flag == 0)
                {
                    maximo = numeroUno;
                    minimo = numeroUno;
                    flag = 1;
                }
                else
                {
                    if(numeroUno > maximo)
                    {
                        maximo = numeroUno;
                    }
                    if(numeroUno < minimo)
                    {
                        minimo = numeroUno;
                    }
                    if(cantidad == 4)
                    {
                        promedio = (float)suma / 5;
                    }
                }
                cantidad++;

            } while (cantidad < 5);

            Console.WriteLine("El maximo es: {0}", maximo);
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
