using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2ParcialLaboratorio2
{
    class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan 
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }

        public int Numero 
        {
            get
            {
                return this.numero;
            }
                set
                {
                    this.numero = value;
                }
        }

        public Jugador(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        public Jugador(string nombre, string apellido, int numero, bool capitan)
            : this(nombre, apellido)
        {
            this.Numero = numero;
            this.EsCapitan = esCapitan;
        }

        public override bool Equals(object obj)
        {
            return obj is Jugador && this == (Jugador)obj;
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }

        protected override string FichaTecnica()
        {
            string retorno = "";
            if (this.EsCapitan)
            {
                retorno = String.Format(base.NombreCompleto() + ", capitan del equipo, camiseta numero {0}", this.Numero);
            }
            else
            {
                retorno = String.Format(base.NombreCompleto()+" camiseta numero {0}",this.Numero);
            }
            return retorno;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Nombre == j2.Nombre) && (j1.Apellido == j2.Apellido) && j1.Numero == j2.Numero;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
