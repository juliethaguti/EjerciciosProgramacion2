using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int anio;

            Console.WriteLine("Ingrese un año");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out anio);

             
            
            if ((anio % 100 == 0) && (anio % 400 == 0))
            {
                Console.WriteLine("El anio {0} es bisiesto", anio);
            }
            else
            {
                if (anio % 4 == 0 && anio % 100 != 0)
                {
                    Console.WriteLine("El anio {0} es bisiesto", anio);
                }
                else
                {
                    Console.WriteLine("El anio {0} no es bisiesto", anio);
                }                              
            }            
            Console.ReadLine();
        }
    }
}
