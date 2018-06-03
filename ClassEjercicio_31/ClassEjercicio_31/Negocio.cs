using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente 
        {
            get
            {
                return this.clientes.Dequeue() ;
            }
            set
            {
                bool var = (this + value);
            }
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
    }
}
