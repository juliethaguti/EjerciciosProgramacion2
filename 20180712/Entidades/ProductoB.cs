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
        { }

        public string Mostrar()
        { }

        public override bool ValidarDimensiones()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Sobrecarga
        public static explicit operator int(ProductoB p)
        {

        }
        #endregion
    }
}
