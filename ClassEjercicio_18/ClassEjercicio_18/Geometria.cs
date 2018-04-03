using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class punto
    {
        private int x;
        private int y;

        public punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
    }
    public class rectangulo
    {
        private float baseRectangulo;
        private float altura;
        private float area;
        private float perimetro;
        private punto vertice1;
        private punto vertice2;
        private punto vertice3;
        private punto vertice4;

        public rectangulo(punto vertice1,punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new punto(vertice3.GetX(),vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new punto(vertice1.GetX(), vertice3.GetY());
            this.baseRectangulo = Math.Abs(vertice3.GetX() - vertice4.GetX());
            this.altura = Math.Abs(vertice1.GetY() - vertice4.GetY());

            
        }
        public float GetBase()
        {
            return this.baseRectangulo;
        }
        public float GetAltura()
        {
            return this.altura;
        }
        public float GetArea()
        {
            return this.Area();
        }
        public float GetPerimetro()
        {
            return this.Perimetro();
        }
        private float Area()
        {
            this.area = GetBase() * GetAltura();
            return this.area;
        }
        private float Perimetro()
        {
            this.perimetro = ((GetBase() + GetAltura()) * 2);
            return this.perimetro;
        }
        public void mostrarDatosRectangulo(float baseRectangulo, float altura)
        {
            Console.WriteLine("***********DATOS DEL RECTANGULO***********");
            Console.WriteLine("Base: {0}", baseRectangulo);
            Console.WriteLine("Altura: {0}", altura);
        }
    }
}
