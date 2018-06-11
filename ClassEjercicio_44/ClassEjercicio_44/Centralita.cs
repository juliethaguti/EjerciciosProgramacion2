using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Métodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            ganancia += ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganancia += ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
            }
            return ganancia;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("RAZON SOCIAL: " + this.razonSocial);
            sb.AppendLine(" ");
            sb.AppendLine("GANANCIAS");
            sb.AppendLine("LOCALES: " + this.GananciaPorLocal);
            sb.AppendLine("PROVINCIALES: " + this.GananciaPorProvincial);
            sb.AppendLine("TOTALES: " + this.GananciaPorTotal);
            sb.AppendLine(" ");
            sb.AppendLine("**LLAMADAS**");
            sb.AppendLine(" ");
            foreach (Llamada llamada in Llamadas)
            {
                if (llamada is Local)
                {
                    sb.AppendLine(((Local)llamada).ToString());
                }
                else if (llamada is Provincial)
                {
                    sb.AppendLine(((Provincial)llamada).ToString());
                }
            }
            return sb.ToString();
        }

        public void OrdenarLlamada()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada auxLlamada in c.Llamadas)
            {
                if (llamada == auxLlamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya existe", c.GetType().Name, "Operator +");
            }
            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
