using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_34
{
    class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadPuertas, short cantidadRuedas, Colores color)
            : base(cantidadPuertas, cantidadRuedas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }


    }
}
