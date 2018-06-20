using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEjercicio_51;
using System.IO;
using ClassEjercicio_54;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private string rutaDeArchivo;

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
            this.RutaDeArchivo = "ArchivoCentralita.txt";
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }

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

        public bool Guardar()
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                StreamWriter archivo = new StreamWriter(this.RutaDeArchivo);
                archivo.WriteLine(String.Format("{0} {1} de {2} de {3} {4}:{5}hs - Se realizó una llamada",fechaActual.ToString("dddd"),
                    fechaActual.Day,fechaActual.ToString("MMMM"),fechaActual.Year,fechaActual.Hour,fechaActual.Minute));
                archivo.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(this.RutaDeArchivo);
            string retorno = archivo.ReadToEnd();
            archivo.Close();

            return retorno;
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
                if (!c.Guardar())
                {
                    throw new FallaLogException("No se pudo guardar", c.GetType().Name, "Sobrecarga +");
                }
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
