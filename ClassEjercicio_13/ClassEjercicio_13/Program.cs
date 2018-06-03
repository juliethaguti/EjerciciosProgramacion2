using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.*/

namespace ClassEjercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double nrodecimal;
            string nrobinario;
            double resultado;
            NumeroDecimal numeroDecimal;
            NumeroBinario numeroBinario;

            Console.WriteLine("1- Suma de numeros resultado decimal");
            Console.WriteLine("2- Suma de numeros resultado binario");
            int.TryParse(Console.ReadLine(),out opcion);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el numero decimal");
                    double.TryParse(Console.ReadLine(), out nrodecimal);
                    numeroDecimal = nrodecimal;
                    Console.Write("Ingrese numero binario");
                    nrobinario = Console.ReadLine();
                    numeroBinario = nrobinario;
                    Console.WriteLine(nrobinario + nrodecimal);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el numero binario");
                    Console.WriteLine("El numero decimal es:{0}",Conversor.BinarioDecimal(Console.ReadLine()));
            Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
