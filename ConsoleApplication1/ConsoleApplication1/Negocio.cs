using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente Cliente {
            get
            {
                return this.Cliente;
            }
            set
            {
                this.Cliente = value;
            }
        }
        public static bool operator +(Negocio negocio, Cliente c)
        {
            bool retorno = false;

            if(negocio == c)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
                negocio.clientes.Enqueue(c);
            }
            return retorno;
        }
        public static bool operator != (Negocio n,Cliente c)
            {
                bool retorno = false;
                foreach (Cliente cliente in n.clientes)
                {
                    if (c != cliente)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
                return retorno;
            }
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cliente in n.clientes)
            {
                if (c == cliente)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
