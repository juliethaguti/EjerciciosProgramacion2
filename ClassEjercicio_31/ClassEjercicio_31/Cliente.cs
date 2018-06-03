using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_31
{
    class Cliente
    {
        private int numero;
        private string nombre;

        #region Propiedades
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

        public int Numero 
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }
        #endregion

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool retorno = false;

            if (c1.Numero != c2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static operator ==(Cliente c1,Cliente c2)
        {
            return !(c1 != c2);
        }
    }
}
