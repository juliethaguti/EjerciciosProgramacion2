using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_15
{
    class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            double respuesta = 0;

            switch (operacion)
            {
                case '+':
                    respuesta = primerNumero + segundoNumero;
                    break;
                case '-':
                    respuesta = primerNumero - segundoNumero;
                    break;
                case '*':
                    respuesta = primerNumero * segundoNumero;
                    break;
                case '/':
                    if (Validar(segundoNumero))
                    {
                        respuesta = primerNumero / segundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("Segunndo numero inválido para dividir");
                    }
                    break;
                default:
                    break;
            }

            return respuesta;
        }
        private static bool Validar(double segundoNumero)
        {
            bool retorno = false;

            if (segundoNumero != 0)
            {
                retorno = true;
            }
            return retorno;
        }
        public static void Mostrar(double resultado)
        {
            Console.WriteLine("{0}",resultado);
        }
    }
}
