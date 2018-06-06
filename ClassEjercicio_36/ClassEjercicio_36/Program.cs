using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEjercicio_30;

namespace ClassEjercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(15, 3, TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(1, "Mercedes");
            AutoF1 a2 = new AutoF1(2, "Ferrari");
            AutoF1 a3 = new AutoF1(3, "RedBull");
            Motocross m1 = new Motocross(4,"McClaren");

                Console.WriteLine(c1.MostrarDatos());
            

            Console.ReadKey();
        }
    }
}
