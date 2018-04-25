using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciaPorLocal 
        {
            get
            {
                return this.;
            }
        }

        public List<Llamada> Llamadas 
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            
        }
    }
}
