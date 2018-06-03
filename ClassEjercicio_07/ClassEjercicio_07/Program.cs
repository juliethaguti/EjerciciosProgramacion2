using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaNacimiento;
            int mesNacimiento;
            int anioNacimiento;
            int diaHoy = DateTime.Now.Day;
            int mesHoy = DateTime.Now.Month;
            int anioHoy = DateTime.Now.Year;
            int diasVividos = 0;

            Console.WriteLine("Ingrese su fecha de nacimiento:");
            Console.WriteLine("Empiece por el dia");
            int.TryParse(Console.ReadLine(),out diaNacimiento);
            Console.WriteLine(" Ingrese el mes");
            int.TryParse(Console.ReadLine(), out mesNacimiento);
            Console.WriteLine(" Ingrese el anio");
            int.TryParse(Console.ReadLine(), out anioNacimiento);

            if (mesHoy > mesNacimiento)
            {
                if (mesNacimiento == 1 || mesNacimiento == 5 || mesNacimiento == 7 || mesNacimiento == 8 || mesNacimiento == 3 || mesNacimiento == 10 || mesNacimiento == 12)
                {
                    diasVividos = 31 - diaNacimiento;
                }
            }
        }
    }
}
