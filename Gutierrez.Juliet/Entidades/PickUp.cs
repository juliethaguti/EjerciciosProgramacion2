using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        #region Constructores
        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string Patente, string modelo)
            : base(Patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string Patente, string modelo, int valorHora)
            : this(Patente,modelo)
        {

        }
        #endregion

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nPatente: {0}", base.Patente);
            sb.AppendFormat("\nModelo: {0}", this.modelo);
            sb.AppendFormat("\nValor Hora {0}", PickUp.valorHora);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }

        public override string ImprimirTicket()
        {
            int cantidadHoras = (this.ingreso - DateTime.Now).Hours * PickUp.valorHora;
            return cantidadHoras.ToString(); 
        }
    }
}
