using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_50
{
    class GuardarTexto<T, V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            string retorno = "Texto Leido";

            return (V)Convert.ChangeType(retorno, typeof(V));
        }
    }
}
