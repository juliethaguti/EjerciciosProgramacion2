using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.*/

namespace ClassEjercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int cantidad = 0;
            int numero;
            int suma = 0;
            float promedio;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int flag = 0;

            Console.WriteLine("Ingrese 10 numeros");
            do
            {

                Console.WriteLine("Ingrese un numero entre -100 y 100");
                int.TryParse(Console.ReadLine(), out numero);

                if (Validacion.Validar(numero, -100, 100))
                {
                    suma += numero;

                    if (flag == 0)
                    {
                        numeroMaximo = numero;
                        numeroMinimo = numero;
                        flag = 1;
                    }
                    else if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("El numero no es valido");
                    break;
                }
            } while (cantidad < 10);
            promedio = (float)suma / 10;
            Console.WriteLine("El promedio es: {0}",promedio);
            Console.WriteLine("El numero minimo es: {0}", numeroMinimo);
            Console.WriteLine("El numero maximo es: {0}",numeroMaximo);
            Console.ReadLine();
        }
    }
}
