using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo r1 = new Recibo(350);
            Factura f1 = new Factura(450);
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            c += f1;
            c += r1;
            Console.Read();
        }
    }
}
