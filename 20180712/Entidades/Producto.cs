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
        //public delegate ProductoTerminado
        //public event ProductoTerminado InformarProductoTerminado

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
        { }

        public string Mostrar()
        { }

        public abstract bool ValidarDimensiones();
        #endregion
    }
}
