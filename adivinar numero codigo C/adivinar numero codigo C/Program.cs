using System;

namespace adivinar_numero_codigo_C
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int NUMERO, MULTIPLICACION, MULTI2, SUMA, DIVISION, RESTA;

            Console.BackgroundColor = ConsoleColor.Blue;
            


            Console.Write("________________INGRESE CUALQUIER NUMERO__________________: ");
            NUMERO= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   ");
            Console.WriteLine("Multiplique EL número por 2");
            Console.ReadKey();
            
            MULTIPLICACION = NUMERO * 2;
            Console.WriteLine("   ");
            Console.WriteLine("Ahora sumele 8 al resultado");
            Console.ReadKey();

            SUMA = MULTIPLICACION + 8;
            Console.WriteLine("   ");
            Console.WriteLine("Al resultado multipliquelo por 5");
            Console.ReadKey();

            MULTI2 = SUMA* 5;
            Console.WriteLine("   ");
            Console.WriteLine("EL RESULTADO FINAL ES : {0}", MULTI2);
            Console.WriteLine("AHORA ADIVINARE TU NUMERO:");
            Console.ReadKey();

            DIVISION= MULTI2 / 10;

            RESTA = DIVISION - 4;
            Console.WriteLine("   ");
            Console.WriteLine("El número que pensó es: {0}", RESTA);
            Console.ReadKey();


        }
    }
}
