using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100; 
        private ConsoleColor color;
        private short tinta;

        #region Constructor
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.color = color;
        }
        #endregion

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo )
        {
            dibujo = "";
            bool retorno = false;
            int i;
            if((this.tinta - gasto) >= 0)
            {
                this.SetTinta((short)gasto);
                retorno = true;
                for(i = 0; i < gasto;i++)
                {
                    
                    dibujo = dibujo + "*";
                }
            }
            else
            {
                for(i = 0; i < this.tinta; i++)
                {
                    dibujo = "*";
                }
            }
            return retorno;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {

            if((this.tinta + tinta) >= 0 && (this.tinta + tinta) <= cantidadTintaMaxima)
            {
                this.tinta = (short)(this.tinta + tinta);
            }
            else if(tinta == cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }
    }
}
