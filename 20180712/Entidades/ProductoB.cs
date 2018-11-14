using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        private short alto;
        private short ancho;
        private short largo;

        #region Propiedades
        public short Alto
        {
            get
            {
                return this.alto;
            }
        }

        public short Ancho
        {
            get
            {
                return this.ancho;
            }
        }

        public short Largo
        {
            get
            {
                return this.largo;
            }
        }
        #endregion

        #region Construtores
        public ProductoB()
        { }

        public ProductoB(string descripcion, short largo, short alto, short ancho)
            : base(descripcion)
        {
            this.alto = alto;
            this.largo = largo;
            this.ancho = ancho;
        }
        #endregion

        #region Métodos
        private int CalcularVolumen()
        {
      return this.Ancho * this.Alto * this.Largo;
    }

        public override string Mostrar()
        {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Tipo: B");
      sb.AppendFormat("\nANCHO: {0}", this.Ancho);
      sb.AppendFormat("\nALTO: {0}", this.Alto);
      sb.AppendFormat("\nLARGO: {0}", this.Largo);
      sb.AppendFormat("\nVOLUMEN: {0}", this.CalcularVolumen());

      return sb.ToString();
    }

        public override bool ValidarDimensiones()
        {
            bool retorno = false;

      if((this.Largo + this.Ancho + this.Alto) <= 100)
      {
        retorno = true;
      }
      return retorno;
        }
        #endregion

        #region Sobrecarga
        public static explicit operator int(ProductoB p)
        {

        }
        #endregion
    }
}
