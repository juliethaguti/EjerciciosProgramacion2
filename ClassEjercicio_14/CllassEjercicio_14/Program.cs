using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main()*/

namespace CllassEjercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double areaCuadrado;
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;

            Console.Title = "Ejercicio Nro 14";
            do{
                Console.WriteLine("1- Calcular el area de un cuadrado");
                Console.WriteLine("2- Calcular area de un Triangulo");
                Console.WriteLine("3- Calcular el area de un circulo");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Ingrese una opcion");
                int.TryParse(Console.ReadLine(),out opcion);

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese un lado del cuadrado");
                        double.TryParse(Console.ReadLine(), out ladoCuadrado);
                        areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                        Console.WriteLine("El area del cuadrado es: {0}",areaCuadrado);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la base del triangulo");
                        double.TryParse(Console.ReadLine(), out baseTriangulo);
                        Console.WriteLine("Ingrese la altura del triangulo");
                        double.TryParse(Console.ReadLine(),out alturaTriangulo);
                        Console.WriteLine("El area del triangulo es {0}",CalculoDeArea.CalcularTriangulo(baseTriangulo,alturaTriangulo));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el radio del circulo");
                        double.TryParse(Console.ReadLine(), out radioCirculo);
                        Console.WriteLine("El area del circulo es: {0}", CalculoDeArea.CalcularCirculo(radioCirculo));
                        break;
                    default:
                        break;
                }
            }while(opcion != 4);
        }
    }
}
