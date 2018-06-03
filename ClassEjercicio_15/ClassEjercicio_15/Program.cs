using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea tres métodos estáticos (de clase):
a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.
c. Mostrar (público): Este método recibe como parámetro el resultado de la operación y lo
muestra por pantalla. No posee valor de retorno.*/

namespace ClassEjercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerNumero;
            double segundoNumero;
            char operacion;
            char respuesta;
            Console.Title = "Ejercicio Nro 15";

            Console.WriteLine("***********CALCULADORA************");
            do{
            Console.WriteLine("Ingrese el primer numero");
            double.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Inrgese el segundo numero");
            double.TryParse(Console.ReadLine(), out segundoNumero);
            Console.WriteLine("Ingrese la operacion que quiere realizar +, -, * ó /");
            char.TryParse(Console.ReadLine(), out operacion);
            Calculadora.Mostrar(Calculadora.Calcular(primerNumero, segundoNumero, operacion));
            Console.WriteLine("Continuar? S/N");
            char.TryParse(Console.ReadLine(),out respuesta);

            }while(respuesta == 'S');
        }
    }
}
