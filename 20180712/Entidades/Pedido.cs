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
        {
      foreach(Producto p in this.Productos)
      {
        System.Threading.Thread.Sleep(1000);
        p.Elaborar();
      }
    }
        #endregion

        #region Sobrecargas
        public static implicit operator String(Pedido unPedido)
        {
      StringBuilder sb = new StringBuilder();

            foreach(Producto p in unPedido.Productos)
      {
        sb.AppendLine(p.Mostrar());
      }
      return sb.ToString();
        }

        public static Pedido operator +(Pedido unPedidio, Producto unProducto)
        {
      if(unPedidio.Productos.Count < 5)
      {
        unPedidio.Productos.Add(unProducto);
      }
    }
        #endregion
    }
}
