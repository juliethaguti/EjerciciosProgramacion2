using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassEjercicio_16
{
    class Alumno
    {
       

        StringBuilder Pantalla = new StringBuilder();
        static Random Final = new Random();

        public string nombre;
        public string apellido;
        public int legajo;

        public float notaFinal = 0;
        public int nota1 = 0;
        public int nota2 = 0;

        public void CalcularFinal()
        {
           if(nota1 >= 4 && nota2 >= 4)
            {
                this.notaFinal = (float)Final.Next(10);
            }
           else
           {
               this.notaFinal = -1;
           }
        }
        public void Estudiar (int nota1, int nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public string mostrar()
        {
            Pantalla.AppendLine(this.nombre);
            Pantalla.AppendLine(this.apellido);
            Pantalla.AppendLine(this.legajo.ToString());
            Pantalla.AppendLine(this.nota1.ToString());
            Pantalla.AppendLine(this.nota2.ToString());
           

            if (this.notaFinal != -1)
            {
                Pantalla.AppendLine(this.notaFinal.ToString());
            }
            else
            {
                Pantalla.AppendLine("Alumno desaprobado");
            }

            return Pantalla.ToString();

        }
    }
}
