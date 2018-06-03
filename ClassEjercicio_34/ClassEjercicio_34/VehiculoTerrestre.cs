using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_34
{
    class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        #region Constructor
        public VehiculoTerrestre(short cantidadPuertas, short cantidadRuedas, Colores color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }
        #endregion

        #region Enumeracion
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }
        #endregion

    }
}
