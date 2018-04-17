using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this (numero)
        {
            this.nombre = nombre;           
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if (cliente1.numero != cliente2.numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if (cliente1.numero == cliente2.numero)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
