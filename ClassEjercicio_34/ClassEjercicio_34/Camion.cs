using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_34
{
    class Camion :VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        Camion(short cantidadMarchas, int pesoCarga, short cantidadRuedas, short cantidadPuertas, Colores color)
            : base(cantidadPuertas, cantidadRuedas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
