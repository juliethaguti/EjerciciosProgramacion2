using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private List<Producto> productos;

        #region Propiedades
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }
        #endregion

        #region Consstructor
        public Pedido()
        { }
        #endregion

        #region Método
        public void FabricarPedido()
        { }
        #endregion

        #region Sobrecargas
        public static implicit operator String(Pedido unPedido)
        {
            return unPedido.ToString();
        }

        public static Pedido operator +(Pedido unPedidio, Producto unProducto)
        { }
        #endregion
    }
}
