using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoA : Producto
    {
        private short diametro;
        private Material material;

        #region Propiedades
        public short Diametro
        {
            get
            {
                return this.diametro;
            }
        }

        public Material Material
        {
            get
            {
                return this.material;
            }
            set
            {
                this.material = value;
            }
        }
        #endregion

        #region Constructores
        public ProductoA()
        { }

        public ProductoA(string descripcion,short diametro, Material material)
            : base(descripcion)
        {
            this.diametro = diametro;
            this.Material = material;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        { }

        public override bool ValidarDimensiones()
        {
            throw new NotImplementedException();
        }

        public bool validarMaterial(Material unMaterial)
        {
            bool retorno = false;

            return retorno;
        }
        #endregion
    }
}
