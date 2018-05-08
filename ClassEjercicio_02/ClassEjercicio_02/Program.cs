using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxiliar;
            int numero;

            Console.Title = "Ejercicio Nro 02";

            Console.WriteLine("Ingrese un numero entero: ");
            auxiliar = Console.ReadLine();
            int.TryParse(auxiliar, out numero);

            if (numero > 0)
            {
                Console.WriteLine("El cuadrado de ese numero es: {0}", Math.Pow(numero, 2));
                Console.WriteLine("El cubo de ese numero es: {0}", Math.Pow(numero, 3));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
