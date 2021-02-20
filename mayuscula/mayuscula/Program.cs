using System;

namespace mayuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PRESIONE UN CARACTER: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("EL CARACTER ESTA EN MINUSCULA.");
                }
                else
                {
                    Console.WriteLine("EL CARACTER ESTA EN MAYUSCULA.");
                }
            }
            else
            {
                Console.WriteLine("EL CARACTER NO ES UN CARACTER ALFABÉTICO.");
            }
        }
    }
}
