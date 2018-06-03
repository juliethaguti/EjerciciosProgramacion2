using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.*/

namespace ClassEjercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;
            char respuesta;

            do{
                Console.WriteLine("Ingrese un numero");
                int.TryParse(Console.ReadLine(),out numero);

                suma += numero;

                Console.WriteLine("La suma es: {0}",suma);
                Console.WriteLine("¿Continuar? (S/N)");
                char.TryParse(Console.ReadLine(), out respuesta);              

            }while(ValidarRespuesta.ValidaS_N(respuesta));
            //Console.ReadLine();
        }
    }
}
