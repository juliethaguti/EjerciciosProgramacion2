using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_30
{
    public enum TipoCompetencia
    {
        F1,MotoCross
    }
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Propiedades
        public short CantidadCombustible 
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia 
        { 
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia 
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero 
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes 
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

        #region Constructor
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        #endregion

        #region Método
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NUMERO: " + this.Numero);
            sb.AppendLine("ESCUDERIA: " + this.Escuderia);
            sb.AppendLine("EN COMPETENCIA: " + this.EnCompetencia);
            sb.AppendLine("CANTIDAD DE COMBUSTIBLE: " + this.CantidadCombustible);
            sb.AppendLine("VUELTAS RESTANTES: " + this.VueltasRestantes);

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool retorno = false;

            if (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
