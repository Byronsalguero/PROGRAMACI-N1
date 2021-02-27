using System;

namespace DIAS_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero;

            Console.WriteLine("UN NUMERO DEL 1 al 7:");
            numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    Console.WriteLine("Lunes.");
                    break;
                case "2":
                    Console.WriteLine("Martes.");
                    break;
                case "3":
                    Console.WriteLine("Miercoles.");
                    break;
                case "4":
                    Console.WriteLine("Jueves.");
                    break;
                case "5":
                    Console.WriteLine("viernes.");
                    break;
                case "6":
                    Console.WriteLine("sabado.");
                    break;
                case "7":
                    Console.WriteLine("Domingo.");
                    break;

                default:

                    break;
            }
            }
        }
}
