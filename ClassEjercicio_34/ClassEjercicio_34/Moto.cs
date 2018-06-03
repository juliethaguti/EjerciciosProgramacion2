using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_34
{
    class Moto :VehiculoTerrestre
    {
        public short cilindrada;

        Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) :base(cantidadPuertas,cantidadRuedas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
