using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;

        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public string MostrarProducto(Producto p)
        {
            StringBuilder miStringBuilder = new StringBuilder();

            miStringBuilder.AppendLine(p.GetMarca());
            miStringBuilder.AppendLine(p.GetPrecio().ToString());
            miStringBuilder.AppendLine((string)p);

            return miStringBuilder.ToString();
        }
        public static explicit operator string(Producto producto)
        {
            string retorno = null;
            if(!object.ReferenceEquals(producto,null))
            {
                retorno = producto.codigoDeBarra;
            }
            return retorno;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;

            if ((string)p1 != (string)p2 && p1.GetMarca() != p2.GetMarca())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;

            if (p.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p, string marca)
        {
            bool retorno = false;

            if (p.GetMarca() != marca)
            {
                retorno = true;
            }
            return retorno;
        }      
    }
}
