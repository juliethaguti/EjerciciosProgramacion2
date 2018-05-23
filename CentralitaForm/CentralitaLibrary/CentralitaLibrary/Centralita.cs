using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        #region Propiedades
        public float GananciasPorLocal 
        { 
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        { 
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        { 
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas 
        { 
            get
            {
                return this.listaDeLlamada;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float Ganancia = 0;
            float ganaciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in listaDeLlamada)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            Ganancia += ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            Ganancia += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganaciaLocal += ((Local)llamada).CostoLlamada;
                        }
                        if(llamada is Provincial)
                        {
                            gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                        }
                        Ganancia = gananciaProvincial + ganaciaLocal; 
                        break;
                }
            }
            return Ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("RAZON SOCIAL: "+this.razonSocial);
            sb.AppendLine("GANACIA LOCAL: "+this.GananciasPorLocal);
            sb.AppendLine("GANANCIA PROVINCIAL: "+this.GananciasPorProvincial);
            sb.AppendLine("GANANCIA TOTAL: "+this.GananciasPorTotal);
            sb.AppendLine(" ");
            sb.AppendLine("**********DETALLE DE LLAMADAS**********");
            sb.AppendLine(" ");
            foreach(Llamada llamada in this.Llamadas)
            {
                sb.Append(llamada.ToString());
                sb.AppendLine(" ");
            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada auxLlamada in c.Llamadas)
            {
                if (llamada == auxLlamada)
                {
                    retorno = true;
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
            return c;
        }
        #endregion
    }
}
