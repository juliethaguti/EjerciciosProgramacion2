using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ENacionalidad
    {
        Argentino, Extranjero
    }
    public abstract class Persona
    {
        #region Atributos
        string apellido;
        int dni;
        string nombre;
        ENacionalidad nacionalidad;
        #endregion

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

        public int DNI
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

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
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

        public string StringToDNI { get; set; }
        #endregion

        #region Constructores
        public static Persona()
        { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad)
            : this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {

        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return base.ToString();
        }

        int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            string dni = Convert.ToString(dato);

            if(nacionalidad == ENacionalidad.Extranjero && dni.StartsWith("9"))
            {
                if(dni.Length == 8)
                {
                    return dato;
                }
                else
                {

                }
            }
            else
            {

            }
        }

        int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            
        }

        string ValidarNombreApellido(string dato)
        {
            var charDato = dato.ToCharArray();

            for(int i = 0; i < charDato.Length; i++)
            {
                if(charDato[i] > 'a' && charDato[i] < 'Z')
                {
                    return dato;
                }
                else
                {

                }
            }
        }
        #endregion
    }
}
