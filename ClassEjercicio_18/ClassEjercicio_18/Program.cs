using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";
            punto verticeUno = new punto(0,4);
            punto verticeTres = new punto(6, 0);
            rectangulo nuevoRectangulo = new rectangulo(verticeUno,verticeTres);

            Console.WriteLine("El area del rectangulo es: {0}",nuevoRectangulo.GetArea());
            Console.WriteLine("El perimetro del triangulo es: {0}", nuevoRectangulo.GetPerimetro()); 
            nuevoRectangulo.mostrarDatosRectangulo(nuevoRectangulo.GetBase(),nuevoRectangulo.GetAltura());
            Console.ReadLine();

        }
    }
}
