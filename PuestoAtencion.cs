using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual {
            get
            {
                return numeroActual++;
            }
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cliente)
        {
     

            Thread.Sleep(1);
            
            bool retorno = true;

            return retorno;
        }
        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
