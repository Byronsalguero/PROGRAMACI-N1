using System;

namespace descuento
{
    class Program
    {
        static void Main(string[] args)
        {

            int total, pago;
            Console.WriteLine("ingrese una cantidad de dinero:");

            int compra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el porcentaje de descuento");
            int descuento = Convert.ToInt32(Console.ReadLine());

            total = compra * descuento / 100;
            pago = compra - descuento;
            Console.WriteLine("total a pagar:" + pago);

            if (pago >= 300)
                Console.WriteLine(pago = compra - descuento);

            else if (pago < 300)
                Console.WriteLine("NO HAY DESCUENTO");
      
            }
        }
    }


