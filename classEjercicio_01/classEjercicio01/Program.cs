using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classEjercicio01
{
    class classEjercicio01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int numero,i,numeroMaximo = 0,numeroMinimo = 0;
            int cantidadNumeros = 5;
            int flag = 0;
            float promedio = 0;
            int suma = 0;
            string entrada;

            for (i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();
                int.TryParse(entrada,out numero);
                suma = suma + numero;

                if (flag == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                    flag = 1;
                }
                else
                {
                    
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }
            }
            promedio = suma / (float)5;

            Console.WriteLine("El numero maximo es: {0}", numeroMaximo);
            Console.WriteLine("El numero minimo es: {0}", numeroMinimo);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadLine();


        }
    }
}
