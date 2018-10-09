using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                //if (value.Length == 6)
                //{
                    this.patente = value;
                //}
            }
        }

        public Vehiculo (string Patenete)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ToString());
            sb.AppendFormat("\nFecha de ingreso: {0}", this.ingreso);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if(v1.Equals(v2) && v1.Patente == v2.Patente)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }
    }
}
