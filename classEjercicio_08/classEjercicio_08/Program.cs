using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de ‗n‘ empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.*/

namespace classEjercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombreEmpleado;
            int antiguedad;
            int cantidadHorasTrabajadas;
            float valorBruto;
            double valorDescuentos;
            double valorNeto;
            char respuesta  = 's';

            Console.Title = "Ejercicio Nro 08";
            do
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombreEmpleado = Console.ReadLine();
                Console.WriteLine("Ingrese el valor hora trabajada por e empleado:");
                float.TryParse( Console.ReadLine(),out valorHora);
                Console.WriteLine("Cantidad de años trabajados por el empleado?");
                int.TryParse(Console.ReadLine(),out antiguedad);
                Console.WriteLine("Cantidad de horas trabajadas en el mes?");
                int.TryParse(Console.ReadLine(),out cantidadHorasTrabajadas);

                valorBruto = (cantidadHorasTrabajadas * valorHora) + (antiguedad * 150);
                valorDescuentos = valorBruto * 0.13;
                valorNeto = (double)valorBruto - valorDescuentos;

                Console.WriteLine("NOMBRE: {0} ANTIGUEDAD: {1} VALOR HORA: {2} TOTAL BRUTO: {3} TOTAL DESCUENTOS: {4} TOTAL NETO: {5}",nombreEmpleado,antiguedad,valorHora,valorBruto,valorDescuentos,valorNeto);

                Console.WriteLine("Seguir agregando empleados?");
                char.TryParse(Console.ReadLine(),out respuesta);
               

            }while(respuesta == 's');
        }
    }
}
