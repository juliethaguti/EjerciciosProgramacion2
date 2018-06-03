using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CllassEjercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = -1;

            area = lado * lado;

            return area;
        }
        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double area = -1;

            area = baseTriangulo * alturaTriangulo / 2;

            return area;
        }
        public static double CalcularCirculo(double radio)
        {
            double area = -1;

            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }

    }
}
