using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] arrayProductos;

        private Estante(int capacidad)
        {
            this.arrayProductos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.arrayProductos;
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            for (i = 0; i < e.arrayProductos.Length; i++)
            {
                if (p == e.arrayProductos[i])
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            for (i = 0; i < e.arrayProductos.Length; i++)
            {
                if(p != e.arrayProductos[i])
                {
                   retorno = true;
                }
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            for (i = 0; i < e.arrayProductos.Length; i++)
            {
                if (e.arrayProductos[i] == p)
                {
                    e.arrayProductos[i] = null;
                }
            }
            return e;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            int i;

            for(i = 0; i < e.arrayProductos.Length ; i++)
            {
          
                if (e.arrayProductos[i] == p)
                {
                        break;                                     
                }
                else if (object.ReferenceEquals(e.arrayProductos[i], null))
                    {
                        e.arrayProductos[i] = p;
                        retorno = true;
                        break;
                    }
            }
            return retorno;
        }
        
        public string MostrarEstante(Estante e)
        {
            StringBuilder miStringBuilder = new StringBuilder();
            int i;
            miStringBuilder.AppendLine("Nº DE ESTANTE: " + e.ubicacionEstante.ToString());

            for(i = 0; i < e.arrayProductos.Length; i++)
            {
                if(!object.ReferenceEquals(e.arrayProductos[i],null))
                {
                    miStringBuilder.AppendLine(e.arrayProductos[i].MostrarProducto(arrayProductos[i]));
                }
            }
            return miStringBuilder.ToString();
        }
    }
}
