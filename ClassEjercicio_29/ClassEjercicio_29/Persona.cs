using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_29
{
    class Persona
    {
        protected long dni;
        protected string nombre;

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        
        public Persona(long dni, string nombre)
            : this(nombre)
        {
            this.Dni = dni;
        }

        #region Propiedades
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
        #endregion

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: "+this.Nombre+"DNI: "+this.Dni);

            return sb.ToString();
        }
    }
}
