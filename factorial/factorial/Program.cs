using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {

			byte numero, i;
			long result = 1;
			string linea;

			Console.Write("INGRESA UN NUMERO : ");
			linea = Console.ReadLine();
			numero = byte.Parse(linea);
			for (i = 2; i <= numero; i++)
			{
				result = result * i;
			}
			Console.WriteLine("El FACTORIAL DE {0} es {1}", numero, result);

        }
    }
}
