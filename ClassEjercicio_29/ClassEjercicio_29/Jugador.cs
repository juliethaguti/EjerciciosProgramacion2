using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_29
{
    class Jugador : Persona
    {
        //private long dni;
        //private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Constructores
        //private Jugador()
        //{
        //    this.partidosJugados = 0;
        //    this.totalGoles = 0;
        //}

        public Jugador(string nombre) : base(nombre)
        {

        }

        public Jugador(string nombre, int totalGoles, int totalPartidos) : this(nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        public override string MostrarDatos()
        {
            StringBuilder miStringBuilder = new StringBuilder();

            miStringBuilder.AppendLine(base.MostrarDatos());
            miStringBuilder.AppendLine("PARTIDOS JUGADOS: "+this.PartidosJugados+"TOTAL GOLES: "+this.TotalGoles+"PROMEDIO GOLES: "+this.PromedioGoles);

            return miStringBuilder.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1.Dni == j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #region Propiedades
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
        //public long dni 
        //{
        //    get
        //    {
        //        return this.dni;
        //    }
        //    set
        //    {
        //        this.dni = value;
        //    }
        //}

        //public string Nombre 
        //{
        //    get
        //    {
        //        return this.nombre;
        //    }
        //    set
        //    {
        //        this.nombre = value;
        //    }
        //}
        #endregion
    }
}
