using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_27
{
    class Program
    {
        private static int OrdenaDescendente(int num1, int num2)
        {
            return -num1.CompareTo(num2);
        }

        static void Main(string[] args)
        {
            int opcion;
            Random cargaNumeros = new Random();

            do
            {
                Console.WriteLine("\n1- Listas");
                Console.WriteLine("2- Pilas");
                Console.WriteLine("3- Colas");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        List<int> numerosEnteros = new List<int>();
                        for (int i = 0; i < 20; i++)
                        {
                            numerosEnteros.Add((int)cargaNumeros.Next(-100,100));
                        }
                        //Muestro los numeros
                        for (int i = 0; i < 20; i++)
                        {
                            Console.Write(numerosEnteros[i] + " ");
                        }
                        //Console.ReadKey();

                        Console.WriteLine("\nNumeros positivos en orden descendente");
                        numerosEnteros.Sort(OrdenaDescendente);
                        foreach (int numero in numerosEnteros)
                        {
                            if (numero > 0)
                            {
                                Console.Write(numero + " ");
                            }
                        }

                        Console.WriteLine("\nNumeros negativos en oreden ascendente");
                        numerosEnteros.Sort();
                        
                        foreach (int numero in numerosEnteros)
                        {
                            if (numero < 0)
                            {
                                Console.Write(numero + " ");
                            }
                        }
                        break;
                    case 2:
                        Stack<int> PilaNumerosEnteros = new Stack<int>();
                        for(int i = 0;i < 20; i++)
                        {
                            PilaNumerosEnteros.Push((int)cargaNumeros.Next(0,100));
                        }

                        foreach(int numero in PilaNumerosEnteros)
                        {
                            Console.Write(numero+" ");
                        }
                        
                        while (PilaNumerosEnteros.Count > 0)
                        {
                            Console.WriteLine("\n Atender a {0}. Quedan {1} numeros en espera.",PilaNumerosEnteros.Pop(),PilaNumerosEnteros.Count);

                            System.Threading.Thread.Sleep(cargaNumeros.Next(1000,3000));
                        }
                        break;

                    case 3:
                        Queue<int> colaNumerosEnteros = new Queue<int>();
                        for(int i = 0;i < 20; i++)
                        {
                            colaNumerosEnteros.Enqueue((int)cargaNumeros.Next(0,100));
                        }

                        foreach(int numero in colaNumerosEnteros)
                        {
                            Console.Write(numero+" ");
                        }
                        
                        while (colaNumerosEnteros.Count > 0)
                        {
                            Console.WriteLine("\n Atender a {0}. Quedan {1} numeros en espera.",colaNumerosEnteros.Dequeue(),colaNumerosEnteros.Count);

                            System.Threading.Thread.Sleep(cargaNumeros.Next(1000,3000));
                        }
                        break;

                }
            } while (opcion == 1 || opcion == 2 || opcion == 3);
        }
    }
}
