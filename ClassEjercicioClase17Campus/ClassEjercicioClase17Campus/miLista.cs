using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicioClase17Campus
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] items;

        public MiLista()
        {
            this.items = new T[0];
        }
        #region Propiedad
        public int Count
        {
            get
            {
                return this.items.Length;
            }
        }

        #endregion

        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            this.items[items.Length - 1] = item;
        }

        public bool Remove(T item)
        {
            bool retorno = false;
            int indice = Array.IndexOf(items, item);
            if (indice >= 0)
            {
                retorno = true;
                for (int i = indice; i < this.items.Length-1; i++)
                {
                    this.items[i] = this.items[i + 1];
                }
                Array.Resize(ref items, items.Length - 1);
            }

            return retorno;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.items)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for(int i = 0; i < this.items.Length; i++)
            {
                yield return this.items[i];
            }
        }
    }
}
