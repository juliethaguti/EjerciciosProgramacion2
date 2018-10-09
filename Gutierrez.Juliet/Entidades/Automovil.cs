using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        #region Constructores
        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            : this(patente,color)
        {

        }

        #endregion

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nPatente: {0}", base.Patente);
            sb.AppendFormat("\nColor: {0}", this.color);
            sb.AppendFormat("\nValor Hora {0}", Automovil.valorHora);

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ImprimirTicket()
        {
            int cantidadHoras = (this.ingreso - DateTime.Now).Hours * Automovil.valorHora;
            return cantidadHoras.ToString();
        }
    }
}
