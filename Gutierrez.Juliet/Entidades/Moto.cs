using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {

        private int cilindrada;
        private short ruedas;
        static int valorHora;

        #region Constructores
        static Moto()
        {
            valorHora = 30;
        }
        public Moto(string patente, int cilindrada)
            : base(patente)
        {
            this.cilindrada = cilindrada;
        }
        public Moto( string patente, int cilindrada, short ruedas)
            : this(patente, cilindrada)
        {
            this.ruedas = 2;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            : this(patente, cilindrada, ruedas)
        {

        }
        #endregion

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nPatente: {0}", base.Patente);
            sb.AppendFormat("\nCilindrada: {0}", this.cilindrada);
            sb.AppendFormat("\nRuedas: {0}", this.ruedas);
            sb.AppendFormat("\nValor Hora: {0}", Moto.valorHora);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ImprimirTicket()
        {
           int cantidadHoras = (this.ingreso - DateTime.Now).Hours *Moto.valorHora;
            return cantidadHoras.ToString();
        }
    }

}
