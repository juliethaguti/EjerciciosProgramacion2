using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Universitario
    {
        #region Atributos
        private Queue<EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores
        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {
            this.clasesDelDia = new Queue<EClases>();
            this.clasesDelDia.Enqueue();
        }

        public Profesor(int id, string nombre, string apellido, string dni,ENacionalidad nacionalidad)
            : base(id,nombre,apellido,dni,nacionalidad)
        { }
        #endregion

        #region Métodos
        private void _randomClases()
        { }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nID: {0}", this.Legajo);
            //sb.AppendFormat("\nNOMBRE: {0}", this.Nombre);
            //sb.AppendFormat("\nAPELLIDO: {0}", this.Apellido);
            //sb.AppendFormat("\nDNI: {0}", this.DNI);
            //sb.AppendFormat("\nNACIONALIDAD: {0}", this.Nacionalidad);
            sb.Append(base.MostrarDatos());

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA");
            foreach(EClases c in clasesDelDia)
            {
                sb.AppendLine(this.clasesDelDia.Dequeue.ToString());
            }
            return sb.ToString() ;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Sobrecargas de operadores
        public static bool operator !=(Profesor i, EClases clase)
        {

        }

        public static bool operator ==(Profesor i, EClases clase)
        {

        }
        #endregion
    }
}
