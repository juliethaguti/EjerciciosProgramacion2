using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

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
                if(validarMaterial(value))
        {
          this.material = value;
        }
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
        public override string Mostrar()
        {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Tipo: A");
      sb.AppendFormat("\nDIAMETRO: {0}", this.Diametro);
      sb.AppendFormat("\nMATERIAL: {0}", this.Material);

      return sb.ToString();
    }

        public override bool ValidarDimensiones()
        {
      bool retorno = false;

      if((this.Diametro % 2) == 0 && this.Diametro >= 30 && this.Diametro <= 50)
      {
        retorno = true;
      }

      return retorno;
        }

        public bool validarMaterial(Material unMaterial)
        {
            bool retorno = false;
      switch (unMaterial)
      {
        case Material.Aluminio:
          if (this.Diametro <= 10 && this.ValidarDimensiones())
          {
            retorno = true;
          }
          else
          {
            string mensaje = "No se puede fabricar una pieza de Aluminio y diametro " + this.Diametro + " centimetros";
            throw new MaterialException(mensaje);
          }
          break;

        case Material.Caucho:
          if (this.Diametro <= 15 && this.ValidarDimensiones())
          {
            retorno = true;
          }
          else
          {
            string mensaje = "No se puede fabricar una pieza de Caucho y diametro " + this.Diametro + " centimetros";
            throw new MaterialException(mensaje);
          }
          break;

        case Material.Plastico:
          if(this.ValidarDimensiones())
          {
            retorno = true;
          }
          else
          {
            string mensaje = "No se puede fabricar una pieza de Plastico y diametro " + this.Diametro + " centimetros";
            throw new MaterialException(mensaje);
          }
          break;
      }

      return retorno;
     
      }
        #endregion
    }
}
