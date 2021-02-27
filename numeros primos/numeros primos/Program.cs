using System;

namespace numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 1;
            Console.WriteLine("Introduce la cantidad de numeros primos que deseas:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; cont <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(cont + "ESTE ES UN NUMERO PRIMO:" + i);
                    cont++;
                }
            }
        }
    }
}





