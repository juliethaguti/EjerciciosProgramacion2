using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2ParcialLaboratorio2
{
    class Equipo
    {
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public enum Deportes
        {
            Basquet, Futbol, Handball, Rugby
        }

        public Deportes Deporte 
        {
            set
            {
                deporte = value;
            }
        }

        static Equipo()
        {
            Equipo.deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico directorTecnico)
            : this()
        {
            this.nombre = nombre;
            this.dt = directorTecnico;
        }

        public Equipo(string nombre, DirectorTecnico directorTecnico, Deportes deporte)
            : this(nombre, directorTecnico)
        {
            Equipo.deporte = deporte;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**"+e.nombre+" "+Equipo.deporte+"**");
            sb.AppendLine("Nómina Jugadores:");
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.ToString());
            }
            sb.AppendLine("Dirigido por: " + e.dt);

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            foreach (Jugador jugador in e.jugadores)
            {
                if (j == jugador)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
            {
                e.jugadores.Remove(j);
            }
            return e;
        }
    }
}
