using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Enumeraciones
    public enum Material
    {
        Plastico, Aluminio, Caucho
    }
    #endregion
    public abstract class Producto
    {
        private string descripcion;
    public delegate void ProductoTerminado(Object sender, EventArgs e);
    public event ProductoTerminado InformarProductoTerminado;

        #region Propiedades
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        #endregion

        #region Constructores
        public Producto()
        { }

        public Producto(string descripcion)
        {
            this.descripcion = descripcion;
        }
        #endregion

        #region Métodos
        public void Elaborar()
        {

      InformarProductoTerminado();
    }

        public virtual string Mostrar()
        {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("DESCRIPCION: {0}", this.Descripcion);

      return sb.ToString();
    }

        public abstract bool ValidarDimensiones();
        #endregion
    }
}
