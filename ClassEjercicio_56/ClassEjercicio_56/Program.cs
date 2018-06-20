using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carmen", "Jarammillo");
            Persona.Guardar(p);

            Persona p1 = Persona.Leer();
            Console.WriteLine(p1.ToString());

            Console.ReadKey();
        }
    }
}
