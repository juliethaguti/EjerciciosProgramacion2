using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string apellido;
        private string nombre;

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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

        #region Constructor
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        #region Método
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBBRE: " + this.Nombre);
            sb.AppendLine("APELLIDO: " + this.Apellido);

            return sb.ToString();
        }
        #endregion
    }
}
