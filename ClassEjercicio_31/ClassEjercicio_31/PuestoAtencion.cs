using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        #region Propiedades
        public static int NumeroActual 
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
#endregion

        #region Enumeraciones
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        #endregion

        #region Metodos
        public bool Atender(Cliente cli)
        {
            bool retorno = false;

            if (cli != null)
            {
                System.Threading.Thread.Sleep(2500);
                retorno = true;
            }
            return retorno;
        }
        #endregion

    }
}
