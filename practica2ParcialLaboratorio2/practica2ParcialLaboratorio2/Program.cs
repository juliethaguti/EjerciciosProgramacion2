using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2ParcialLaboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt = new DirectorTecnico("Jorge", "Habberger");
            Equipo e1 = new Equipo("Huracan de San Rafael", dt, Equipo.Deportes.Futbol);
            Jugador j1 = new Jugador("Ferando","Pandolfi",11,false);
            Jugador j2 = new Jugador("Julio","Marchant",8,false);
            Jugador j3 = new Jugador("Ezequiel","Medran",12,false);
            Jugador j4 = new Jugador("José","Pereda",24,false);
            Jugador j5 = new Jugador("Hernán","Florentin",6,false);
            Jugador j6 = new Jugador("Fernando","Navas",11,true);
            Jugador j7 = new Jugador("José", "Pereda", 24, false);

            e1 += j1;
            e1 += j2;
            e1 += j3;
            e1 += j4;
            e1 += j5;
            e1 += j6;
            e1 += j7;

            Console.Write((string)e1);
            Console.ReadKey();

            Console.WriteLine("****************************************");

            e1 -= j1;
            e1 -= j5;

            Console.Write((string)e1);
            Console.ReadKey();
        }
    }
}
