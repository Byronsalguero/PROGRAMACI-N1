using System;

namespace IMPUESTO
{
    class Program
    {
        static void Main(string[] args)
        {





            string opciones;
            int total;
            int p;



            Console.WriteLine("QUE TIPO DE PRODUCTO ES:  1-medicinal o 2-otro");
            opciones = Console.ReadLine();

            switch (opciones)
            {
                case "1":
                    Console.WriteLine("----medicinal----");

                    Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO:");
                    p = Convert.ToInt32(Console.ReadLine());
                    total = p;
                    Console.WriteLine("NO HAY IMPUESTO PARA ESTE PRODUCTO:" + total);

                    break;

                case "2":
                    Console.WriteLine("---otro---");
                    Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO:");
                    p = Convert.ToInt32(Console.ReadLine());

                    total = (int)(p / 1.12);

                    Console.WriteLine("EL PRECIO DEL PRODUCTO SIN IMPUESTO ES DE:" + total);

                    break;
            }
            }
        }
}
