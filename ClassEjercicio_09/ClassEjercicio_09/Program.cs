using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.*/

namespace ClassEjercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int altura;

            Console.WriteLine("Ingrese la altura de la piramide");
            int.TryParse(Console.ReadLine(),out altura);

            for (i = 1; i <= altura * 2; i+=2)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
