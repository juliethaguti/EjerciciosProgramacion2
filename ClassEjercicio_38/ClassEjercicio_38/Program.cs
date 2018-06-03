using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2017";
            //Sobreescrito sobrecarga = new Sobreescrito();
            SobreSobreescrito sobrecarga = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());

            string objeto = "¡Este es mi metodo Tostring sobreescrito!";

            Console.WriteLine("-------------------------------------");
            Console.Write("Comparacion Sobrecargas con string: ");
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.MiPropiedad);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.MiMetodo());
            Console.ReadKey();
        }
    }
}
