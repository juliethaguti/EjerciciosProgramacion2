using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador prueba = new Sumador();
            Console.WriteLine("La suma en numeros es: {0}",prueba.Sumar(22,38));
            Console.WriteLine("La suma en caracteres es: {0}",prueba.Sumar("Juliet","Andrea"));

            Sumador prueba2 = new Sumador(7);
            Console.WriteLine("{0}",(int)prueba);
            Console.WriteLine("{0}",prueba + prueba2);
            Console.WriteLine("{0}",prueba | prueba2);

            Console.ReadLine();
        }
    }
}
