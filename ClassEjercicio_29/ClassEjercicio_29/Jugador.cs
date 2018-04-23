using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_29
{
    class Jugador : Persona
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(string nombre) : base(nombre)
        {

        }

        public Jugador(string nombre, int totalGoles, int totalPartidos) : this(nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder miStringBuilder = new StringBuilder();

            miStringBuilder.AppendLine("NOMBRE DEL JUGADOR: "+this.nombre+"DNI: "+this.dni.ToString());
            miStringBuilder.AppendLine("PARTIDOS JUGADOS: "+this.partidosJugados.ToString()+"TOTAL GOLES: "+this.totalGoles.ToString()+"PROMEDIO GOLES: "+this.PromedioGoles.ToString());

            return miStringBuilder.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1.dni != j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }
        public int PartidosJugados 
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public int TotalGoles 
        {
            get
            {
                return this.totalGoles;
            }
        }
        public float PromedioGoles 
        {
            get
            {
                return this.TotalGoles / (float)this.PartidosJugados;
            }
        }

        public long Dni 
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}
