using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEjercicio_43;

namespace ClassEjercicio_30
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        #region Propiedades
        public List<T> Competidores 
        {
            get
            {
                return this.competidores;
            }
        }
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Constructores
        private Competencia()
        {
            this.competidores = new List<T>();
        }
        public Competencia(short cantVueltas, short cantCompetidores,TipoCompetencia tipo)
            : this()
        {
            this.CantidadVueltas = cantVueltas;
            this.CantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }
        #endregion

        #region Método
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TIPO DE COMPETENCIA: " + this.Tipo);
            sb.AppendLine("CANTIDAD DE COMPETIDORES: " + this.CantidadCompetidores);
            sb.AppendLine("CANTIDAD DE VUELTAS: " + this.CantidadVueltas);
            for(int i= 0; i < this.competidores.Count;i++)
            {
                sb.AppendLine(this.competidores[i].MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Competencia<T> c, T a)
        {
            bool retorno = false;

            foreach (VehiculoDeCarrera auto in c.competidores)
            {
                if (a == auto)
                {
                    retorno = true;
                    break;
                }
            }
            //if (retorno == false)
            //{
            //    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", 
            //        c.GetType().Name, "Operator ==");
            //}
            return retorno;
        }
        public static bool operator !=(Competencia<T> c, T v2)
        {
            return !(c == v2);
        }

        public static bool operator -(Competencia<T> c, T v)
        {
            bool retorno = false;

            if (c == v)
            {
                v.EnCompetencia = false;
                c.Competidores.Remove(v);
                v.VueltasRestantes = 0;
                retorno = true;
            }
            return retorno;
        }
        public static bool operator +(Competencia<T> c, T a)
        {
            bool retorno = false;
            Random combustible = new Random();
            switch (c.Tipo)
            {
                case TipoCompetencia.F1:
                    try
                    {
                        if (c.competidores.Count < c.CantidadCompetidores && c != a)
                        {
                            if (a is AutoF1)
                            {
                                retorno = true;
                                c.competidores.Add(a);
                                a.EnCompetencia = true;
                                a.VueltasRestantes = c.CantidadVueltas;
                                a.CantidadCombustible = (short)combustible.Next(15, 100);
                            }
                        }
                    }
                    catch(CompetenciaNoDisponibleException e)
                    {
                        throw new CompetenciaNoDisponibleException("Competencia incorrecta", c.GetType().Name, "Operator +",e);
                    }
                    break;

                case TipoCompetencia.MotoCross:
                    try
                    {
                        if (c.competidores.Count < c.CantidadCompetidores && c != a)
                        {
                            if (a is Motocross)
                            {
                                retorno = true;
                                c.competidores.Add(a);
                                a.EnCompetencia = true;
                                a.VueltasRestantes = c.CantidadVueltas;
                                a.CantidadCombustible = (short)combustible.Next(15, 100);
                            }
                        }
                    }
                    catch (CompetenciaNoDisponibleException e)
                    {
                        throw new CompetenciaNoDisponibleException("Competencia incorrecta", 
                            c.GetType().Name, "Operator +", e);
                    }
                    break;
            }
            return retorno;
        }
        #endregion
    }
}
