using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string (Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nNombre: {0}", e.nombre);
            sb.AppendFormat("\nEspacio Disponible:", e.espacioDisponible);

            foreach(Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            foreach(Vehiculo veh in e.vehiculos)
            {
                if( veh == v)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string retorno = "";
            if(e == v)
            {
                retorno = v.ImprimirTicket();
                e.vehiculos.Remove(v);
            }
            else
            {
                retorno = "El vehiculo no es parte del estacionamiento";
            }
            return retorno;
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e != v && !(Object.ReferenceEquals(v.Patente,null)) && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
    }
}
