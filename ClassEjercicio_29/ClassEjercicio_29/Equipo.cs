using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombreEquipo;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombreEquipo = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            foreach (Jugador j in equipo.jugadores)
            {
                if (j == jugador)
                {
                    return retorno;
                }

            }
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                equipo.jugadores.Add(jugador);
                retorno = true;
            }
            return retorno;
        }

        #region Propiedades
        public short CantidadDeJugadores 
        {
            get
            {
                return this.cantidadDeJugadores;
            }
        }

        public List<Jugador> Jugadores 
        {
            get
            {
                return this.jugadores;
            }
        }
        public string NombreEquipo 
        {
            get
            {
                return this.nombreEquipo;
            }
        }
        #endregion

    }
}
