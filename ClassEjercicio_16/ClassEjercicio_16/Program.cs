using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Juana";
            alumno1.apellido = "LaLoca";
            alumno1.legajo = 105060;
            alumno1.nota1 = 6;
            alumno1.nota2 = 7;
            alumno1.CalcularFinal();

            alumno2.nombre = "Gertrudis";
            alumno2.apellido = "LaLocomotora";
            alumno2.legajo = 105061;
            alumno2.nota1 = 2;
            alumno2.nota2 = 8;
            alumno2.CalcularFinal();

            alumno3.nombre = "German";
            alumno3.apellido = "ElAleman";
            alumno3.legajo = 105062;
            alumno3.nota1 = 2;
            alumno3.nota2 = 2;
            alumno3.CalcularFinal();

            Console.WriteLine("Datos del alumno1: {0}",alumno1.mostrar());
            Console.WriteLine("Datos del alumno 2: {0}", alumno2.mostrar());
            Console.WriteLine("Datos del alumno 3: {0}", alumno3.mostrar());
            Console.ReadLine();

        }
    }
}
