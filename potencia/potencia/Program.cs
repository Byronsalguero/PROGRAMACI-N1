using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2, potencia = 4;
            double elevado = Math.Pow(numero, potencia); 
            Console.WriteLine(string.Format("{0} elevado a la potencia {1} es {2}", numero, potencia, elevado));

        }
    }
}
