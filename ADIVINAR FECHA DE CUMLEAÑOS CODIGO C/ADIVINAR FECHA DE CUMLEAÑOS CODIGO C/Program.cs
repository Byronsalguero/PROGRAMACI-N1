using System;

namespace ADIVINAR_FECHA_DE_CUMLEAÑOS_CODIGO_C
{
    class Program
    {
        static void Main(string[] args)
        {



            int NUMERO, MULTI1, MULTI2, SUMA1, SUMA2, RESTA, MES;
            int A, B, C, D;
            Console.BackgroundColor = ConsoleColor.Blue;
            try
            {
                Console.Write("INGRESE EL DIA QUE NACIO : ");
                NUMERO = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("     ");
                Console.WriteLine("MULTIPLICALO por 20");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                MULTI1 = NUMERO * 20;

                Console.WriteLine("     ");
                Console.WriteLine("Al resultado sumale 73");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                SUMA1 = MULTI1 + 73;

                Console.WriteLine("     ");
                Console.WriteLine("Ahora multiplicalo por 5");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                MULTI2 = SUMA1 * 5;

                Console.WriteLine("     ");
                Console.Write("Ingresa la fecha de mes de tu cumpleaños: ");
                MES = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sumale la fecha del mes de tu cumpleaños");

                SUMA2 = MULTI2 + MES;

                RESTA = SUMA2 - 365;

                Console.WriteLine("     ");
                Console.WriteLine("Ahora procedera adivinar su fecha de cumpleaños");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                if (RESTA >= 1)
                {
                    if (RESTA <= 9999)
                    {
                        A = RESTA / 1000;
                        B = (RESTA % 1000) / 100;
                        C = (RESTA % 1000) % 100 / 10;
                        D = ((RESTA % 1000) % 100) % 100 / 1;
                        Console.WriteLine("La fecha de su cumpleaños es: {0}{1}/{2}{3} ", A, B, C, D);
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Datos ingresados no validos");
                Console.ReadKey();



            }
            }
        }
}
