using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_17
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void setTinta(short tinta)
        {
            this.tinta = tinta;
        }
        public void Recargar()
        {
            setTinta(cantidadTintaMaxima);
        }
        public Boligrafo(short tinta, ConsoleColor color)
        {
            setTinta(tinta);
            this.color = color;
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            int i;
            int tinta;
            dibujo = "";

            tinta =  this.GetTinta()- gasto;
            if (tinta > 0)
            {
                this.setTinta((short)tinta);
                retorno = true;
            }
            if (this.GetTinta() >= gasto)
            {
                for (i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                for (i = 0; i < this.GetTinta(); i++)
                {
                    dibujo += "*";
                }
            }
            return retorno;
        }

    }
}
