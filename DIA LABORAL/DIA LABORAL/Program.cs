using System;

namespace DIA_LABORAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("introduce un DIA de la Semana");
            dia = Console.ReadLine();
            switch(dia)
            {

                case "LUNES":
                Console.WriteLine("DIA LABORAL");
                    break;

                case "MARTES":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;

                case "MIERCOLES":
                    Console.WriteLine("DIA LABORAL");
                    break;


                case "JUEVES":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;

                case "VIERNES":
                    Console.WriteLine("DIA LABORAL");
                    break;

                case "SABADO":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;

                case "DOMINGO":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;

                default:
                    Console.WriteLine("INTRODUZCA UN DIA PORFAVOR");
                    break;





            }
        }
    }
}
