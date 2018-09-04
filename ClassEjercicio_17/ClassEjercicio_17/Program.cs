using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string gasto = "Hola";
            string gastoLapiceroRojo = "Se escribe lapicero";
            string dibujo;

            Boligrafo lapiceroAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo lapiceroRojo = new Boligrafo(50, ConsoleColor.Red);

            if(lapiceroAzul.Pintar(gasto.Length,out dibujo))
            {
                Console.ForegroundColor = lapiceroAzul.GetColor();
                Console.WriteLine(gasto);
                Console.WriteLine("{0}", dibujo);
            }

            if (lapiceroRojo.Pintar(gastoLapiceroRojo.Length, out dibujo))
            {
                Console.ForegroundColor = lapiceroRojo.GetColor();
                Console.WriteLine(gasto);
                Console.WriteLine("{0}", dibujo);
            }

            Console.ReadKey();
        }
    }
}
