using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_29
{
    class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {

        }

        private DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: " + this.Nombre + "FECHA DE NACIMIENTO: " + this.fechaNacimiento);

            return sb.ToString();
        }

        public static bool operator !=(DirectorTecnico directorTecnico1, DirectorTecnico directorTecnico2)
        {
            bool retorno = false;

            if(directorTecnico1.Dni != directorTecnico2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(DirectorTecnico directorTecnico1, DirectorTecnico directorTecnico2)
        {
            bool retorno = false;

            if (directorTecnico1.Dni == directorTecnico2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
